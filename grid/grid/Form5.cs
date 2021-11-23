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
    public partial class Form5 : Form
    {
        public delegate void dlgt();

        public static event dlgt EventDlgt;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ComboboxCreate();
        }

        private void ComboboxCreate() 
        {
            for (int i = 0; i < DataTranformer.teacherList.Count(); i++)  
            {
                List<Student> stdList = DataTranformer.teacherList[i].StudentList;

                for (int j = 0; j < stdList.Count(); j++) 
                {
                    comboBoxStudents.Items.Add(stdList[j].ToString());
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string n = comboBoxStudents.SelectedItem.ToString();

            for (int i = 0; i < DataTranformer.teacherList.Count(); i++)
            {
                List<Student> stdList = DataTranformer.teacherList[i].StudentList;

                for (int j = 0; j < stdList.Count(); j++)
                {
                    if (n == stdList[j].ToString()) 
                    {
                        File.Delete(DataTranformer.PathToFiles() + DataTranformer.teacherList[i].StudentList[j].Img);
                        DataTranformer.teacherList[i].RemoveStudent(j);
                        MessageBox.Show($"Removed {n}");
                        this.Close();
                        EventDlgt?.Invoke();
                    }
                }
            }

        }
    }
}
