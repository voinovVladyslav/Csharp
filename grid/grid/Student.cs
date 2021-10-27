using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grid
{
    class Student : Human
    {
        
        public Student() { }

        public Student(string Name, string Surname, int Age, int ID, Adress adr) :
            base(Name, Surname, Age, ID, adr)
        {

        }
    }
}
