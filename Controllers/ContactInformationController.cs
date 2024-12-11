using System;
using Microsoft.AspNetCore.Mvc;

namespace uppfinnaren_1_0_gytu24nn.Controllers;

public class ContactInformationController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Title = "Contact";
        return View();
    }
}
