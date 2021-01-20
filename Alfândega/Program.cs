using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alfândega.Entities;

namespace Alfândega
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number productos:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i=1; i<=n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string Name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine());
                

                if(ch == 'c')
                {
                    list.Add(new Product(Name, price));
                    

                }
                else if(ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/AAAA): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(Name, price, date));
                    
                }
                else
                {
                    Console.Write("Custome Fee:");
                    double customeFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(Name, price, customeFee));
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAGS DE PRECO:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
