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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBoxCreate();
        }

        private void AddStudent()
        {
            try
            {
                string name = textBoxStdName.Text;
                string surname = textBoxStdSurname.Text;
                int age = int.Parse(textBoxStdAge.Text);
                int id = int.Parse(textBoxStdID.Text);
                int mark = int.Parse(textBoxStdMark.Text);
                string country = textBoxStdCountry.Text;
                string city = textBoxStdCity.Text;
                string street = textBoxStdStreet.Text;
                int houseNumber = int.Parse(textBoxStdHouseNumber.Text);

                Adress adr = new Adress(country, city, street, houseNumber);
                Student std = new Student(name, surname, age, id, mark, adr);

                string n = comboBox2.SelectedItem.ToString();

                for (int i = 0; i < DataTranformer.teacherList.Count; i++)
                {
                    string Na = DataTranformer.teacherList[i].Name + " " + DataTranformer.teacherList[i].Surname;
                    if (n == Na)
                    {
                        DataTranformer.teacherList[i].AddStudent(std);
                        MessageBox.Show("Added student");
                    }
                }
            }
            catch { MessageBox.Show("Ne added student"); }

            this.Close();
            
        }

        private void comboBoxCreate()
        {
            comboBox2.Items.Clear();
            for (int i = 0; i < DataTranformer.teacherList.Count; i++)
            {
                comboBox2.Items.Add(DataTranformer.teacherList[i].Name + " " + DataTranformer.teacherList[i].Surname);
            }
        }

        private void buttonStdAdd_Click_1(object sender, EventArgs e)
        {
            AddStudent();
        }
    }
}
    