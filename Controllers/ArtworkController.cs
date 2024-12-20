using System;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_gytu24nn.Models;

namespace uppfinnaren_1_0_gytu24nn.Controllers;

public class ArtworkController : Controller
{
    //här skapas de olika views för kategori sidan och här filtreras även alsterna in i rätt kategori med where(). Även databasen hämtas här. 
    
    //här hämtas databasen
    private readonly AppDbContext _context;

    //här används den i konstruktor 
    public ArtworkController(AppDbContext context)
    {
        _context = context;
    }

    //här är skapas vyn kategori listan och data från databasen för den listan hämtas här och görs till en lista
    public ActionResult Index()
    {
        return View(_context.artworkCategoryLists.ToList());
    }

    //Här är den andra vyn och den är för alster. Denna vy använder då where() för att filtrera in rätt alster i rätt kategori
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
}
