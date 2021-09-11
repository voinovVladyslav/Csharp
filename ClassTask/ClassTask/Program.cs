using System;

namespace ClassTask
{
    class Program
    {
        static void Main()
        {
            //Human person = new Human("Tom","Hohland",54,"USA","New York","Khreshatyk",14);
            //person.Show();

            Student pasha = new Student("Pavel", "Gnom", 19, "Ukraine", "Kherson", "Nekrasova", 21);
           
            pasha.Info();

            Student valera = new Student("Valera", "Bull", 19, "Ukraine", "Kherson", "Ushakova", 122, 2);
           
            valera.Info();
        }
    }
}
