using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grid
{
    class Adress
    {
        private string country;
        private string city;
        private string street;
        private int houseNumber;

        public string Country
        {
            set { country = value; }
            get { return country; }
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public string Street
        {
            set { street = value; }
            get { return street; }
        }
        public int HouseNumber
        {
            set { houseNumber = value; }
            get { return houseNumber; }
        }

        public Adress() { }
        public Adress(string Country, string City, string Street, int HouseNumber)
        {
            country = Country;
            city = City;
            street = Street;
            houseNumber = HouseNumber;
        }
    }
}
