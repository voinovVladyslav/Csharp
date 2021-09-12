using System;

namespace ClassTask
{
    class Program
    {
        static void Main()
        {
            Student pasha = new Student("Pavel", "Gnom", 19, "Ukraine", "Kherson", "Nekrasova", 21);
            Student slava = new Student("Slava", "Bortnik", 18, "Ukraine", "Kherson", "John Govard", 76, 5);

            Teacher valera = new Teacher("Valera", "Bull", 19, "Ukraine", "Kherson", "Ushakova", 122, 4);

            valera.AddStudent(pasha);
            valera.AddStudent(slava);
            valera.InfoTeacher();
            valera.RemoveStudent(pasha);
            valera.InfoTeacher();
            Console.WriteLine("Choose what to do:\n " +
                "1. Add student \n" +
                "2." +
                "3." +
                "4." +
                "5." +
                "6." +
                "7.");
            int control = int.Parse(Console.ReadLine());
            while (control != 0)
            {
                switch (control)
                {
                    case 0:

                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;

                }
            }
        }
    }
}
