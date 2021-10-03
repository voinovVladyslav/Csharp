using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class Student : Human
    {
        private int averageMarks;
        private Marks rating;
        Random number = new Random();
        public int AverageMarks 
        {
            set { averageMarks = value; }
            get { return averageMarks; }
        }
        public Student() { }

        public Student(string Name, string Surname, int Age, string Country, string City, string Street, int HouseNumber) : base(Name, Surname, Age, Country, City, Street, HouseNumber)
        {

            averageMarks = number.Next(1, 6);
            switch (averageMarks)
            {
                case 1:
                    rating = Marks.VeryBad;
                    break;
                case 2:
                    rating = Marks.Bad;
                    break;
                case 3:
                    rating = Marks.Normal;
                    break;
                case 4:
                    rating = Marks.Good;
                    break;
                case 5:
                    rating = Marks.Excellent;
                    break;
            }
        }
        public Student(string Name, string Surname, int Age, string Country, string City, string Street, int HouseNumber, int Mark) : base(Name, Surname, Age, Country, City, Street, HouseNumber)
        {
            averageMarks = Mark;
            switch (averageMarks)
            {
                case 1:
                    rating = Marks.VeryBad;
                    break;
                case 2:
                    rating = Marks.Bad;
                    break;
                case 3:
                    rating = Marks.Normal;
                    break;
                case 4:
                    rating = Marks.Good;
                    break;
                case 5:
                    rating = Marks.Excellent;
                    break;
            }
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("Average marks: {0}\nRating: {1}\n", this.averageMarks, this.rating);
        }

        public static bool operator <(Student s1, Student s2)
        {
            return s1.averageMarks < s2.averageMarks;
        }

        public static bool operator >(Student s1, Student s2)
        {
            return s1.averageMarks > s2.averageMarks;
        }

    }
}
