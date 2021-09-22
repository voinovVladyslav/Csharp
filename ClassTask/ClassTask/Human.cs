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

        public string Name { set; get; }
        public string Surname { set; get; }
        public int Age { set; get; }
        public Human() {}

        public Human(string Name, string Surname, int Age, string Country, string City, string Street, int HouseNumber) { name = Name; surname = Surname; age = Age; adress.Change(Country, City, Street, HouseNumber); }

        public virtual void Info() { Console.WriteLine("Name: {0}\nSurname: {1}\nAge: {2}\n", this.name, this.surname, this.age); adress.Show(); }
    }
}
