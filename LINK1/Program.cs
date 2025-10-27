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

            Console.WriteLine($"{"Description",-15}{"Price",-15}{"Manufacturer",-15}");
            Console.WriteLine("------------------------------------------");

            foreach (Product p in products)
            {
                Console.WriteLine($"{p.Description,-15}{p.Price,-10}{p.Manufacturer,-15}");
            }

           

            
            Console.WriteLine("Manufacturers that begin with 'A':");
            Console.WriteLine("----------------------------------");

            foreach (string m in products
            .Where(p => p.Manufacturer
            .StartsWith("A", StringComparison.OrdinalIgnoreCase))
            .Select(p => p.Manufacturer)
            .Distinct())
            {
                Console.WriteLine(m);
            }

            var aManufacturersDescription = products
           .Where(p => p.Manufacturer
           .StartsWith("A", StringComparison.OrdinalIgnoreCase))
           .Select(p => p.Description)
           .Distinct();

            Console.WriteLine();
            Console.WriteLine("Item Descriptions of Manufacturers that begin with 'A':");
            Console.WriteLine("-------------------------------------------------------");

            foreach (string m in aManufacturersDescription)
            {
                Console.WriteLine(m);
            }

            var aManufacturersInformation = products
            .Where(p => p.Manufacturer
            .StartsWith("A", StringComparison.OrdinalIgnoreCase))
            .Select(p => p.ToString())
            .Distinct();

            Console.WriteLine();
            Console.WriteLine("Product Information of Manufacturers that begin with 'A':");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"{"Description",-15}{"Price",-15}{"Manufacturer",-15}");

            foreach (string m in aManufacturersInformation)
            {
                Console.WriteLine(m);
            }

            var betweenHundredAndThreehundred = products
            .Where(p => p.Price < 300 && p.Price > 100)
            .Select(p => p.ToString());

            Console.WriteLine();
            Console.WriteLine("Product Information With a price Between $100 and $300");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"{"Description",-15}{"Price",-15}{"Manufacturer",-15}");

            foreach (string m in betweenHundredAndThreehundred)
            {
                Console.WriteLine(m);
            }

            var lessThanTwenty = products
            .Where(p => p.Price < 20)
            .Select(p => p.ToString());

            Console.WriteLine();
            Console.WriteLine("Product Information With a price less than $20:");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"{"Description",-15}{"Price",-15}{"Manufacturer",-15}");

            foreach (string m in lessThanTwenty)
            {
                Console.WriteLine(m);
            }

            var greatestToLeast = products
                .OrderByDescending(p => p.Price)
                .Select(p => p.ToString());

            Console.WriteLine();
            Console.WriteLine("Product Information Descending by Price");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"{"Description",-15}{"Price",-15}{"Manufacturer",-15}");

            foreach (string m in greatestToLeast)
            {
                Console.WriteLine(m);
            }
            
            var grouped = products
                .GroupBy(p => p.Manufacturer)
                .OrderBy(g => g.Key);
            Console.WriteLine();
            Console.WriteLine("Product Information grouped by manufacturer");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var group in grouped)
            {
                Console.WriteLine(group.Key);

                foreach (var product in group)
                {
                    Console.WriteLine($"{product.Description}, {product.Price}");
                }

                Console.WriteLine();
            }
            
        }
    }

    class Product
    {
        public string Description { get; set; }
        public float Price { get; set; }
        public string Manufacturer { get; set; }

        public override string ToString()
        {
            return $"{Description,-15}{Price,-15}{Manufacturer,-15}";
        }
    }
}
