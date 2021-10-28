using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grid
{
    class Student : Human
    {
        private Marks mark;
        private int grade;
        Random rnd = new Random();

        public string Mark
        {
            set { }
            get { return mark.ToString(); }
        }
        
        

        public Student() { }

        public Student(string Name, string Surname, int Age, int ID, Adress adr) :
            base(Name, Surname, Age, ID, adr)
        {
            this.grade = rnd.Next(1, 6);
            switch (grade)
            {
                case 1:
                    mark = Marks.VeryBad;
                    break;
                case 2:
                    mark = Marks.Bad;
                    break;
                case 3:
                    mark = Marks.Normal;
                    break;
                case 4:
                    mark = Marks.Good;
                    break;
                case 5:
                    mark = Marks.Excellent;
                    break;
            }
        }

        public Student(string Name, string Surname, int Age, int ID, int grade, Adress adr) :
            base(Name, Surname, Age, ID, adr)
        {
           
            switch (grade)
            {
                case 1:
                    mark = Marks.VeryBad;
                    break;
                case 2:
                    mark = Marks.Bad;
                    break;
                case 3:
                    mark = Marks.Normal;
                    break;
                case 4:
                    mark = Marks.Good;
                    break;
                case 5:
                    mark = Marks.Excellent;
                    break;
            }
        }

        enum Marks
        {
            Excellent,
            Good,
            Normal,
            Bad,
            VeryBad
        }
    }
}
