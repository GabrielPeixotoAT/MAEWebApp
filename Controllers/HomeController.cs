using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MAEWebApp.Models;
using MAEWebApp.Models.ViewModels;
using MAEWebApp.Services;
using MAEWebApp.Services.Interfaces;

namespace MAEWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    //private SubjectAbstencesService subjectAbstencesService;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        SubjectAbstencesService subjectAbstencesService = new SubjectAbstencesService();

        HomeModels homeModels = new HomeModels();
        
        homeModels.Subjects = subjectAbstencesService.GetAll();

        return View(homeModels);
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
