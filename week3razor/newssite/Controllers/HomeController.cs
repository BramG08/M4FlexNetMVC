using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using newssite.Models;


namespace newssite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private List<NewsItem> newsItems = new List<NewsItem>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        newsItems.Add(new NewsItem()
        {
            Title = "Dit bericht is nieuw",
            Content = "Lijsjt ook met nieuwsitems",
            ImageUrl = "img/newsitem.PNG"
        });

        newsItems.Add(new NewsItem()
        {
            Title = "Minn eerste model",
            Content = "Was niet zo moeilijk om te maken",
            ImageUrl = "img/newsitem.PNG"
        });
    }

    public IActionResult Index()
    {
        return View(newsItems);
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
