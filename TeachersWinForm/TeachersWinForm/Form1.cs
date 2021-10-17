using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachersWinForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Text = "Hello";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(400, 400);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text;
            string Surname = textBoxSurname.Text;
            int Height = int.Parse(textBoxHeight.Text);
            int Weight = int.Parse(textBoxWeight.Text);

            string Sex = null;
            if (radioButtoMale.Checked)
            {
                Sex = "male";
            }
            else if (radioButtonFemale.Checked)
            {
                Sex = "female";
            }
            Human human = new Human(Name, Surname, Weight, Height, Sex);
            textBoxOutput.Text = human.ToString();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
