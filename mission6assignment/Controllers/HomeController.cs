using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mission6assignment.Models;

namespace mission6assignment.Controllers;

public class HomeController : Controller
{
    private MovieApplicationContext _context;
    
    public HomeController(MovieApplicationContext temp)
    {
        _context = temp;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View("About");
    }
    [HttpGet]

    public IActionResult AddMovie()
    {
        return View("AddMovie");
    }

    [HttpPost]
    [HttpPost]
    public IActionResult AddMovie(Movie response)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            // Returning 'new Movie()' makes all the text boxes empty again
            return View("AddMovie", new Movie()); 
        }
    
        return View(response);
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}