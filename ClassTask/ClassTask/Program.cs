using System;

namespace ClassTask
{
    class Program
    {
        static void Main()
        {
            TeachersList list = new TeachersList();

            Console.WriteLine("0. Exit\n" +
                 "1. Add teacher\n" +
                 "2. Find teacher\n" +
                 "3. Work with teacher\n" +
                 "4. Show all teachers");
            Teacher t = new Teacher("Valera","Biven",54,"Ukraine","Kherson","",7,4);
            list.AddTeacher(t);
            int control = 1;
            while (control != 0)
            {
                Console.WriteLine("Enter command:");
                control = int.Parse(Console.ReadLine());
                switch (control)
                {
                     case 0:
                        Console.WriteLine("Exit");
                        break;
                     case 1:
                        Console.WriteLine("Enter name:");
                        string n = Console.ReadLine();

                        Console.WriteLine("Enter surname:");
                        string s = Console.ReadLine();

                        Console.WriteLine("Enter age:");
                        int a = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter country:");
                        string cntr = Console.ReadLine();

                        Console.WriteLine("Enter city:");
                        string ct = Console.ReadLine();

                        Console.WriteLine("Enter street:");
                        string str = Console.ReadLine();

                        Console.WriteLine("Enter house number:");
                        int h = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter limit of students under wing:");
                        int l = int.Parse(Console.ReadLine());

                        list.AddTeacher(n,s,a,cntr,ct,str,h,l);
                        break;
                    case 2:
                        Console.WriteLine("Enter name and surname to search\n" +
                            "name:");
                        n = Console.ReadLine();
                        Console.WriteLine("surname:");
                        s = Console.ReadLine();
                        
                        if (list.FindTeacher(n, s) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else 
                        {
                            Console.WriteLine("In list with index {0}",list.FindTeacher(n, s));
                            
                        }
                       break;
                    case 3:
                        Console.WriteLine("Enter teachres index to work with");
                        int i = int.Parse(Console.ReadLine());
                        list.WorkWithTeacher(i);
                        break;
                    case 4:
                       list.ShowAll();
                       break;
                    default:
                       Console.WriteLine("Wrong value");
                       break;

                }
            }
             
        }
    }
}
