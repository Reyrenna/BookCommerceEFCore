using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookCommerceEFCore.ViewModels;
using BookCommerceEFCore.Data;

namespace BookCommerceEFCore.Controllers;

public class HomeController : Controller
{
    //private readonly BookCommerceEFCoreDbContext _context;

    //public HomeController(BookCommerceEFCoreDbContext context)
    //{
    //    _context = context;
    //}

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
