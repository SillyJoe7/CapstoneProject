

public class LineReader
{
    private string fileName;
    public LineReader(string d)
    {
        fileName = d;
    }
    public void Display()
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

        using StreamReader reader = new StreamReader(filePath);
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }

    public void DisplayInt(int limit)
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

        using StreamReader reader = new StreamReader(filePath);
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            if (line.Length > limit)
                Console.WriteLine(line.Substring(0, limit));
            else
                Console.WriteLine(line);
        }
    }
    
        public void DisplayRev()
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        List<string> lines = new List<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }
        for (int i = lines.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(lines[i]);
        }
    }



    public static void Copy(string orig, string copy)
    {
        string origPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, orig);
        string copyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, copy);


        using (StreamReader reader = new StreamReader(origPath))
        using (StreamWriter writer = new StreamWriter(copyPath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line);
            }
        }
        Console.WriteLine("Copied!");


    }

}