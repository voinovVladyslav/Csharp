using System;
using System.Collections.Generic;
using System.Text;

namespace TeachersWinForm
{
    class Human
    {
        private string name;
        private string surname;
        private int weight;
        private int height;
        private string sex;

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
        public int Weight
        {
            set { weight = value; }
            get { return weight; }
        }
        public int Height
        {
            set { height = value; }
            get { return height; }
        }
        public string Sex
        {
            set { sex = value; }
            get { return sex; }
        }
        public Human() { }

        public Human(string Name, string Surname, int Weight, int Height, string Sex)
        {
            name = Name;
            surname = Surname;
            weight = Weight;
            height = Height;
            sex = Sex;
        }

        public virtual void Info()
        {
            Console.WriteLine("Name: {0}\nSurname: {1}\nAge: {2}", this.name, this.surname, this.weight);
            
        }

        public void Introduction()
        {
            Console.WriteLine(name + " " + surname);
        }

        public override string ToString()
        {
            return "Name: {name} \nSurname: {surname} \nHeight: {height} \n Weight: {weight} \n Sex: {sex}";
        }

    }
}
