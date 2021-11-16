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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            bool found = false;
            string ns = textBoxFind.Text;
            for (int i = 0; i < DataTranformer.teacherList.Count; i++) 
            {
                if (ns == DataTranformer.teacherList[i].ToString()) 
                {
                    found = true;
                    DataTranformer.name = ns;
                    Form6 f = new Form6();
                    f.Show();
                }

                for (int j = 0; j < DataTranformer.teacherList[i].StudentList.Count; j++)
                {
                    if (ns == DataTranformer.teacherList[i].StudentList[j].ToString())
                    {
                        found = true;
                        DataTranformer.name = ns;
                        Form6 f = new Form6();
                        f.Show();
                    }
                }
            }

            if (!found) 
            {
                MessageBox.Show("No matches found");
                
            }
            
        }
    }
}
