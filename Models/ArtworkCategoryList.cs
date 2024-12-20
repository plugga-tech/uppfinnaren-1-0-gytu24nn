using System;

namespace uppfinnaren_1_0_gytu24nn.Models;

public class ArtworkCategoryList
{
    //här skapas objekten för kategori listan och de skapas för sig själv för att man just ska kunna använda de på andra ställen och då ha en
    //låg koppling till databasen. 
    public int ArtworkCategoryListId {get; set; }

    public string CategoryName {get; set;} = string.Empty;
}
