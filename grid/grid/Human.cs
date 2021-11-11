using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grid
{
    class Human
    {
        string name;
        string surname;
        int age;
        int id;
        string img;
        Adress adress;

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
        public int ID
        {
            set {id = value; }
            get { return id; }
        }
        public Adress Adress 
        {
            set { adress = value; }
            get { return adress; }
        }
        public string Img 
        {
            set { img = value; }
            get { return img; }
        }

        public Human() 
        { }

        public Human(string Name, string Surname, int Age, int ID, Adress adr) 
        {
            name = Name;
            surname = Surname;
            age = Age;
            id = ID;
            adress = adr;
            img = this.ToString() + ".jpg";
        }

        public Human(string Name, string Surname, int Age, int ID, Adress adr, string Img)
        {
            name = Name;
            surname = Surname;
            age = Age;
            id = ID;
            adress = adr;
            img = DataTranformer.dir + Img;
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }

    }
}
