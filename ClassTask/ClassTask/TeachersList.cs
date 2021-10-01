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
            teachers.Add(new Teacher(Name,  Surname,  Age,  Country,  City,  Street,  HouseNumber,  Limit));
            Console.WriteLine("Teacher was successfuly added");
        }

        public void AddTeacher(Teacher t) 
        {
            teachers.Add(t);
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

        public void RemoveTeacher(string N,string S) 
        {
            foreach (Teacher i in teachers) 
            {
                if (N == i.Name & S == i.Surname)
                {
                    teachers.Remove(i);
                    Console.WriteLine($"Teacher {N} {S} was successfully removed");
                    break;
                }
                
            }
        }

     

        public  void Info() 
        {
            Console.WriteLine("Teachers:");
            foreach (Teacher i in teachers) 
            {
                i.Introduction();
            }
        }
    }
}
