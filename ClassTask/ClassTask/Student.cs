using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class Student : Human
    {
        private int averageMarks;
        private Marks status;
        Random number = new Random();
        public float AverageMarksF { set; get; }

        public Student(string Name, string Surname, int Age, string Country, string City, string Street, int HouseNumber) : base(Name, Surname, Age, Country, City, Street, HouseNumber)
        {
            averageMarks = number.Next(1, 6);
            switch (averageMarks)
            {
                case 1:
                    status = Marks.VeryBad;
                    break;
                case 2:
                    status = Marks.Bad;
                    break;
                case 3:
                    status = Marks.Normal;
                    break;
                case 4:
                    status = Marks.Good;
                    break;
                case 5:
                    status = Marks.Excellent;
                    break;
            }
        }
        public Student(string Name, string Surname, int Age, string Country, string City, string Street, int HouseNumber, int Mark ) : base(Name, Surname, Age, Country, City, Street, HouseNumber)
        {
            averageMarks = Mark;
            switch (averageMarks)
            {
                case 1:
                    status = Marks.VeryBad;
                    break;
                case 2:
                    status = Marks.Bad;
                    break;
                case 3:
                    status = Marks.Normal;
                    break;
                case 4:
                    status = Marks.Good;
                    break;
                case 5:
                    status = Marks.Excellent;
                    break;
            }
        }
        public void Info() { this.Show(); Console.WriteLine("Average marks: {0}\nStatus: {1}\n", this.averageMarks, this.status); }
        
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
