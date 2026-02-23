using System;
using Data2;

namespace Data
{
    class program
    {

        public static void Main()
        {
            List<Product> products = new List<Product>();
            products.AddRange([new Product()
            {
                Name = "Piatos",
                Id = 1,
                Price = (decimal)10.50,
                CreatedDate = DateTime.Now
            },

            new Product()
            {
                Name = "Nova",
                Id = 2,
                Price = (decimal)10.50,
                CreatedDate = DateTime.Now
            },
            new Product()
            {
                Name = "Nova",
                Id = 2,
                Price = (decimal)10.50,
                CreatedDate = DateTime.Now
            
            
            }]);

            foreach (var product in products) 
            {
                Console.WriteLine($"Id: {product.Id}\n" +
                                 $"Name:{product.Name}\n" +
                                 $"Price:{product.Price}\n" +
                                $" CreatedDate:{product.CreatedDate.ToShortDateString()}");
            }













        }
    }
}





