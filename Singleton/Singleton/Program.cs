using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.name = "BMW";
            car.StartEngine("gasoline");

            car.Drive();
            car.StartEngine("gas");
            car.Drive();
        }
    }
}
