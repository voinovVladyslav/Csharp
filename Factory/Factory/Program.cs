using System;

namespace Fartory
{
    class Program
    {
        static void Main()
        {
            Creator cheeseFactory = new CheeseCreator("OOO Cheese");
            Product cheese = cheeseFactory.Create();

            cheese.Info();

            cheeseFactory = new CottageCheeseCreator("OOO Cottage Cheese");
            cheese = cheeseFactory.Create();

            cheese.Info(); 
            
        }
    }
}
