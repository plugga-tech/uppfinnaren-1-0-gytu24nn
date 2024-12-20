using System;
using Microsoft.EntityFrameworkCore;

namespace uppfinnaren_1_0_gytu24nn.Models;

public class AppDbContext : DbContext
{
    //här är databasen där allt som ska sparas skrivs in är som mock data fast man använder de egentligen för att testa data. 
    //Listorna skapas även är som Dbset. 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
    {
        this.Database.EnsureCreated();
    }

    public DbSet<ArtworkItems> artworkItems {get; set;} = null!;
    public DbSet<ArtworkCategoryList> artworkCategoryLists {get; set;} = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Mock för kategorierna
        modelBuilder.Entity<ArtworkCategoryList>().HasData(
            new ArtworkCategoryList {ArtworkCategoryListId = 1, CategoryName = "Keramik"},        
            new ArtworkCategoryList {ArtworkCategoryListId = 2, CategoryName = "Dekoration"},
            new ArtworkCategoryList {ArtworkCategoryListId = 3, CategoryName = "Tavlor"},
            new ArtworkCategoryList {ArtworkCategoryListId = 4, CategoryName = "3D-pärlkonst"}
        );

        //Mock för Alsterna som ska vara i de olika kategorierna 
        modelBuilder.Entity<ArtworkItems>().HasData(
            new ArtworkItems {ArtworkItemsId = 1, ArtworkCategoryListId = 1, ArtworkName = "CakePlate",  CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "Tårtfat gjort i keramik", YearCreated = 2023},
            new ArtworkItems {ArtworkItemsId = 2, ArtworkCategoryListId = 1, ArtworkName = "Fruktskål", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "En skål gjord i keramik.", YearCreated = 2021},
            new ArtworkItems {ArtworkItemsId = 3, ArtworkCategoryListId = 1, ArtworkName = "Blå vas", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "En blå stor vas gjort i keramik sen vid bränning bränts i tekniken Raku bränning.", YearCreated = 2022},
            new ArtworkItems {ArtworkItemsId = 4, ArtworkCategoryListId = 1, ArtworkName = "Treklöver vasen", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "En mindre ljus blå vas gjord i keramik", YearCreated = 2021},

            new ArtworkItems {ArtworkItemsId = 5, ArtworkCategoryListId = 2, ArtworkName = "Dog", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "Ett hundansikte gjort i lera som sen vid bränning bränts i tekniken Raku bränning.", YearCreated = 2022},
            new ArtworkItems {ArtworkItemsId = 6, ArtworkCategoryListId = 2, ArtworkName = "Wheelchair", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "En rullstol gjort i lera sen vid bränning bränts i tekniken Raku bränning.", YearCreated = 2022},
            new ArtworkItems {ArtworkItemsId = 7, ArtworkCategoryListId = 2, ArtworkName = "Vänskap", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "En gips av gjutning på två händer som symboliserar vänskap. Skapat i gips", YearCreated = 2021},
            new ArtworkItems {ArtworkItemsId = 8, ArtworkCategoryListId = 2, ArtworkName = "Berg", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "Skulptur skapat i gips", YearCreated = 2021},
            
            new ArtworkItems {ArtworkItemsId = 9, ArtworkCategoryListId = 3, ArtworkName = "Bröllop", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "En tavla om två personer som precis gift sig, målat på ipad.", YearCreated = 2022},
            new ArtworkItems {ArtworkItemsId = 10, ArtworkCategoryListId = 3, ArtworkName = "Gamer girl", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "En tjej som sitter och spelar vid datorn, målat på ipad.", YearCreated = 2022 },
            new ArtworkItems {ArtworkItemsId = 11, ArtworkCategoryListId = 3, ArtworkName = "Stad i ljus", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "En stad i natten som lyses upp av lamporna i staden, målat med pastell pennor", YearCreated = 2021},
            new ArtworkItems {ArtworkItemsId = 12, ArtworkCategoryListId = 3, ArtworkName = "Parrots in the jungle", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "Tavla på två pappergojor i djungeln. Målat i gosch.", YearCreated = 2020},
            new ArtworkItems {ArtworkItemsId = 13, ArtworkCategoryListId = 3, ArtworkName = "Rainbow girl", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "tavla på en kvinna i regnbågs smink, målat i pastel pennor", YearCreated = 2020},

            new ArtworkItems {ArtworkItemsId = 14, ArtworkCategoryListId = 4, ArtworkName = "Minecraft honeybee", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "3D-figur inspirerad av Minecraft bi gjort i pärlor.", YearCreated = 2024},
            new ArtworkItems {ArtworkItemsId = 15, ArtworkCategoryListId = 4, ArtworkName = "Snorlax", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "3D-figur inspirerad av Snorlax gjort i pärlor.", YearCreated = 2024},
            new ArtworkItems {ArtworkItemsId = 16, ArtworkCategoryListId = 4, ArtworkName = "Minecraft Steve", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "3D-figur inspirerad av Mincraft karaktären Steve gjort i pärlor", YearCreated = 2024},
            new ArtworkItems {ArtworkItemsId = 17, ArtworkCategoryListId = 4, ArtworkName = "Minecraft karaktär med katter", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "3D-figur inspirerad av en youtubers Minecraft karaktär med hans katter gjort i pärlor.", YearCreated = 2024}
        );
    }


}
