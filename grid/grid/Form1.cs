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

        

        public Form1()
        {
            InitializeComponent();
        }

        

        

        private List<Human> CreateHumans() 
        {
            List<Human> lst = new List<Human>();
            Adress adr = new Adress("Ukraine","Kherson","Ushakova", 38);
            Human h1 = new Human("Valera", "Borov", 22, 53252, adr);
            Human h2 = new Human("Denis", "Golova", 15, 325234, adr);
            Human h3 = new Human("Slava", "Ukraintsev", 32, 123423, adr);

            lst.Add(h1);
            lst.Add(h2);
            lst.Add(h3);

            return lst;
        }

        public void dtCreate() 
        {

            List<Human> list = CreateHumans();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Age");
            dt.Columns.Add("ID");
            dt.Columns.Add("Country");
            dt.Columns.Add("City");
            dt.Columns.Add("Street");
            dt.Columns.Add("House");


            foreach (Human i in list) 
            {
                dt.Rows.Add(i.Name, i.Surname, i.Age, i.ID, i.Country, i.City, i.Street, i.HouseNumber);
                this.chart1.Series["Series1"].Points.AddXY(i.Name, i.Age);
            }

            this.dataGridView1.DataSource = dt;
            

            
           
        }

        public void treeCreate() 
        {
            TreeNode root = new TreeNode();

            root.Name = "rootName";
            root.Text = "cars";
            treeView1.Nodes.Add(root);
            treeView1.Nodes[0].Nodes.Add("bmw");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("x5");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("x7");
            treeView1.Nodes[0].Nodes.Add("mercedes-benz");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("s500");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("c200");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtCreate();
            treeCreate();


        }
    }
}

