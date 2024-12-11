using System;
using Microsoft.AspNetCore.Mvc;

namespace uppfinnaren_1_0_gytu24nn.Controllers;

public class ArtworkController : Controller
{
    public IActionResult Index()
    {   
        ViewBag.Title = "Konstverk";
        return View();
    }   
}
