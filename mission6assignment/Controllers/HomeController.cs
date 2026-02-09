using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mission6assignment.Models;

namespace mission6assignment.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View("About");
    }
    
    public IActionResult AddMovie()
    {
        return View("AddMovie");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}