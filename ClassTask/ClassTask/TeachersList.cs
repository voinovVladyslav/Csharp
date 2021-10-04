using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class TeachersList
    {
        private List<Teacher> teachers;

        public TeachersList() { teachers = new List<Teacher>(); }
        public void AddTeacher(string Name, string Surname, int Age, string Country, string City, string Street, int HouseNumber, int Limit) 
        {
            teachers.Insert(0, new Teacher(Name, Surname, Age, Country, City, Street, HouseNumber, Limit));
            Console.WriteLine("Teacher was successfuly added");
        }

        public void AddTeacher(Teacher t) 
        {
            teachers.Insert(0, t);
            Console.WriteLine("Teacher was successfuly added");
        }

        public void RemoveTeacher(Teacher t) 
        {
            foreach (Teacher i in teachers) 
            {
                if (i == t) 
                {
                    teachers.Remove(i);
                    Console.WriteLine($"Teacher {t.Name} {t.Surname} was successfully removed");
                    break;
                }
            }
        
        }

        public void RemoveTeacher(string Name, string Surname)
        {
            foreach (Teacher i in teachers)
            {
                if (i.Name == Name & i.Surname == Surname)
                {
                    teachers.Remove(i);
                    Console.WriteLine("Teacher {0} {1} was successfully removed", Name, Surname);
                    break;
                }
            }

        }
        public void RemoveTeacher(int index)
        {
            teachers.RemoveAt(index);
            Console.WriteLine("Teacher with index {0} was successfully removed", index);

        }
        
        
        public  void Info() 
        {
            if (teachers.Count == 0)
            {
                Console.WriteLine("Empty list");
                return;
            }
            Console.WriteLine("Teachers:");
            foreach (Teacher i in teachers) 
            {
                i.Introduction();
            }
            
        }

        public int FindTeacher(string Name, string Surname) 
        {
            foreach (Teacher i in teachers)
            {
                
                if (Name == i.Name & Surname == i.Surname)
                {
                    return teachers.IndexOf(i);
                }
                
            }
            
            return -1;
        }

        public void WorkWithTeacher(int index) 
        {
            Console.WriteLine("0. End working\n" +
                "1. Get info\n" +
                "2. Get full info\n" +
                "3. Add student\n" +
                "4. Remove sudent\n" +
                "5. Show students\n" +
                "6. Show students info");
            int control = 1;
            while (control != 0) 
            {
                Console.WriteLine("Enter command:");
                control = int.Parse(Console.ReadLine());
                switch(control)               
                { 
                    case 0:
                        Console.WriteLine("Back to main menu");
                        break;

                    case 1:
                        teachers[index].Introduction();
                        break;

                    case 2:
                        teachers[index].Info();
                        break;

                    case 3:
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
                        Student student = new Student(n, s, a, cntr, ct, str, h);
                        teachers[index].AddStudent(student);
                        break;

                    case 4:
                        Console.WriteLine("Enter students name and surname to remove\n" +
                            "name:");
                        n = Console.ReadLine();
                        Console.WriteLine("surname");
                        s = Console.ReadLine();
                        teachers[index].RemoveStudent(n, s);
                        break;

                    case 5:
                        teachers[index].StudentsIntroduction();
                        break;

                    case 6:
                        teachers[index].StudentsInfo();
                        break;
                    default:
                        Console.WriteLine("Invalid value");
                        break;
                }
            }
        }
    }
}
