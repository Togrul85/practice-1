using aspnet.practice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace aspnet.practice
{
    class Program
    {
        static void Main(string[] args)
        {

            #region MyRegion
            Product p1 = new Product { Id = 1, Name = "Iphone", Price = 2000 };
            Product p2 = new Product { Id = 2, Name = "Samsung", Price = 1000 };

            ProductItem productItem = new ProductItem { Id = 1, TotalPrice = p1.Price, Product = p1 };
            ProductItem productItem1= new ProductItem { Id = 2, TotalPrice = p2.Price,Product = p1 };

            List<ProductItem> list = new List<ProductItem>();
            list.Add(productItem);
            list.Add(productItem1);

            ProductItems productItems = new ProductItems { Id = 1, productItems = list };
            string result = JsonConvert.SerializeObject(productItems);
           

          


            #endregion
        }
    }
}
