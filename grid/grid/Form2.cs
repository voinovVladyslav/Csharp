using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grid
{
    public partial class Form2 : Form
    {
        public delegate void dlgt();

        public static event dlgt EventDlgt;

        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        
        private void AddTeacher()
        {
            try
            {
                string name = textBoxTchName.Text;
                string surname = textBoxTchSurname.Text;
                int age = int.Parse(textBoxTchAge.Text);
                int id = int.Parse(textBoxTchID.Text);
                int limit = int.Parse(textBoxTchLimit.Text);
                string country = textBoxTchCountry.Text;
                string city = textBoxTchCity.Text;
                string street = textBoxTchStreet.Text;
                int houseNumber = int.Parse(textBoxTchHouseNumber.Text);

                Adress adr = new Adress(country, city, street, houseNumber);
                Teacher tch = new Teacher(name, surname, age, id, limit, adr);
                DataTranformer.teacherList.Add(tch);
                MessageBox.Show("Added teacher");

                EventDlgt?.Invoke();
            }
            catch { MessageBox.Show("Ne added teacher"); }

            this.Close();
            
        }
        
        

        private void ButtonTchAdd_Click_1(object sender, EventArgs e)
        {
            AddTeacher();
            
        }
    }
}
        