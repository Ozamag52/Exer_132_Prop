using System;
using System.Collections.Generic;
using Exerc_132_Prop.Entities.Class;
namespace Exerc_132_Prop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberProducts; i++)
            {
                Console.WriteLine("Product #" + i + " data");
                Console.Write("Common, used or imported (c/u/i)");
                char typeProduct = char.Parse(Console.ReadLine());

                if(typeProduct == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    Product product = new ImportedProduct(name, price, customFee);
                    products.Add(product);

                }
                else if (typeProduct == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Product product = new Product(name, price);
                    products.Add(product);

                }
                else if (typeProduct == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    Product product = new UsedProduct (name, price,manufactureDate);
                    products.Add(product);

                }
                
            
            }
            Console.WriteLine("PRICE TAGS:");

            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
