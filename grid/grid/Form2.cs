using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace grid
{
    public partial class Form2 : Form
    {
        public delegate void dlgt();

        public static event dlgt EventDlgt;

        private string filename;

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

                File.Copy(filename, DataTranformer.PathToFiles() + tch.Img);

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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            filename = openFileDialog.FileName;
            
            pictureBox1.BackgroundImage = Image.FromFile(filename);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

        }
    }
}
        