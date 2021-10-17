using System;

namespace Fartory
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator cheeseFactory = new CheeseCreator("Sirovarnya");
            Product cheese = cheeseFactory.Create();

            cheese.Info();

            cheeseFactory = new CottageCheeseCreator("Tvorogovarnia");
            cheese = cheeseFactory.Create();

            cheese.Info();
        }
    }
}
