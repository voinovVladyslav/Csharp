using System;
using System.Collections.Generic;
using System.Text;

namespace Fartory
{
    abstract class Creator
    {
        public string Name { get; set; }

        public Creator(string n) 
        {
            Name = n;
        }

        abstract public Product Create();



    }
}
