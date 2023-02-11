using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MAEWebApp.Models;
using MAEWebApp.Models.ViewModels;

namespace MAEWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<SubjectViewModel> subjects = new List<SubjectViewModel>();

        subjects.Add(new SubjectViewModel
        { 
            Name = "Padrões de Projetos", 
            TotalClasses = 90, 
            TotalAbstences =  2,
            Percent = 98.15m
        });
        subjects.Add(new SubjectViewModel
        { 
            Name = "Padrões de Projetos", 
            TotalClasses = 90, 
            TotalAbstences =  2,
            Percent = 98.15m
        });

        return View(subjects);
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
