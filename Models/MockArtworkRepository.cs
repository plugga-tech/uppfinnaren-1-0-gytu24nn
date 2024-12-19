// using System;
// using System.Security.Cryptography.X509Certificates;

// namespace uppfinnaren_1_0_gytu24nn.Models;

// public class MockArtworkRepository : IArtworkRepository
// {  //detta är en klass som implementerar interfacet. Här lägger du självs implementationen tex hur konsverken hämtas. 
//    //här använder jag en hårdkodad lista med konstverk för simulera verklig data från en databas.

//    //En mock-implementation av IArtworkRepository. Listan innehåller åtta konsverk med olika egenskaper.
//    public IEnumerable<Artwork> AllArtwork => 
//    new List<Artwork>
//    {
//         new Artwork {ArtworkId = 1, ArtworkName = "Bröllop", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "En tavla om två personer som precis gift sig, målat på ipad.", YearCreated = 2022 },
//         new Artwork {ArtworkId = 2, ArtworkName = "Gamer girl", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "En tjej som sitter och spelar vid datorn, målat på ipad.", YearCreated = 2022},
//         new Artwork {ArtworkId = 3, ArtworkName = "Stad i ljus", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "En stad i natten som lyses upp av lamporna i staden, målat med pastell pennor", YearCreated = 2021},
//         new Artwork {ArtworkId = 4, ArtworkName = "Vänskap", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "En gips av gjutning på två händer som symboliserar vänskap. Skapat i gips", YearCreated = 2021},
//         new Artwork {ArtworkId = 5, ArtworkName = "Berg", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "Skulptur skapat i gips", YearCreated = 2021},
//         new Artwork {ArtworkId = 6, ArtworkName = "Parrots in the jungle", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "Tavla på två pappergojor i djungeln. Målat i gosch.", YearCreated = 2020},
//         new Artwork {ArtworkId = 7, ArtworkName = "Rainbow girl", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "tavla på en kvinna i regnbågs smink, målat i pastel pennor", YearCreated = 2020},
//         new Artwork {ArtworkId = 8, ArtworkName = "Årstider", CreatedArtwork = "Tuva Gyllensten", ArtworkDescription = "Träd i två årstider, målat med akvarell.", YearCreated = 2020}
//    };    

//    //Använder LINQ-metoden first ord defualt för att hitta ett konstverk i listan med ett specifikt ID. Om inget matchande id hittas
//    //returneras null.
//    public Artwork? GetArtworkById(int artworkId) => AllArtwork.FirstOrDefault(a => a.ArtworkId == artworkId);
// }
