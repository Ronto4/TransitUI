using RealTimeDataCrawler.Vip;
using RealTimeModels.Vip;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using TransitWeb.Models;

namespace TransitWeb.Controllers.WebApi;

[Route("api/[controller]")]
[ApiController]
public class TransitController : Controller
{
    [HttpGet("vip/{id}")]
    public async Task<IActionResult> CheckIfStationExists(int id)
    {
        try
        {
            await Crawler.GetFromWeb(id);
            return Ok();
        }
        catch
        {
            return NotFound();
        }
    }
    [HttpGet("vip/{id}/dotmatrix")]
    public async Task<IActionResult> GetDotMatrixById(int id)
    {
        try
        {
            var station = await Crawler.GetFromWeb(id);
            var stream = await RealTimeToDotMatrix.Vip.RealTimeToDotMatrix.Convert(station);
            // FileStream gif = System.IO.File.OpenRead(gifPath);
            return File(stream, "image/gif");
            // return Content(stream);
            // return station.ToString();
        }
        catch (System.Net.WebException ex)
        {
            ApiErrorViewModel error = new(ex);
            var json = JsonSerializer.Serialize(error);
            return NotFound(json);
        }
    }
    [HttpGet("vip/{id}/info")]
    public async Task<IActionResult> GetInfoById(int id)
    {
        try
        {
            Station station = await Crawler.GetFromWeb(id);
            return Content(station.ToString());
        }
        catch (System.Net.WebException ex)
        {
            ApiErrorViewModel error = new(ex);
            var json = JsonSerializer.Serialize(error);
            return NotFound(json);
        }
    }
    [HttpGet("vip/{id}/json")]
    public async Task<IActionResult> GetJsonSourceById(int id)
    {
        try
        {
            var jsonSource = await Crawler.GetJsonSource(id);
            return Content(jsonSource, "application/json");
        }
        catch (System.Net.WebException ex)
        {
            ApiErrorViewModel error = new(ex);
            var json = JsonSerializer.Serialize(error);
            return NotFound(json);
        }
    }
}
