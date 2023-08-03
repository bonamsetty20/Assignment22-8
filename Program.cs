using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Source source = new Source()
            {
                Id = 1,
                Name = "Oneplus",
                Product = "CPH"

            };

            Destination destination = new Destination()
            {
                Id = 2,
                Name = "",
                Product = "",
                Price = 45000
            };

            Console.WriteLine("Source");
            Console.WriteLine($"ID: {source.Id} Name: {source.Name} Product: {source.Product}");

            Console.WriteLine("\nDestination");
            Console.WriteLine($"ID: {destination.Id} Name: {destination.Name} Product: {destination.Product} Price: {destination.Price}");

            DynamicPropertyMapping mapping = new DynamicPropertyMapping();
            mapping.MapProperties(source, destination);
            Console.WriteLine("\nDestination After mapping");
            Console.WriteLine($"ID: {destination.Id} Name: {destination.Name} Product: {destination.Product} Price: {destination.Price}");

            Console.ReadKey();

        }
    }
}
