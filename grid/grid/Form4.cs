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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboboxCreate();
        }

        private void comboboxCreate() 
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < DataTranformer.teacherList.Count; i++)
            {
                comboBox1.Items.Add(DataTranformer.teacherList[i].Name + " " + DataTranformer.teacherList[i].Surname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = comboBox1.SelectedItem.ToString();
            for (int i = 0; i < DataTranformer.teacherList.Count(); i++) 
            {
                if (n == DataTranformer.teacherList[i].Name + " " + DataTranformer.teacherList[i].Surname) 
                {
                    DataTranformer.teacherList.RemoveAt(i);
                }
            }
        }
    }
}
