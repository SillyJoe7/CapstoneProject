using System.Reflection.Metadata;

namespace readingCsvFiles;

class Program
{
    static void Main(string[] args)
    {
        List<string[]> myArray = buildArray();
        try
        {
            readArray(myArray);
        }
        catch
        {
            Console.WriteLine("Something went wrong");
        }
    }


    public static List<string[]> buildArray()
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fart.csv");
        List<string[]> rose = new List<string[]>();

        using StreamReader reader = new StreamReader(filePath);
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            string[] words = line.Split(',');
            rose.Add(words);
        }
        reader.Close();
        return rose;
    }

    public static void readArray(List<string[]> toot)
    {
        foreach (string[] fart in toot)
        {
            foreach (string shart in fart)
            {
                if (shart == "") { Console.Write($"{"<unknown>",-20}"); }
                else { Console.Write($"{shart,-20}"); }
            }
            Console.WriteLine();
        }
    }
}
