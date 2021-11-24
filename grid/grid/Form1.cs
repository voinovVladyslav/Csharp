using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
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
            Form2.EventDlgt += RefreshData;
            Form3.EventDlgt += RefreshData;
            Form4.EventDlgt += RefreshData;
            Form5.EventDlgt += RefreshData;

            DataTranformer.Load();
            ChartCreate(DataTranformer.teacherList);
            TreeCreate();
            ComboBoxCreate();
            DtCreate(DataTranformer.teacherList);
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

            List<Student> stdList = tch.StudentList;

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
                dt.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Grade, i.Adress.Country, i.Adress.City, i.Adress.Street, i.Adress.HouseNumber);

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
            dt.Columns.Add("Limit");
            dt.Columns.Add("Country");
            dt.Columns.Add("City");
            dt.Columns.Add("Street");
            dt.Columns.Add("House");


            foreach (Teacher i in tchList)
            {
                dt.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Limit, i.Adress.Country, i.Adress.City, i.Adress.Street, i.Adress.HouseNumber);

            }
            dataGridView2.DataSource = dt;

            for (int i = 0; i < DataTranformer.teacherList.Count; i++)
            {

                if (DataTranformer.teacherList[i].StudentList.Count < Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value.ToString()))
                {
                    dataGridView2.Rows[i].Cells[4].Style.BackColor = Color.Green;
                }
                else
                {
                    dataGridView2.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
            }
        }


        public void TreeCreate()
        {
            treeView1.Nodes.Clear();
            TreeNode root = new TreeNode
            {
                Name = "rootName",
                Text = "Teachers"
            };

            treeView1.Nodes.Add(root);

            for (int i = 0; i < DataTranformer.teacherList.Count; i++)
            {
                treeView1.Nodes[0].Nodes.Add(DataTranformer.teacherList[i].Name + " " + DataTranformer.teacherList[i].Surname);
                for (int j = 0; j < DataTranformer.teacherList[i].StudentList.Count(); j++)
                {
                    List<Student> lst = DataTranformer.teacherList[i].StudentList;

                    treeView1.Nodes[0].Nodes[i].Nodes.Add(lst[j].Name + " " + lst[j].Surname);
                }
            }
            treeView1.ExpandAll();
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

        private void SaveTeachers()
        {
            File.WriteAllText(DataTranformer.saveDir, JsonConvert.SerializeObject(DataTranformer.teacherList));
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
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void RefreshData()
        {
            ChartCreate(DataTranformer.teacherList);
            TreeCreate();
            ComboBoxCreate();
            DtCreate(DataTranformer.teacherList);
            List<Student> std = new List<Student>();
            DtCreate(std);
            studentGrid(DataTranformer.name);
        }

        private void studentGrid(string n)
        {
            List<Student> stdLst;

            for (int i = 0; i < DataTranformer.teacherList.Count; i++)
            {
                string Na = DataTranformer.teacherList[i].Name + " " + DataTranformer.teacherList[i].Surname;
                if (Na == n)
                {
                    Teacher tch = DataTranformer.teacherList[i];
                    stdLst = DataTranformer.teacherList[i].StudentList;
                    ChartCreate(tch);
                    DtCreate(stdLst);
                }
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string n = comboBox1.SelectedItem.ToString();
                studentGrid(n);
            }
            catch { MessageBox.Show("Error"); }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataTranformer.name = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                Form6 f = new Form6();
                f.Show();
            }
            catch { MessageBox.Show("Error"); }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataTranformer.name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Form6 f = new Form6();
                f.Show();
            }
            catch { MessageBox.Show("Error"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveTeachers();
            MessageBox.Show("Saved");
        }

       
    }
}