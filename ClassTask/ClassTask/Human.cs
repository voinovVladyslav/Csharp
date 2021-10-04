using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class Human
    {
        private string name;
        private string surname;
        private int age;

        private Adress adress = new Adress();

        public string Name 
        {
            set { name = value; }
            get { return name; }
        }
        public string Surname
        {
            set { surname = value; }
            get { return surname; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public string Country 
        { 
            set {   adress.Country = value; }
            get {   return adress.Country;  }
        }

        public string City 
        {
            set {   adress.City = value; }
            get {   return adress.City; }
        
        }
        public string Street
        {
            set { adress.Street = value; }
            get { return adress.Street; }

        }
        public int HouseNumber
        {
            set { adress.HouseNumber = value; }
            get { return adress.HouseNumber; }

        }
        public Human() {}

        public Human(string Name, string Surname, int Age, string Country, string City, string Street, int HouseNumber) 
        {
            name = Name; 
            surname = Surname; 
            age = Age; 
            adress.Change(Country, City, Street, HouseNumber); 
        }

        public virtual void Info() 
        { 
            Console.WriteLine("Name: {0}\nSurname: {1}\nAge: {2}", this.name, this.surname, this.age);
            adress.Show();
        }

        public void Introduction()
        {
            Console.WriteLine(name + " " + surname);
        }

    }
}
