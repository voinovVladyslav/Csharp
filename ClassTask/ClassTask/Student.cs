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
        public float AverageMarksF { set; get; }

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
        public Student(string Name, string Surname, int Age, string Country, string City, string Street, int HouseNumber, int Mark ) : base(Name, Surname, Age, Country, City, Street, HouseNumber)
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
        public void InfoStudent() { this.Show(); Console.WriteLine("Average marks: {0}\nRating: {1}\n", this.averageMarks, this.rating); }
        
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
