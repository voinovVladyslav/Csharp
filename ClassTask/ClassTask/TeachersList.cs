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

        public void Info(int Index) 
        {
            if (Index > teachers.Count) 
            {
                Console.WriteLine("Number isnt in list range");
                return;
            }
            teachers[Index].Info();
        }
        public void Introduction(int Index) 
        {
            if (Index > teachers.Count)
            {
                Console.WriteLine("Number isnt in list range");
                return;
            }
            teachers[Index].Introduction();
        }
        public  void ShowAll() 
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
            Console.WriteLine("0. Exit\n" +
                "1. Get info\n" +
                "2. Get full info\n" +
                "3. \n" +
                "4. ");
            int control = 1;
            while (control != 0) 
            {
                Console.WriteLine("Enter command:");
                control = int.Parse(Console.ReadLine());
                switch(control)               
                { 
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    case 1:
                        this.Introduction(index);
                        break;
                    case 2:
                        this.Info(index);
                        break;
                    default:
                        Console.WriteLine("Invalid value");
                        break;
                }
            }
        }
    }
}
