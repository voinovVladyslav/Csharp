using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Fuel
    {
        private static Fuel instance;
        private string type;

        public string Type
        {
            get { return type; }
            private set { type = value; }
        }

        private Fuel(string Type) 
        {
            this.type = Type;
        }

        public static Fuel getInstance(string Type) 
        {
            if (instance == null)
                instance = new Fuel(Type);
            return instance;
        }
    }
}
