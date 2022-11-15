using AOPBegin.ConsoleUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPBegin.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {




            //Postsharp 
            var productService = TransparentProxy<ProductService, IProductService>.GenerateProxy();

            // Servis üzerinden GetProduct metotunu çağırıyoruz.
            var product = productService.GetProduct(1453);
            product = productService.GetProducts(1453,"deneme",DateTime.Now);

            product = productService.Save(new Product { Id = 3, Name = "dd", Price = 10 });
            Console.WriteLine("Id: {0}, Name: {1}, Price: {2}", product.Id, product.Name, product.Price);

            var repository = new Repository();
            var d = repository.Run<ProductService, Product>(x => x.GetProduct(2));

            Console.ReadLine();




        }
    }
}
