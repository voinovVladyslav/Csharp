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
       
        private Adress _adress = new Adress();
        public string Name { set; get; }
        public string Surname { set; get; }
        public int Age { set; get; }

        public Human() { name = "Unknown"; surname = "Unknown"; }

        public Human(string Name, string Surname, int Age, string Country, string City, string Street, int HouseNumber) { name = Name; surname = Surname; age = Age; _adress.ChangeAdress(Country, City, Street, HouseNumber); }

        public void Show() { Console.WriteLine("Name: {0}\nSurname: {1}\nAge: {2}\n", this.Name, this.Surname, this.Age); _adress.Show(); }
    }
}
