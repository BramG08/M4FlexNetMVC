using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using newssite.Models;


namespace newssite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        NewsItem item = new NewsItem()
        {
            Title = "Mijn eeerste model",
            Content = "Was niet zo moeilijk om te maken",
            ImageUrl = "img/newsitem.PNG"
        };
        return View(item);
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
