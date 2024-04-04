using System.Diagnostics;
using System.Text.Json;
using Camp.Models;
using Microsoft.AspNetCore.Mvc;


namespace Camp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Herois> campeoes = [];
        using (StreamReader leior = new("Data//Oque.json")){
            string dados = leior.ReadToEnd();
            campeoes = JsonSerializer.Deserialize<List<Herois>>(dados);
        }
        return View(campeoes);
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
