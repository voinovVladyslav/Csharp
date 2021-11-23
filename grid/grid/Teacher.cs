using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grid
{
    class Teacher : Human
    {
        private List<Student> studentList = new List<Student>();
        private int limit;
        public List<Student> StudentList
        {
            set { studentList = value; }
            get { return studentList; }
        }
        public int Limit 
        {
            set { limit = value; }
            get { return limit; }
        }

        public Teacher() { }

        public Teacher(string Name, string Surname, int Age, int ID, int Limit, Adress adr) :
            base(Name, Surname, Age, ID, adr)
        {
            limit = Limit;
        }

        public Teacher(string Name, string Surname, int Age, int ID, int Limit, string Img, Adress adr) :
            base(Name, Surname, Age, ID, adr, Img)
        {
            limit = Limit;
            
        }

        public void AddStudent(Student std)
        {
            if (studentList.Count <= limit)
                studentList.Add(std);

        }

        public void RemoveStudent(int index) 
        {
            studentList.RemoveAt(index);
        }

    }
}
