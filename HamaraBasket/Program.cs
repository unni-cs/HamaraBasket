using HamaraBasket.Models;
using System;
using System.Collections.Generic;

namespace HamaraBasket
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<IProduct>
            {
                new Product{ Name="Product1", ProductType= Shared.ProductType.General, Quality = 10, SellBy = 10},
                new Product{ Name="Product2", ProductType= Shared.ProductType.General, Quality = 0, SellBy = 10},
                new Product{ Name="Product3", ProductType= Shared.ProductType.General, Quality = 2, SellBy = 0},
                new Product{ Name="Product4", ProductType= Shared.ProductType.IndianWine, Quality = 10, SellBy = 10},
                new Product{ Name="Product5", ProductType= Shared.ProductType.IndianWine, Quality = 50, SellBy = 10},
                new Product{ Name="Legandary", ProductType= Shared.ProductType.Legendary, Quality = 10, SellBy = 10},
                new Product{ Name="Movie Ticket1", ProductType= Shared.ProductType.MovieTicket, Quality = 10, SellBy = 11},
                new Product{ Name="Movie Ticket2", ProductType= Shared.ProductType.MovieTicket, Quality = 10, SellBy = 7},
                new Product{ Name="Movie Ticket3", ProductType= Shared.ProductType.MovieTicket, Quality = 10, SellBy = 3},
                new Product{ Name="Movie Ticket4", ProductType= Shared.ProductType.MovieTicket, Quality = 10, SellBy = 0}
            };

            Console.WriteLine("Before updating products.....");
            Console.WriteLine("-------------------------------------------------");
            foreach (var product in products)
            {
                Console.WriteLine("Product: "+ product.Name+" | Type: "+ product.ProductType+" | Quality: "+ product.Quality+" | SellBy: "+ product.SellBy);
            }

            Console.WriteLine("Updating products.......");
            Console.WriteLine("-------------------------------------------------");
            RuleEngine.Run(products);
            foreach (var product in products)
            {
                Console.WriteLine("Product: " + product.Name + " | Type: " + product.ProductType + " | Quality: " + product.Quality + " | SellBy: " + product.SellBy);
            }

            Console.WriteLine("Press any key to exist!");
            Console.ReadKey();
        }        
    }
}
