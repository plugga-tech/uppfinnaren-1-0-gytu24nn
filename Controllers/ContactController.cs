using System;
using Microsoft.AspNetCore.Mvc;

namespace uppfinnaren_1_0_gytu24nn.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
