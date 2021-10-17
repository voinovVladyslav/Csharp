using System;
using System.Collections.Generic;
using System.Text;

namespace Fartory
{
    abstract class Product
    {
        protected string Name { get; set; }
        protected int Price { get; set; }

        

        public Product()
        { }

        public Product(string name, int price) 
        {
            Name = name;
            Price = price;
        }

        public void Info() 
        {
            Console.WriteLine(this.Name + " " + this.Price);
        }

    }
}
