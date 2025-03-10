using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pc_Express.Models;

namespace Pc_Express.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
