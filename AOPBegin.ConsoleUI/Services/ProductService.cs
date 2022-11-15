﻿using AOPBegin.ConsoleUI.Aspect.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPBegin.ConsoleUI.Services
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public interface IProductService
    {
        Product GetProduct(int productId);
        Product GetProducts(int productId, string name, DateTime date);
        Product Save(Product p);
    }
    public class ProductService :IProductService
    {
        // In memory olarak bir kaç product ekliyorum.
        private static Dictionary<int, Product> _InMemDb = new Dictionary<int, Product>();

        public ProductService()
        {
            if (!_InMemDb.Any())
            {
                _InMemDb.Add(1, new Product() { Id = 1, Name = "MacBook Air", Price = 3000 });
                _InMemDb.Add(2, new Product() { Id = 2, Name = "Sony Xperia Z Ultra", Price = 1400 }); 
            }
        }

        [Cache(DurationInMinute = 10)]
        [Log]
        public Product GetProduct(int productId)
        {
            return _InMemDb[1];
        }



        [Log]
        public Product GetProducts(int productId,string name,DateTime date)
        {
            return _InMemDb[1];
        }

        [Log]
        public Product Save(Product p)
        {
            return new Product { Id = 3, Name = "tt", Price = 10 };
        }
    }
}
