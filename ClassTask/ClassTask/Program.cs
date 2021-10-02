using System;

namespace ClassTask
{
    class Program
    {
        static void Main()
        {
            TeachersList list = new TeachersList();

             Console.WriteLine("Choose what to do:\n " +
                 "0. Exit" +
                 "1. Add teacher\n" +
                 "2. Delete teacher\n" +
                 "3. Work with teacher\n" +
                 "4. Show all teachers");
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
             
        }
    }
}
