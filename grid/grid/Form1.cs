using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTeachers();

            ChartCreate(DataTranformer.teacherList);
            TreeCreate();
            ComboBoxCreate();
            DtCreate(DataTranformer.teacherList);

        }

        private void CreateTeachers() 
        {
            Adress adr = new Adress("Ukraine", "Kherson", "Ushakova", 32);
            Teacher t1 = new Teacher("Valera", "Borov", 22, 53252, adr);
            Teacher t2 = new Teacher("Denis", "Golova", 65, 325234, adr);
            Teacher t3 = new Teacher("Slava", "Ukraintsev", 32, 123423, adr);

            DataTranformer.teacherList.Add(t1);
            DataTranformer.teacherList.Add(t2);
            DataTranformer.teacherList.Add(t3);

            Student s1 = new Student("Grisha", "Griza", 16, 513252, 4, adr);
            Student s2 = new Student("Maksim", "Drova", 31, 325235,2, adr);
            Student s3 = new Student("Danil", "Morgun", 53, 433423, 1, adr);
            Student s4 = new Student("Vladislav", "Stepanov", 12, 4124423, 5, adr);
            Student s5 = new Student("Artur", "Klimenko", 19, 43367, 3, adr);
            Student s6 = new Student("Danil", "Pongurski", 35, 4312323, 4, adr);

            DataTranformer.teacherList[0].AddStudent(s1);
            DataTranformer.teacherList[1].AddStudent(s2);
            DataTranformer.teacherList[1].AddStudent(s3);
            DataTranformer.teacherList[2].AddStudent(s4);
            DataTranformer.teacherList[2].AddStudent(s5);
            DataTranformer.teacherList[2].AddStudent(s6);
        }

        private void ChartCreate(List<Teacher> tchList) 
        {
            chart1.Series["Students"].Points.Clear();
            chart1.Series["Teachers"].Points.Clear();
            for (int i = 0; i < tchList.Count; i++)
            {
                chart1.Series["Teachers"].Points.AddXY(tchList[i].Name, tchList[i].Age);
            }
        }

        private void ChartCreate(Teacher tch)
        {
            chart1.Series["Teachers"].Points.Clear();
            chart1.Series["Students"].Points.Clear();

            List<Student> stdList = tch.GetStudentList();
            
            for (int i = 0; i < stdList.Count; i++)
            {
                chart1.Series["Students"].Points.AddXY(stdList[i].Name, stdList[i].Age);
            }
        }

        private void DtCreate(List<Student> stdList)
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

        private void DtCreate(List<Teacher> tchList)
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

        public void TreeCreate() 
        {
            treeView1.Nodes.Clear();
            TreeNode root = new TreeNode();
            
            root.Name = "rootName";
            root.Text = "Teachers";
            treeView1.Nodes.Add(root);

            for(int i = 0; i < DataTranformer.teacherList.Count; i++)
            {
                treeView1.Nodes[0].Nodes.Add(DataTranformer.teacherList[i].Name + " " + DataTranformer.teacherList[i].Surname);
                for(int j = 0; j < DataTranformer.teacherList[i].GetStudentList().Count(); j++)
                {
                    List<Student> lst = DataTranformer.teacherList[i].GetStudentList();

                    treeView1.Nodes[0].Nodes[i].Nodes.Add(lst[j].Name + " " + lst[j].Surname);
                }
            }
        }

        private void ComboBoxCreate() 
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            for (int i = 0; i < DataTranformer.teacherList.Count; i++)
            {
                comboBox1.Items.Add(DataTranformer.teacherList[i].Name + " " + DataTranformer.teacherList[i].Surname);
            }
        }

        private void TeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 tchForm = new Form2();
            tchForm.Show();
        }

        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 stdForm = new Form3();
            stdForm.Show();
        }

        
        private void TeacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 tchFormRemove = new Form4();
            tchFormRemove.Show();
        }

        private void StudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 stdFormRemove = new Form5();
            stdFormRemove.Show();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            ChartCreate(DataTranformer.teacherList);
            TreeCreate();
            ComboBoxCreate();
            DtCreate(DataTranformer.teacherList);
        }

        private void createPictureBox(string NameSurname) 
        {
            for (int i = 0; i < DataTranformer.teacherList.Count; i++)
            {
                if (NameSurname == DataTranformer.teacherList[i].ToString())
                {
                    try { pictureBox1.BackgroundImage = Image.FromFile(DataTranformer.teacherList[i].Img); }
                    catch { pictureBox1.BackgroundImage = Image.FromFile(DataTranformer.exeptionDir); }
                    finally { pictureBox1.BackgroundImageLayout = ImageLayout.Stretch; }
                }
                List<Student> stdList = DataTranformer.teacherList[i].GetStudentList();

                for (int j = 0; j < stdList.Count; j++) 
                {
                    if (NameSurname == stdList[j].ToString())
                    {
                        try { pictureBox1.BackgroundImage = Image.FromFile(stdList[j].Img); }
                        catch { pictureBox1.BackgroundImage = Image.FromFile(DataTranformer.exeptionDir); }
                        finally { pictureBox1.BackgroundImageLayout = ImageLayout.Stretch; }
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string n = comboBox1.SelectedItem.ToString();
            List<Student> stdLst;

            for (int i = 0; i < DataTranformer.teacherList.Count; i++)
            {
                string Na = DataTranformer.teacherList[i].Name + " " + DataTranformer.teacherList[i].Surname;
                if (Na == n)
                {
                    Teacher tch = DataTranformer.teacherList[i];
                    stdLst = DataTranformer.teacherList[i].GetStudentList();
                    ChartCreate(tch);
                    DtCreate(stdLst);
                }
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ns = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            createPictureBox(ns);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ns = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            createPictureBox(ns);
        }
    }
}