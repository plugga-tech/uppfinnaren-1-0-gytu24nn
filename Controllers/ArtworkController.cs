using System;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_gytu24nn.Models;

namespace uppfinnaren_1_0_gytu24nn.Controllers;

public class ArtworkController : Controller
{
    private readonly AppDbContext _context;

    public ArtworkController(AppDbContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        return View(_context.artworkCategoryLists.ToList());
    }

    public IActionResult info(int id)
    {
        var category = _context.artworkCategoryLists.FirstOrDefault(c => c.ArtworkCategoryListId == id);

        if(category == null)
        {
            return NotFound();
        }

        ViewBag.CategoryName = category.CategoryName;

        var itemsInCategory = _context.artworkItems.Where(item => item.ArtworkCategoryListId == id).ToList();

        return View(itemsInCategory);

    }


    // private readonly IArtworkRepository _artworkRepository;

    // public ArtworkController(IArtworkRepository artworkRepository)
    // {
    //     _artworkRepository = artworkRepository;
    // }

    // public IActionResult Index()
    // {   
    //     return View(_artworkRepository.AllArtwork);
    // }

    // public IActionResult Info(int id)
    // {   
        
    //     var artwork = _artworkRepository.GetArtworkById(id);
    //     return View(artwork);
    // }   
}
