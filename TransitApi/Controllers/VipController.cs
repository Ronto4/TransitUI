using System.Net;
using RealTimeDataCrawler.Vip;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace TransitApi.Controllers;

[Route("api/vip")]
[ApiController]
public class VipController : ControllerBase
{
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

    [HttpGet("{id:int}/dotmatrix")]
    public async Task<IActionResult> GetDotMatrixById(int id, CancellationToken cancellationToken)
    {
        try
        {
            var station = await Crawler.GetFromWeb(id, cancellationToken);
            var stream = await RealTimeToDotMatrix.Vip.RealTimeToDotMatrix.Convert(station, cancellationToken);
            return File(stream, "image/gif");
        }
        catch (WebException ex)
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
