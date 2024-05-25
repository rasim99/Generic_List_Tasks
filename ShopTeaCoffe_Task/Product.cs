using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTeaCoffe_Task
{
    internal abstract class Product
    {
        protected Product(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
        public string  Name { get; set; }
        public int Count { get; set; }
       public double Price { get; set; }

        public override string ToString()
        {
            return GetType().Name;
        }

    }
}
