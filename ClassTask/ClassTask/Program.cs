using System;

namespace ClassTask
{
    class Human
    {
        private string name;
        private string surname;
        private int age;
        private class Adress 
        {
            private string country;
            private string city;
            private string street;
            private int houseNumber;
            
            public string Country { set { country = value; } get { return country; } }
            public string City { set { city = value; } get { return city; } }
            public string Street { set { street = value; } get { return street; } }
            public int HouseNumber { set { houseNumber = value; } get { return houseNumber; } }

            public Adress() { country = "Unknown"; city = "Unknown"; street = "Unknown"; houseNumber = 0; }
            public void ChangeAdress(string Country, string City, string Street, int HouseNumber) { country = Country; city = City; street = Street; houseNumber = HouseNumber; }

            public void Show() { Console.WriteLine("Country: {0}\nCity: {1}\nStreet: {2}\nHouse number: {3}\n", this.Country, this.City, this.Street, this.HouseNumber); }
        }

        private Adress _adress = new Adress();
        public string Name { set { name = value; } get { return name; } }
        public string Surname { set { surname = value; } get { return surname; } }
        public int Age { set { age = value; }get { return age; } }

        public Human() { name = "Unknown"; surname = "Unknown"; }

        public Human(string Name, string Surname, int Age, string Country, string City, string Street, int HouseNumber) { name = Name; surname = Surname; age = Age; _adress.ChangeAdress(Country, City, Street, HouseNumber); }

        public void Show() { Console.WriteLine("Name: {0}\nSurname: {1}\nAge: {2}\n", this.Name, this.Surname, this.Age); _adress.Show(); } 
    }

    class Student : Human 
    {
        private float averageMarksF;
        private Marks status;

        public float AverageMarksF { set { averageMarksF = value; } get { return averageMarksF; } }
        
        enum Marks
        {
            Excellent,
            Good,
            Normal,
            Bad
        }
    
    }

    class Teacher : Human 
    {
        private string subject;
        private int numberOfStutents;
    
        public int NumberOfStudents { set { } get { return numberOfStutents; } }
    
    }

    class Program
    {
        static void Main()
        {
            Human tom = new Human("Tom","Hohland",54,"USA","New York","Khreshatyk",14);
            tom.Show();

            Student valera = new Student();
            valera.Show();
            
        }
    }
}
