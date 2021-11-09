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
        public List<Student> StudentList
        {
            set { }
            get { return studentList; }
        }

        public List<Student> GetStudentList() 
        {
            return studentList;
        }
            
        public Teacher() { }

        public Teacher(string Name, string Surname, int Age, int ID, Adress adr) :
            base(Name, Surname, Age, ID, adr)
        {

        }

        public void AddStudent(Student std)
        {
            studentList.Add(std);
        }

        public void RemoveStudent(int index) 
        {
            studentList.RemoveAt(index);
        }

    }
}
