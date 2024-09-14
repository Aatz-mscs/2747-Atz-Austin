using BookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp.DataAccess
{
    internal static class ProductDatabase
    {
        private static string fileName = "Product.txt";
        private static string path = Environment.CurrentDirectory;
        private static string separator = "|";
        public static List<Product> GetProducts()

        {
            var products = new List<Product>();
            {
                using StreamReader reader = new StreamReader(Path.Combine(path, fileName));

                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(separator);

                    if (parts.Length == 3)
                    {
                        products.Add(new Product()
                        {
                            SKU = parts[0],
                            Description = parts[1],
                            Price = Convert.ToDecimal(parts[2])
                        });
                    }
                }
            }
            return products;
        }
        public static void SaveProducts(List<Product> products)
        {
            using StreamWriter sw = new StreamWriter(Path.Combine(path, fileName));
           
            foreach (Product product in products)
            {
                sw.Write(product.SKU + separator);
                sw.Write(product.Description + separator);
                sw.WriteLine(product.Price);
            }
        }
    }
}