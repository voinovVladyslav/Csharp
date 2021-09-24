using System;

namespace ClassTask
{
    class Program
    {
        static void Main()
        {
            TeachersList list = new TeachersList();

            list.AddTeacher("Sasha", "Rook", 26, "Ukraine", "Kherson", "Ushakova", 13, 5);
            list.AddTeacher("Slava", "Groomer", 63, "Ukraine", "Kherson", "Nekrasova", 44, 6);
            
            list.Info();

            list.RemoveTeacher("Rook");

            list.Info();
            /*
             Console.WriteLine("Choose what to do:\n " +
                 "1. Add student \n" +
                 "2." +
                 "3." +
                 "4." +
                 "5." +
                 "6." +
                 "7.");
             int control = 1;
             while (control != 0)
             {
                 control = int.Parse(Console.ReadLine());
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
                     default:
                         break;

                 }
             }
             */
        }
    }
}
