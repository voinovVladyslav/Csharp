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
    public partial class Form4 : Form
    {
        public delegate void dlgt();

        public static event dlgt EventDlgt;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ComboboxCreate();
        }

        private void ComboboxCreate() 
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < DataTranformer.teacherList.Count; i++)
            {
                comboBox1.Items.Add(DataTranformer.teacherList[i].Name + " " + DataTranformer.teacherList[i].Surname);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string n = comboBox1.SelectedItem.ToString();
            for (int i = 0; i < DataTranformer.teacherList.Count(); i++) 
            {
                if (n == DataTranformer.teacherList[i].ToString()) 
                {
                    File.Delete(DataTranformer.PathToFiles() + DataTranformer.teacherList[i].Img);
                    DataTranformer.teacherList.RemoveAt(i);
                    
                    MessageBox.Show($"Removed {n}");
                    this.Close();
                    EventDlgt?.Invoke();
                }
            }
        }
    }
}
