using System;

namespace uppfinnaren_1_0_gytu24nn.Models;

public class ArtworkItems
{
    //här skapas objekten för alster listan och de skapas för sig själv för att man just ska kunna använda de på andra ställen och då ha en
    //låg koppling till databasen. 
    public int ArtworkItemsId {get; set;}

    public int ArtworkCategoryListId {get; set;}

    public string CreatedArtwork {get; set;} = string.Empty;

    public string ArtworkDescription {get; set;} = string.Empty;

    public int YearCreated {get; set;}

    public string ArtworkName {get; set;} = string.Empty;
}
