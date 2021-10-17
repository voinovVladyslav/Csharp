using System;
using System.Collections.Generic;
using System.Text;

namespace Fartory
{
    class CheeseCreator : Creator
    {
        public CheeseCreator(string n) : base(n)
        { }

        public override Product Create()
        {
            return new Cheese();
        }

    }
}
