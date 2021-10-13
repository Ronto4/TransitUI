using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransitWeb.Models;

namespace TransitWeb.Controllers;

public class TransitController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        ViewData.Model = null;
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(TransitStopIdFormModel model)
    {
        await model.CheckIfStopExists();
        ViewData.Model = model;
        return View();
    }
}
