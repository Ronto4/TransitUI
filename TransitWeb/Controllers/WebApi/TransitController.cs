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
    public IActionResult CheckIfStationExists(int id)
    {
        try
        {
            Crawler.GetFromWeb(id);
            return Ok();
        }
        catch
        {
            return NotFound();
        }
    }
    [HttpGet("vip/{id}/dotmatrix")]
    public IActionResult GetDotMatrixById(int id)
    {
        try
        {
            Station station = Crawler.GetFromWeb(id);
            Stream stream = RealTimeToDotMatrix.Vip.RealTimeToDotMatrix.Convert(station);
            // FileStream gif = System.IO.File.OpenRead(gifPath);
            return File(stream, "image/gif");
            // return Content(stream);
            // return station.ToString();
        }
        catch (System.Net.WebException ex)
        {
            ApiErrorViewModel error = new(ex);
            string json = JsonSerializer.Serialize(error);
            return NotFound(json);
        }
    }
    [HttpGet("vip/{id}/info")]
    public IActionResult GetInfoById(int id)
    {
        try
        {
            Station station = Crawler.GetFromWeb(id);
            return Content(station.ToString());
        }
        catch (System.Net.WebException ex)
        {
            ApiErrorViewModel error = new ApiErrorViewModel(ex);
            string json = JsonSerializer.Serialize(error);
            return NotFound(json);
        }
    }
    [HttpGet("vip/{id}/json")]
    public IActionResult GetJsonSourceById(int id)
    {
        try
        {
            string jsonSource = Crawler.GetJsonSource(id);
            return Content(jsonSource, "application/json");
        }
        catch (System.Net.WebException ex)
        {
            ApiErrorViewModel error = new ApiErrorViewModel(ex);
            string json = JsonSerializer.Serialize(error);
            return NotFound(json);
        }
    }
}
