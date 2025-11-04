
using LINK1;

public static class MyExtensions
{
    public static string removeVowels(this string boomBang)
    {
        string newGoo = "";
        foreach (char charecterOfAwesome in boomBang)
        {
            if (!"aeiouAEIOU".Contains(charecterOfAwesome))
            {
                newGoo += charecterOfAwesome;
            }
        }
        return newGoo;
    }

    public static Product markDown(this Product dinkle, float percent)
    {
        float cheapPrice = dinkle.Price - (dinkle.Price * percent);
        return new Product
        {
            Description = dinkle.Description,
            Manufacturer = dinkle.Manufacturer,
            Price = cheapPrice
        };
    }




        
}