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
    public IActionResult CheckIfStationExists(int id)
    {
        try
        {
            Crawler.GetFromWeb(id);
            return Ok();
        }
        catch (WebException)
        {
            return NotFound();
        }
    }
    [HttpGet("{id:int}/dotmatrix")]
    public IActionResult GetDotMatrixById(int id)
    {
        try
        {
            var station = Crawler.GetFromWeb(id);
            var stream = RealTimeToDotMatrix.Vip.RealTimeToDotMatrix.Convert(station);
            return File(stream, "image/gif");
        }
        catch (WebException ex)
        {
            var json = JsonSerializer.Serialize(ex.ToString());
            return NotFound(json);
        }
    }
    [HttpGet("{id:int}/info")]
    public IActionResult GetInfoById(int id)
    {
        try
        {
            var station = Crawler.GetFromWeb(id);
            return Content(station.ToString());
        }
        catch (WebException ex)
        {
            var json = JsonSerializer.Serialize(ex);
            return NotFound(json);
        }
    }
    [HttpGet("{id:int}/json")]
    public IActionResult GetJsonSourceById(int id)
    {
        try
        {
            var jsonSource = Crawler.GetJsonSource(id);
            return Content(jsonSource, "application/json");
        }
        catch (WebException ex)
        {
            var json = JsonSerializer.Serialize(ex);
            return NotFound(json);
        }
    }
}
