
using System;
using Data2;


namespace Data
{

    class program
    {

        public static void Main()
        {
            Product product = new Product();
            {
                product.Id = 5;
                product.Name = "Kilaton";
                product.Price = (decimal)1.50;
                product.CreatedDate = DateTime.Now;


                Console.WriteLine($"Id: {product.Id}\n" +
                                 $"Name:{product.Name}\n" +
                                 $"Price:{product.Price}\n" +
                                $" CreatedDate:{product.CreatedDate.ToShortDateString()}");

            }      
            
        }
    
    }



}

