using System;
using System.Linq;

namespace LINK1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product[] products = new Product[]
            {
                new Product { Description = "chair", Price = 200.0f, Manufacturer = "Ashley" },
                new Product { Description = "hammer", Price = 10.0f, Manufacturer = "Dewalt" },
                new Product { Description = "box", Price = 5.0f, Manufacturer = "Able" },
                new Product { Description = "saw", Price = 150.0f, Manufacturer = "Dewalt" },
                new Product { Description = "table", Price = 400.0f, Manufacturer = "Ashley" }
            };
            Console.WriteLine();
            Console.WriteLine($"{"Description",-15}{"Price",-15}{"Manufacturer",-15}");
            Console.WriteLine("------------------------------------------");
            foreach (Product p in products)
            {
                Console.WriteLine($"{p.Description,-15}{p.Price,-10}{p.Manufacturer,-15}");
            }
            var aManufacturers = (from p in products where p.Manufacturer.StartsWith("A", StringComparison.OrdinalIgnoreCase) select p.Manufacturer).Distinct();
            Console.WriteLine();
            Console.WriteLine("Manufacturers that begin with 'A':");
            Console.WriteLine("----------------------------------");
            foreach (string m in aManufacturers)
            {
                Console.WriteLine(m);
            }
            var aManufacturerDescriptions = from p in products where p.Manufacturer.StartsWith("A", StringComparison.OrdinalIgnoreCase) select p.Description;
            Console.WriteLine();
            Console.WriteLine("Item Descriptions of Manufacturers that begin with 'A':");
            Console.WriteLine("-------------------------------------------------------");
            foreach (string d in aManufacturerDescriptions)
            {
                Console.WriteLine(d);
            }
            var aManufacturerProducts = from p in products where p.Manufacturer.StartsWith("A", StringComparison.OrdinalIgnoreCase) select p;
            Console.WriteLine();
            Console.WriteLine("Product Information of Manufacturers that begin with 'A':");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"{"Description",-15}{"Price",-15}{"Manufacturer",-15}");
            foreach (var p in aManufacturerProducts)
            {
                Console.WriteLine(p.ToString());
            }
            var underTwenty = from p in products where p.Price < 20 select p;
            Console.WriteLine();
            Console.WriteLine("Products with price less than $20:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{"Description",-15}{"Price",-15}{"Manufacturer",-15}");
            foreach (var p in underTwenty)
            {
                Console.WriteLine(p.ToString());
            }
            var midRange = from p in products where p.Price >= 100 && p.Price <= 300 select p;
            Console.WriteLine();
            Console.WriteLine("Products priced between $100 and $300:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"{"Description",-15}{"Price",-15}{"Manufacturer",-15}");
            foreach (var p in midRange)
            {
                Console.WriteLine(p.ToString());
            }
            var descendingPrice = from p in products orderby p.Price descending select p;
            Console.WriteLine();
            Console.WriteLine("Products (Descending by Price):");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"{"Description",-15}{"Price",-15}{"Manufacturer",-15}");
            foreach (var p in descendingPrice)
            {
                Console.WriteLine(p.ToString());
            }
            var groupedProducts = from p in products orderby p.Manufacturer group p by p.Manufacturer into g select g;
            Console.WriteLine();
            Console.WriteLine("Products grouped by manufacturer:");
            Console.WriteLine("----------------------------------");
            foreach (var group in groupedProducts)
            {
                Console.WriteLine(group.Key);
                foreach (var p in group)
                {
                    Console.WriteLine($"\t{p.Description}\t{p.Price}");
                }
            }
            string awesome = "hello guys i am so cool and fantastic";
            Console.WriteLine(MyExtensions.removeVowels(awesome));

            Product product = new Product { Description = "napkins", Price = 1.50f, Manufacturer = "Mr. Nap" };
            Product cheap = product.markDown(.10f);
            Console.WriteLine(cheap);

            int[] num = { 5, 3, 4, 1, 7 };
            DelegateTest.processArray(num, x => x + 1);
            Console.WriteLine("After lambda add one: " + string.Join(" ", num));

            DelegateTest.processArray(num, x => x * 2);
            Console.WriteLine("After lambda doubling: " + string.Join(" ", num));

            Console.WriteLine();
            Console.WriteLine("=== Sorting Products Using Delegates ===");

            object[] productObjects = products.Cast<object>().ToArray();
            SortTest.MySort(productObjects, SortTest.NameCompare);
            Console.WriteLine("Products Sorted by Name:");
            Console.WriteLine($"{"Description",-15}{"Price",-15}{"Manufacturer",-15}");
            foreach (Product p in productObjects)
            {
                Console.WriteLine(p.ToString());
            }
            SortTest.MySort(productObjects, SortTest.PriceCompare);
            Console.WriteLine("Products Sorted by Price:");
            Console.WriteLine($"{"Description",-15}{"Price",-15}{"Manufacturer",-15}");
            foreach (Product p in productObjects)
            {
                Console.WriteLine(p.ToString());
            }


            int[] num2 = { 5, 3, 9, 1, 7 };
            var maxNum = num2.Max(num2 => num2);
            Console.WriteLine("The max number in the array is " + maxNum);

            var maxPrice = products.Max(product => product.Price);
            Console.WriteLine("The max price from my products is " + maxPrice);

            int numberOver100 = products.Count(product => product.Price > 100);
            Console.WriteLine(" I have " + numberOver100 + " products priced over $100");

            var firstDewalt = products.First(product => product.Manufacturer == "Dewalt");
            Console.WriteLine(firstDewalt);

            var expensiveProducts = products.ExpensiveItems();

            Console.WriteLine("Products more expensive than the average:");
            foreach (var p in expensiveProducts)
            {
                Console.WriteLine($"{p.Description,-15}{p.Price,-10}{p.Manufacturer,-15}");
            }

        }
        static int addOne(int hello)
        {
            return hello + 1;
        }

        static int doubleIt(int goodbye)
        {
            return goodbye * 2;
        }
        

        

    }

    public class Product
    {
        public string Description { get; set; }
        public float Price { get; set; }
        public string Manufacturer { get; set; }

        public override string ToString()
        {
            return $"{Description,-15}{Price,-15}{Manufacturer,-15}";
        }


    }
    
    public delegate int MyCompare(object x, object y);

public class SortTest
{

    public static void MySort(object[] arr, MyCompare compare)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (compare(arr[j], arr[j + 1]) > 0)
                {
                    object temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }


    public static int NameCompare(object x, object y)
    {
        Product p1 = (Product)x;
        Product p2 = (Product)y;
        return string.Compare(p1.Description, p2.Description);
    }


    public static int PriceCompare(object x, object y)
    {
        Product p1 = (Product)x;
        Product p2 = (Product)y;
        return p1.Price.CompareTo(p2.Price);
    }
}


    
}
