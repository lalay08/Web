using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using malipangApp.Models;

namespace malipangApp.Controllers;

public class malipangController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult personalinfo()
    {
        return View();
    }

    public IActionResult Education()
    {
        return View();
    }

    public IActionResult DreamJob()
    {
        return View();
    }
}
