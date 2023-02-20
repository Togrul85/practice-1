using System;
using System.Collections.Generic;
using System.Text;

namespace aspnet.practice.Models
{
    class ProductItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public double TotalPrice { get; set; }
    }
}
