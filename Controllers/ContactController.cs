using System;
using Microsoft.AspNetCore.Mvc;

namespace uppfinnaren_1_0_gytu24nn.Controllers;

public class ContactController : Controller
{
    //Här är vyn för kontakt sidan.
    public IActionResult Index()
    {
        return View();
    }
}
