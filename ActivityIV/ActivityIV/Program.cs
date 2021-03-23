using ActivityIV.Builder;
using ActivityIV.Class;
using ActivityIV.Concrete_Sales;
using System;
using System.Collections.Generic;

namespace ActivityIV
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SaleBuilder builder;
            Director director = new Director();

            List<Product> products = new List<Product>()
            {
                new Product (1, "Notebook", 3000),
                new Product (2, "Tablet", 1000),
                new Product (3, "Smartphone", 1000),
            };

            builder = new InCashBuilder();
            director.Create(builder);

            // Descomentar para testar com os outros tipos de vendas.

            //builder = new DebitBuilder();
            //director.Create(builder);

            //builder = new ParceledOutBuilder();
            //director.Create(builder);

            foreach (var p in products)
                builder.Sale.addProduct(p);

            builder.Sale.getPrice();
            Console.WriteLine("Total: R$ " + builder.Sale.getPrice().ToString("N0"));
        }
    }
}
