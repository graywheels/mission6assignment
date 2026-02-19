using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mission6assignment.Models;
using Microsoft.EntityFrameworkCore;

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
        var movies = _context.Movies.ToList();
        return View(movies);
    }


    public IActionResult About()
    {
        return View();
    }



    // READ - Show all movies
    
    public IActionResult MovieList()
    {
        var movies = _context.Movies
            .Include(m => m.Category)  
            .OrderBy(m => m.Title)
            .ToList();

        return View(movies);
    }



    // CREATEs the stuff
    [HttpGet]
    public IActionResult AddMovie()
    {
        ViewBag.Categories = _context.Categories.ToList();
        return View();
    }

    [HttpPost]
    public IActionResult AddMovie(Movie response)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        return View(response);
    }

    // UPDATE
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var movie = _context.Movies.Find(id);
        return View(movie);
    }

    [HttpPost]
    public IActionResult Edit(Movie updatedMovie)
    {
        if (ModelState.IsValid)
        {
            _context.Update(updatedMovie);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        return View(updatedMovie);
    }

    // DELETE
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var movie = _context.Movies.Find(id);
        return View(movie);
    }

    [HttpPost]
    public IActionResult Delete(Movie movie)
    {
        _context.Movies.Remove(movie);
        _context.SaveChanges();
        return RedirectToAction("MovieList");
    }

    public IActionResult Error()
    {
        return View();
    }
    


}