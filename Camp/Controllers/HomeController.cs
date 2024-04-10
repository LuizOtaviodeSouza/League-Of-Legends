using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Camp.Models;


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
        List<Tipo> tipos = [];
        using (StreamReader leitor = new("data//tipo.json"))
    {
     string dados = leitor.ReadToEnd();
     tipos = JsonSerializer.Deserialize<List<Tipo>>(dados);
    
    }
        ViewData["Funcao"] = tipos;
        return View(campeoes);
    }
   
    public IActionResult Details(int id)
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
