using System;

namespace ClassTask
{
    class Program
    {
        static void Main()
        {
            Human tom = new Human("Tom","Hohland",54,"USA","New York","Khreshatyk",14);
            tom.Show();

            Student valera = new Student();
            valera.Show();
            
        }
    }
}
