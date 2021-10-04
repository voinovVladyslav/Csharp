using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class Teacher : Human
    {
        private int limit;
        private int limitCounter;
        private List<Student> students;


        public int Limit { set; get; }
        public Teacher() { }
        public Teacher(string Name, string Surname, int Age, string Country, string City, string Street, int HouseNumber, int Limit) : base(Name, Surname, Age, Country, City, Street, HouseNumber)
        {
            limit = Limit;
            limitCounter = 0;
            students = new List<Student>(Limit);
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("Max students: {0}", this.limit);
            Console.WriteLine("Students under wing:{0}", this.limitCounter);
            
        }
        public void StudentsIntroduction() 
        {
            if (students.Count == 0) 
            {
                Console.WriteLine("There is no students");
                return;
            }
            foreach (Student i in students)
            {
                i.Introduction();
            }
        }
        public void StudentsInfo()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("There is no students");
                return;
            }
            foreach (Student i in students)
            {
                i.Info();
            }
        }
        public void AddStudent(Student student)
        {
            if (limitCounter < limit)
            {
                students.Insert(0, student);
                limitCounter++;
                Console.WriteLine("Succsesfuly added student");
            }
            else
                Console.WriteLine("Students limit!");
        }
        public void RemoveStudent(Student student)
        {
            if (limitCounter == 0)
            {
                Console.WriteLine("There is no one to remove");
            }
            else
            {
                students.Remove(student);
                limitCounter--;
                Console.WriteLine("Succsesfuly removed student");
            }
        }
        public void RemoveStudent(string Name,string Surname) 
        {
            if (limitCounter == 0)
            {
                Console.WriteLine("There is no one to remove");
            }
            else
            {
                foreach (Student i in students) 
                {
                    if (i.Name == Name & i.Surname == Surname) 
                    {
                        students.Remove(i);
                        limitCounter--;
                        Console.WriteLine("Succsesfuly removed student");
                    }
                }
            }

        }
        public static bool operator >(Teacher t1, Teacher t2)
        {
            return t1.limitCounter > t2.limitCounter;
        }
        public static bool operator <(Teacher t1, Teacher t2)
        {
            return t1.limitCounter < t2.limitCounter;
        }

        public static bool operator ==(Teacher t1, Teacher t2)
        {
            return t1.Name == t2.Name & t1.Surname == t2.Surname & t1.Age == t2.Age;
        }
        public static bool operator !=(Teacher t1, Teacher t2)
        {
            return t1.Name != t2.Name & t1.Surname != t2.Surname & t1.Age != t2.Age;
        }
       
        
    }
}
