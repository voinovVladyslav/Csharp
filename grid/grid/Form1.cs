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
    public partial class Form1 : Form
    {
        private List<Teacher> teacherList = new List<Teacher>();

        public Form1()
        {
            InitializeComponent();

        }

        private void CreateTeachers() 
        {
            Adress adr = new Adress("Ukraine", "Kherson", "Ushakova", 32);
            Teacher t1 = new Teacher("Valera", "Borov", 22, 53252, adr);
            Teacher t2 = new Teacher("Denis", "Golova", 15, 325234, adr);
            Teacher t3 = new Teacher("Slava", "Ukraintsev", 32, 123423, adr);

            teacherList.Add(t1);
            teacherList.Add(t2);
            teacherList.Add(t3);

            Student s1 = new Student("Grisha", "Griza", 16, 513252, 4, adr);
            Student s2 = new Student("Maksim", "Drova", 31, 325235,2, adr);
            Student s3 = new Student("Danil", "Morgun", 53, 433423, 1, adr);
            Student s4 = new Student("Vladislav", "Stepanov", 12, 4124423, 5, adr);
            Student s5 = new Student("Artur", "Klimenko", 19, 43367, 3, adr);
            Student s6 = new Student("Danil", "Pongurski", 35, 4312323, 4, adr);

            teacherList[0].AddStudent(s1);
            teacherList[1].AddStudent(s2);
            teacherList[1].AddStudent(s3);
            teacherList[2].AddStudent(s4);
            teacherList[2].AddStudent(s5);
            teacherList[2].AddStudent(s6);
        }

        private void chartCreate(List<Teacher> tchList) 
        {
            chart1.Series["Series1"].Points.Clear();
            for (int i = 0; i < tchList.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(tchList[i].Name, tchList[i].Age);
            }
        }

        private void chartCreate(List<Student> stdList)
        {
            chart1.Series["Series1"].Points.Clear();
            for (int i = 0; i < stdList.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(stdList[i].Name, stdList[i].Age);
            }
        }

        private void dtCreate(List<Student> stdList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Age");
            dt.Columns.Add("ID");
            dt.Columns.Add("Mark");
            dt.Columns.Add("Country");
            dt.Columns.Add("City");
            dt.Columns.Add("Street");
            dt.Columns.Add("House");
            
            foreach (Student i in stdList)
            {
                dt.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Mark, i.Country, i.City, i.Street, i.HouseNumber);
            }
            dataGridView1.DataSource = dt;
        }

        private void dtCreate(List<Teacher> tchList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Age");
            dt.Columns.Add("ID");
            dt.Columns.Add("Country");
            dt.Columns.Add("City");
            dt.Columns.Add("Street");
            dt.Columns.Add("House");

            foreach (Teacher i in tchList)
            {
                dt.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Country, i.City, i.Street, i.HouseNumber);
            }
            dataGridView2.DataSource = dt;
        }

        public void treeCreate() 
        {
            TreeNode root = new TreeNode();
            root.Name = "rootName";
            root.Text = "Teachers";
            treeView1.Nodes.Add(root);

            for(int i = 0; i < teacherList.Count; i++)
            {
                treeView1.Nodes[0].Nodes.Add(teacherList[i].Name);
                for(int j = 0; j < teacherList[i].GetStudentList().Count(); j++)
                {
                    List<Student> lst = teacherList[i].GetStudentList();

                    treeView1.Nodes[0].Nodes[i].Nodes.Add(lst[j].Name);
                    
                }
            }
        }

        private void comboBoxCreate() 
        {
            for (int i = 0; i < teacherList.Count; i++)
            {
                comboBox1.Items.Add(teacherList[i].Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTeachers();

            chartCreate(teacherList);
            treeCreate();
            comboBoxCreate();
            dtCreate(teacherList);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = comboBox1.SelectedItem.ToString();
            
            List<Student> stdLst = new List<Student>();

            for (int i = 0; i < teacherList.Count; i++) 
            {
                if (teacherList[i].Name == n) 
                {
                    List<Student> lst = teacherList[i].GetStudentList();

                    for (int j = 0; j < lst.Count; j++) 
                    {
                        
                        stdLst.Add(lst[j]);
                    }
                }
            }
            chartCreate(stdLst);
            dtCreate(stdLst);
        }

        private void AddTeacher() 
        {
            string country = textBoxTchCountry.Text;
            string city = textBoxTchCity.Text;
            string street = textBoxTchStreet.Text;
            int houseNumber = int.Parse(textBoxTchHouseNumber.Text);

            Adress adr = new Adress(country, city, street, houseNumber);

            string name = textBoxTchName.Text;
            string surname = textBoxTchSurname.Text;
            int age = int.Parse(textBoxTchAge.Text);
            int id = int.Parse(textBoxTchID.Text);

            Teacher tch = new Teacher(name, surname, age, id, adr);
            teacherList.Add(tch);
        }

        private void buttonTchAdd_Click(object sender, EventArgs e)
        {
            AddTeacher();
            
        }
    }
}