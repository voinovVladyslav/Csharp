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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            CreatePictureBox(DataTranformer.name);
        }

        private void CreatePictureBox(string NameSurname)
        {
            pictureBox1.Show();
            for (int i = 0; i < DataTranformer.teacherList.Count; i++)
            {
                if (NameSurname == DataTranformer.teacherList[i].ToString())
                {
                    try { pictureBox1.BackgroundImage = Image.FromFile(DataTranformer.PathToFiles() + DataTranformer.teacherList[i].Img); }
                    catch { pictureBox1.BackgroundImage = Image.FromFile(DataTranformer.exeptionDir); }
                    finally { pictureBox1.BackgroundImageLayout = ImageLayout.Stretch; }
                    CreateData(DataTranformer.teacherList[i]);
                }
                List<Student> stdList = DataTranformer.teacherList[i].StudentList;

                for (int j = 0; j < stdList.Count; j++)
                {
                    if (NameSurname == stdList[j].ToString())
                    {
                        try { pictureBox1.BackgroundImage = Image.FromFile(DataTranformer.PathToFiles() + stdList[j].Img); }
                        catch { pictureBox1.BackgroundImage = Image.FromFile(DataTranformer.exeptionDir); }
                        finally { pictureBox1.BackgroundImageLayout = ImageLayout.Stretch; }
                        CreateData(stdList[j]);
                    }
                }
            }
        }

        private void CreateData(Teacher t) 
        {
            labelName.Text = "Name: " + t.Name;
            labelSurname.Text = "Surname:" + t.Surname;
            labelAge.Text = "Age: " + t.Age.ToString();
            labelID.Text = "ID: " + t.ID.ToString();
            labelCountry.Text = "Country: " + t.Adress.Country;
            labelCity.Text = "City: " + t.Adress.City;
            labelStreet.Text = "Street: " + t.Adress.Street;
            labelHouseNumber.Text = "House number: " + t.Adress.HouseNumber;
            labelProfession.Text = "Profession: Teacher";
        }

        private void CreateData(Student s) 
        {
            labelName.Text = "Name: " + s.Name;
            labelSurname.Text = "Surname:" + s.Surname;
            labelAge.Text = "Age: " + s.Age.ToString();
            labelID.Text = "ID: " + s.ID.ToString();
            labelCountry.Text = "Country: " + s.Adress.Country;
            labelCity.Text = "City: " + s.Adress.City;
            labelStreet.Text = "Street: " + s.Adress.Street;
            labelHouseNumber.Text = "House number: " + s.Adress.HouseNumber;
            labelProfession.Text = "Profession: Student";
        }
    }
}
