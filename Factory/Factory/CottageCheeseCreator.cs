using System;
using System.Collections.Generic;
using System.Text;

namespace Fartory
{
    class CottageCheeseCreator : Creator
    {
        public CottageCheeseCreator(string n) : base(n)
        { }
         
        public override Product Create()
        {
            return new CottageCheese();
        }
    }
}
