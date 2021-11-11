using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grid
{
    class Student : Human
    {
        private int grade;

        public int Grade 
        {
            set { grade = value; }
            get { return grade; }
        }
        
        public Student() { }

        public Student(string Name, string Surname, int Age, int ID, int Grade, Adress adr) :
            base(Name, Surname, Age, ID, adr)
        {
            grade = Grade;
        }
    }
}
