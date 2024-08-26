using System.Net;
using RealTimeDataCrawler.Vip;
using System.Text.Json;
using DotMatrixDisplay;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp.PixelFormats;

namespace TransitApi.Controllers;

[Route("api/vip")]
[ApiController]
public class VipController : ControllerBase
{
    private static Rgb24 BackgroundColor { get; } = new(0x23, 0x29, 0x23); 
    private static Rgb24 InactivePixelColor { get; } = new(0x23, 0x2d, 0x23);
    private static Rgb24 ActivePixelColor { get; } = new(0xd1, 0x5a, 0x1a);

    [HttpGet("{id:int}")]
    public async Task<IActionResult> CheckIfStationExists(int id, CancellationToken cancellationToken)
    {
        try
        {
            await Crawler.GetFromWeb(id, cancellationToken);
            return Ok();
        }
        catch (WebException)
        {
            return NotFound();
        }
    }

    [Obsolete("The functionality of generating GIFs has been removed.")]
    [HttpGet("{id:int}/dotmatrix")]
    public IActionResult GetDotMatrixById()
    {
        return RedirectPermanentPreserveMethod($"dotmatrix/1");
    }

    [HttpGet("{id:int}/dotmatrix/info")]
    public async Task<IActionResult> GetDotMatrixInfo(int id, CancellationToken cancellationToken)
    {
        try
        {
            var station = await Crawler.GetFromWeb(id, cancellationToken);
            var (pages, _) = await RealTimeToDotMatrix.Vip.RealTimeToDotMatrix.GetPages(station, cancellationToken);
            return Ok(pages.Count);
        }
        catch (HttpRequestException ex)
        {
            var json = JsonSerializer.Serialize(ex.ToString());
            return NotFound(json);
        }
    }

    [HttpGet("{id:int}/dotmatrix/{page:int}")]
    public async Task<IActionResult> GetDotMatrixPageById(int id, int page, CancellationToken cancellationToken)
    {
        try
        {
            var station = await Crawler.GetFromWeb(id, cancellationToken);
            var (pages, dimensions) =
                await RealTimeToDotMatrix.Vip.RealTimeToDotMatrix.GetPages(station, cancellationToken);
            if (page <= 0 || pages.Count < page)
            {
                return NotFound($$"""
                {
                    "message": "Page {{page}} is out of bounds for station {{station.StationName}} with {{pages.Count}} page(s)."
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

    [HttpGet("{id:int}/info")]
    public async Task<IActionResult> GetInfoById(int id, CancellationToken cancellationToken)
    {
        try
        {
            var station = await Crawler.GetFromWeb(id, cancellationToken);
            return Content(station.ToString());
        }
        catch (WebException ex)
        {
            var json = JsonSerializer.Serialize(ex);
            return NotFound(json);
        }
    }

    [HttpGet("{id:int}/json")]
    public async Task<IActionResult> GetJsonSourceById(int id, CancellationToken cancellationToken)
    {
        try
        {
            var jsonSource = await Crawler.GetJsonSource(id, cancellationToken);
            return Content(jsonSource, "application/json");
        }
        catch (WebException ex)
        {
            var json = JsonSerializer.Serialize(ex);
            return NotFound(json);
        }
    }
}
