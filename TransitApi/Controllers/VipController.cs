using System.Net;
using System.Text;
using System.Text.Json;
using DotMatrixDisplay;
using Microsoft.AspNetCore.Mvc;
using R4Utils.Uri;
using SixLabors.ImageSharp.PixelFormats;
using TtssClient;
using TtssClient.Dtos;
using TtssClient.Dtos.Requests;
using TtssClient.Dtos.Responses;
using TtssClient.Models;

namespace TransitApi.Controllers;

[Route("api/vip")]
[ApiController]
public class VipController : ControllerBase
{
    private readonly ITtssApi _ttssApi;

    public VipController(ITtssApi ttssApi)
    {
        _ttssApi = ttssApi;
    }
    private static Rgb24 BackgroundColor { get; } = new(0x23, 0x29, 0x23); 
    private static Rgb24 InactivePixelColor { get; } = new(0x23, 0x2d, 0x23);
    private static Rgb24 ActivePixelColor { get; } = new(0xd1, 0x5a, 0x1a);

    [HttpGet("{stopId:int}")]
    public async Task<IActionResult> CheckIfStopExists(int stopId, CancellationToken cancellationToken)
    {
        var stops = await _ttssApi.GetStopsAsync(new StopsRequest(), cancellationToken);
        return stops.Stops.Any(stop => stop.ShortName == stopId.ToString()) ? Ok() : NotFound();
    }

    [Obsolete("The functionality of generating GIFs has been removed.")]
    [HttpGet("{id:int}/dotmatrix")]
    public IActionResult GetDotMatrixById(int id)
    {
        return RedirectPermanentPreserveMethod($"dotmatrix/1");
    }

    [HttpGet("{stopId:int}/dotmatrix/info")]
    public async Task<IActionResult> GetDotMatrixInfo(int stopId, CancellationToken cancellationToken)
    {
        try
        {
            var stop = await _ttssApi.GetStopPassagesAsync(new StopPassagesRequest
            {
                StopName = stopId.ToString(),
                PassageMode = Mode.Departure,
            }, cancellationToken);
            var (pages, _) = await RealTimeToDotMatrix.Vip.RealTimeToDotMatrix.GetPages(stop, cancellationToken);
            return Ok(pages.Count);
        }
        catch (HttpRequestException ex)
        {
            var json = JsonSerializer.Serialize(ex.ToString());
            return NotFound(json);
        }
    }

    [HttpGet("{stopId:int}/dotmatrix/{page:int}")]
    public async Task<IActionResult> GetDotMatrixPageById(int stopId, int page, CancellationToken cancellationToken)
    {
        try
        {
            var stop = await _ttssApi.GetStopPassagesAsync(new StopPassagesRequest
            {
                PassageMode = Mode.Departure,
                StopName = stopId.ToString(),
            }, cancellationToken);
            var (pages, dimensions) =
                await RealTimeToDotMatrix.Vip.RealTimeToDotMatrix.GetPages(stop, cancellationToken);
            if (page <= 0 || pages.Count < page)
            {
                return NotFound($$"""
                {
                    "message": "Page {{page}} is out of bounds for station {{stop.StopName}} with {{pages.Count}} page(s)."
                }
                """);
            }

            var requiredPage = pages[page - 1]; // -1 because `page` is 1-indexed.
            var dotMatrixCanvas =
                new DotMatrixCanvas<Rgb24>(dimensions, BackgroundColor, InactivePixelColor, ActivePixelColor);
            dotMatrixCanvas.WriteText(requiredPage);
            var ms = new MemoryStream();
            dotMatrixCanvas.SaveToStream(ms);
            await ms.FlushAsync(cancellationToken);
            ms.Position = 0;
            return new FileStreamResult(ms, "image/png");
        }
        catch (HttpRequestException ex)
        {
            var json = JsonSerializer.Serialize(ex.ToString());
            return NotFound(json);
        }
    }

    [HttpGet("{stopId:int}/info")]
    public async Task<IActionResult> GetInfoById(int stopId, CancellationToken cancellationToken)
    {
        try
        {
            var stop = await _ttssApi.GetStopPassagesAsync(new StopPassagesRequest
            {
                PassageMode = Mode.Departure,
                StopName = stopId.ToString(),
            }, cancellationToken);
            return Content(stop.Display());
        }
        catch (WebException ex)
        {
            var json = JsonSerializer.Serialize(ex);
            return NotFound(json);
        }
    }

    [HttpGet("{stopId:int}/json")]
    public async Task<IActionResult> GetJsonSourceById(int stopId, CancellationToken cancellationToken)
    {
        try
        {
            var request = new StopPassagesRequest
            {
                PassageMode = Mode.Departure,
                StopName = stopId.ToString(),
            };
            var baseUri = request.GetRequestPath(R4Uri.Create(_ttssApi.BaseUri));
            var uri = request.AppendToUri(baseUri);
            using var httpClient = new HttpClient();
            var jsonSource = await httpClient.GetStringAsync(uri, cancellationToken);
            return Content(jsonSource, "application/json");
        }
        catch (WebException ex)
        {
            var json = JsonSerializer.Serialize(ex);
            return NotFound(json);
        }
    }
}

file static class TtssExtensions
{
    public static string Display(this StopPassagesResponse response)
    {
        var infoSb = new StringBuilder();
        infoSb.Append($"Haltestellenname: {response.StopName}, Id: {response.StopShortName}{Environment.NewLine}");
        if (response.Alerts.Count > 0)
        {
            infoSb.Append("Hinweise:");
            foreach (var alert in response.Alerts)
            {
                infoSb.Append($"  - {alert.Message}{Environment.NewLine}");
            }
        }

        infoSb.Append($"Erste Zeit: {response.FirstPassageTime}, letzte Zeit: {response.LastPassageTime}{Environment.NewLine}");
        if (response.Directions.Count > 0)
        {
            infoSb.Append("Ziele (Directions):");
            for (var i = 0; i < response.Directions.Count; i++)
            {
                infoSb.Append($"  - {response.Directions[i]}{Environment.NewLine}");
            }
        }

        infoSb.Append($"Es fahren:{Environment.NewLine}");
        for (var i = 0; i < response.Actual.Count; i++)
        {
            infoSb.Append($"  {i + 1}. {response.Actual[i].Display(response.Routes)}{Environment.NewLine}");
        }

        return infoSb.ToString();
    }
    
    public static string Display(this Passage passage, List<RouteWithType> routes)
    {
        var route = routes.First(route => route.Id == passage.RouteId);
        return
            $"Fahrt der Linie {route.RouteType} {(passage.PatternText is { Length: > 0 } ? passage.PatternText : route.Name)} Richtung {passage.Direction}{(passage.Vias is null or { Count: 0 } ? string.Empty : $" ({string.Join(", ", passage.Vias)})")}, planmäßig um {passage.PlannedTime}, erwartet um {passage.ActualTime} (in {passage.ActualRelativeTime} Sekunden){(passage.VehicleId is null ? string.Empty : $" mit Fahrzeug-Id {passage.VehicleId}")}.";
    }
}
