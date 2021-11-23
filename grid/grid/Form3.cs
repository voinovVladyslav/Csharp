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
    public partial class Form3 : Form
    {
        public delegate void dlgt();
        public static event dlgt EventDlgt;

        private string filename;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ComboBoxCreate();
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

                File.Copy(filename, DataTranformer.PathToFiles() + std.Img);

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
                EventDlgt?.Invoke();
            }
            catch { MessageBox.Show("Ne added student"); }

            this.Close();
            
        }

        private void ComboBoxCreate()
        {
            comboBox2.Items.Clear();
            for (int i = 0; i < DataTranformer.teacherList.Count; i++)
            {
                if (DataTranformer.teacherList[i].StudentList.Count < DataTranformer.teacherList[i].Limit) 
                    comboBox2.Items.Add(DataTranformer.teacherList[i].Name + " " + DataTranformer.teacherList[i].Surname);
            }
        }

        private void ButtonStdAdd_Click_1(object sender, EventArgs e)
        {
            AddStudent();
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
    