﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class Adress
    {
        private string country;
        private string city;
        private string street;
        private int houseNumber;

        public string Country { set; get; }
        public string City { set; get; }
        public string Street { set; get; }
        public int HouseNumber { set; get; }

        public Adress() {}
        public void Change(string Country, string City, string Street, int HouseNumber) { country = Country; city = City; street = Street; houseNumber = HouseNumber; }

        public void Show() { Console.WriteLine("Country: {0}\nCity: {1}\nStreet: {2}\nHouse number: {3}\n", this.country, this.city, this.street, this.houseNumber); }
    }
}
