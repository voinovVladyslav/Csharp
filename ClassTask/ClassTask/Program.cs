using System;

namespace ClassTask
{
    class Human
    {
        private string name;
        private string surname;
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
            public Adress(string Country, string City, string Street, int HouseNumber) { country = Country; city = City; street = Street; houseNumber = HouseNumber; }

            public void Show() { Console.WriteLine("Country: {0}\nCity: {1}\nStreet: {2}\nHouse number: {3}\n", this.Country, this.City, this.Street, this.HouseNumber); }
        }
        public string Name { set { name = value; } get { return name; } }

        public string Surname { set { surname = value; } get { return surname; } }

        public Human() { name = "Unknown"; surname = "Unknown"; }

        public Human(string Name, string Surname) { name = Name; surname = Surname; }




        public void Show() { Console.WriteLine("Name: {0}\nSurname: {1}\nAdress:", this.name, this.surname); } 
    }



    class Program
    {
        static void Main()
        {
            Human tom = new Human();
            tom.Show();
        }
    }
}
