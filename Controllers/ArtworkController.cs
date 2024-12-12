using System;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_gytu24nn.Models;

namespace uppfinnaren_1_0_gytu24nn.Controllers;

public class ArtworkController : Controller
{

    private readonly IArtworkRepository _artworkRepository;

    public ArtworkController(IArtworkRepository artworkRepository)
    {
        _artworkRepository = artworkRepository;
    }

    public IActionResult Index()
    {   
        ViewBag.Title = "Konstverk";
        return View(_artworkRepository.AllArtwork);
    }

    public IActionResult Info(int id)
    {   
        ViewBag.Title = "";
        var artwork = _artworkRepository.GetArtworkById(id);
        return View(artwork);
    }   
}
