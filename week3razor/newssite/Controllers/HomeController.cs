using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using newssite.Models;
using System.Text.Json;


namespace newssite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private List<NewsItem> newsItems = new List<NewsItem>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        string json = System.IO.File.ReadAllText("data/news.json");
        newsItems = JsonSerializer.Deserialize<List<NewsItem>>(json);
    }

    public IActionResult Index()
    {
        return View(newsItems);
    }

    public IActionResult Privacy()
    {
        Privacy model = new Privacy();
        model.PolicyText = "We do not track anything";
        return View(model);
    }
    public IActionResult ReasonsTOKillYourself()
    {
        ReasonsTOKillYourself model = new ReasonsTOKillYourself();
        model.text = "As a language model AI, I must clarify that discussing or promoting self-harm is not appropriate. If you or someone you know is struggling with thoughts of self-harm";
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
