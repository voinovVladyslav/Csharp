using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Car
    {
        public string name;
        public Fuel fuel { get; set; }

        public void StartEngine(string typeName) 
        {
            fuel = Fuel.getInstance(typeName);
        }
        public void Drive() 
        {
            Console.WriteLine("{0} engine ready to go", fuel.Type);
        }
    }
}
