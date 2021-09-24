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
        }

        public void RemoveTeacher(string S) 
        {
            foreach (Teacher i in teachers) 
            {
                Console.WriteLine(i.Surname);
                if (S == i.Surname)
                {
                    teachers.Remove(i);
                    Console.WriteLine("Teacher {} {} successfully deleted", i.Name, i.Surname);
                    break;
                }
                
            }
        }

        public void LimitSort() 
        {
            teachers.Sort(); 
        }

        public  void Info() 
        {
            foreach (Teacher i in teachers) 
            {
                i.Introduction();
            }
        }
    }
}
