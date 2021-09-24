using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class TeachersList
    {
        private List<Teacher> teachers;

        public void AddTeacher(string Name, string Surname, int Age, string Country, string City, string Street, int HouseNumber, int Limit) 
        {
            teachers.Add(new Teacher(Name,  Surname,  Age,  Country,  City,  Street,  HouseNumber,  Limit));
        }

        public void Info() { }
    }
}
