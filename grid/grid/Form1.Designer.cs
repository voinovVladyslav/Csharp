namespace grid
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxStdMark = new System.Windows.Forms.TextBox();
            this.buttonStdAdd = new System.Windows.Forms.Button();
            this.buttonTchAdd = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxStdHouseNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxStdStreet = new System.Windows.Forms.TextBox();
            this.textBoxStdCity = new System.Windows.Forms.TextBox();
            this.textBoxStdCountry = new System.Windows.Forms.TextBox();
            this.textBoxStdID = new System.Windows.Forms.TextBox();
            this.textBoxStdAge = new System.Windows.Forms.TextBox();
            this.textBoxStdSurname = new System.Windows.Forms.TextBox();
            this.textBoxStdName = new System.Windows.Forms.TextBox();
            this.textBoxTchHouseNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTchStreet = new System.Windows.Forms.TextBox();
            this.textBoxTchCity = new System.Windows.Forms.TextBox();
            this.textBoxTchCountry = new System.Windows.Forms.TextBox();
            this.textBoxTchID = new System.Windows.Forms.TextBox();
            this.textBoxTchAge = new System.Windows.Forms.TextBox();
            this.textBoxTchSurname = new System.Windows.Forms.TextBox();
            this.textBoxTchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 149);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(277, 321);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(300, 150);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(6, 321);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(220, 150);
            this.treeView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(933, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(887, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1002, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 512);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.textBoxStdMark);
            this.tabPage2.Controls.Add(this.buttonStdAdd);
            this.tabPage2.Controls.Add(this.buttonTchAdd);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.textBoxStdHouseNumber);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.textBoxStdStreet);
            this.tabPage2.Controls.Add(this.textBoxStdCity);
            this.tabPage2.Controls.Add(this.textBoxStdCountry);
            this.tabPage2.Controls.Add(this.textBoxStdID);
            this.tabPage2.Controls.Add(this.textBoxStdAge);
            this.tabPage2.Controls.Add(this.textBoxStdSurname);
            this.tabPage2.Controls.Add(this.textBoxStdName);
            this.tabPage2.Controls.Add(this.textBoxTchHouseNumber);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxTchStreet);
            this.tabPage2.Controls.Add(this.textBoxTchCity);
            this.tabPage2.Controls.Add(this.textBoxTchCountry);
            this.tabPage2.Controls.Add(this.textBoxTchID);
            this.tabPage2.Controls.Add(this.textBoxTchAge);
            this.tabPage2.Controls.Add(this.textBoxTchSurname);
            this.tabPage2.Controls.Add(this.textBoxTchName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1014, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(791, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Mark";
            // 
            // textBoxStdMark
            // 
            this.textBoxStdMark.Location = new System.Drawing.Point(871, 153);
            this.textBoxStdMark.Name = "textBoxStdMark";
            this.textBoxStdMark.Size = new System.Drawing.Size(100, 20);
            this.textBoxStdMark.TabIndex = 36;
            // 
            // buttonStdAdd
            // 
            this.buttonStdAdd.Location = new System.Drawing.Point(859, 325);
            this.buttonStdAdd.Name = "buttonStdAdd";
            this.buttonStdAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonStdAdd.TabIndex = 35;
            this.buttonStdAdd.Text = "CreateS";
            this.buttonStdAdd.UseVisualStyleBackColor = true;
            // 
            // buttonTchAdd
            // 
            this.buttonTchAdd.Location = new System.Drawing.Point(103, 270);
            this.buttonTchAdd.Name = "buttonTchAdd";
            this.buttonTchAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonTchAdd.TabIndex = 34;
            this.buttonTchAdd.Text = "CreateT";
            this.buttonTchAdd.UseVisualStyleBackColor = true;
            this.buttonTchAdd.Click += new System.EventHandler(this.buttonTchAdd_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(868, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Add Student";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(100, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Add Teacher";
            // 
            // textBoxStdHouseNumber
            // 
            this.textBoxStdHouseNumber.Location = new System.Drawing.Point(871, 257);
            this.textBoxStdHouseNumber.Name = "textBoxStdHouseNumber";
            this.textBoxStdHouseNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxStdHouseNumber.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(789, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "House number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(789, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Street";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(789, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(789, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Country";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(789, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(789, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Age";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(789, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Surname";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(789, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Name";
            // 
            // textBoxStdStreet
            // 
            this.textBoxStdStreet.Location = new System.Drawing.Point(871, 231);
            this.textBoxStdStreet.Name = "textBoxStdStreet";
            this.textBoxStdStreet.Size = new System.Drawing.Size(100, 20);
            this.textBoxStdStreet.TabIndex = 22;
            // 
            // textBoxStdCity
            // 
            this.textBoxStdCity.Location = new System.Drawing.Point(871, 205);
            this.textBoxStdCity.Name = "textBoxStdCity";
            this.textBoxStdCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxStdCity.TabIndex = 21;
            // 
            // textBoxStdCountry
            // 
            this.textBoxStdCountry.Location = new System.Drawing.Point(871, 179);
            this.textBoxStdCountry.Name = "textBoxStdCountry";
            this.textBoxStdCountry.Size = new System.Drawing.Size(100, 20);
            this.textBoxStdCountry.TabIndex = 20;
            // 
            // textBoxStdID
            // 
            this.textBoxStdID.Location = new System.Drawing.Point(871, 127);
            this.textBoxStdID.Name = "textBoxStdID";
            this.textBoxStdID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStdID.TabIndex = 19;
            // 
            // textBoxStdAge
            // 
            this.textBoxStdAge.Location = new System.Drawing.Point(871, 101);
            this.textBoxStdAge.Name = "textBoxStdAge";
            this.textBoxStdAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxStdAge.TabIndex = 18;
            // 
            // textBoxStdSurname
            // 
            this.textBoxStdSurname.Location = new System.Drawing.Point(871, 75);
            this.textBoxStdSurname.Name = "textBoxStdSurname";
            this.textBoxStdSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxStdSurname.TabIndex = 17;
            // 
            // textBoxStdName
            // 
            this.textBoxStdName.Location = new System.Drawing.Point(871, 49);
            this.textBoxStdName.Name = "textBoxStdName";
            this.textBoxStdName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStdName.TabIndex = 16;
            // 
            // textBoxTchHouseNumber
            // 
            this.textBoxTchHouseNumber.Location = new System.Drawing.Point(103, 228);
            this.textBoxTchHouseNumber.Name = "textBoxTchHouseNumber";
            this.textBoxTchHouseNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxTchHouseNumber.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "House number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // textBoxTchStreet
            // 
            this.textBoxTchStreet.Location = new System.Drawing.Point(103, 202);
            this.textBoxTchStreet.Name = "textBoxTchStreet";
            this.textBoxTchStreet.Size = new System.Drawing.Size(100, 20);
            this.textBoxTchStreet.TabIndex = 6;
            // 
            // textBoxTchCity
            // 
            this.textBoxTchCity.Location = new System.Drawing.Point(103, 176);
            this.textBoxTchCity.Name = "textBoxTchCity";
            this.textBoxTchCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxTchCity.TabIndex = 5;
            // 
            // textBoxTchCountry
            // 
            this.textBoxTchCountry.Location = new System.Drawing.Point(103, 150);
            this.textBoxTchCountry.Name = "textBoxTchCountry";
            this.textBoxTchCountry.Size = new System.Drawing.Size(100, 20);
            this.textBoxTchCountry.TabIndex = 4;
            // 
            // textBoxTchID
            // 
            this.textBoxTchID.Location = new System.Drawing.Point(103, 124);
            this.textBoxTchID.Name = "textBoxTchID";
            this.textBoxTchID.Size = new System.Drawing.Size(100, 20);
            this.textBoxTchID.TabIndex = 3;
            // 
            // textBoxTchAge
            // 
            this.textBoxTchAge.Location = new System.Drawing.Point(103, 98);
            this.textBoxTchAge.Name = "textBoxTchAge";
            this.textBoxTchAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxTchAge.TabIndex = 2;
            // 
            // textBoxTchSurname
            // 
            this.textBoxTchSurname.Location = new System.Drawing.Point(103, 72);
            this.textBoxTchSurname.Name = "textBoxTchSurname";
            this.textBoxTchSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxTchSurname.TabIndex = 1;
            // 
            // textBoxTchName
            // 
            this.textBoxTchName.Location = new System.Drawing.Point(103, 46);
            this.textBoxTchName.Name = "textBoxTchName";
            this.textBoxTchName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTchName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 527);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxTchHouseNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTchStreet;
        private System.Windows.Forms.TextBox textBoxTchCity;
        private System.Windows.Forms.TextBox textBoxTchCountry;
        private System.Windows.Forms.TextBox textBoxTchID;
        private System.Windows.Forms.TextBox textBoxTchAge;
        private System.Windows.Forms.TextBox textBoxTchSurname;
        private System.Windows.Forms.TextBox textBoxTchName;
        private System.Windows.Forms.TextBox textBoxStdHouseNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxStdStreet;
        private System.Windows.Forms.TextBox textBoxStdCity;
        private System.Windows.Forms.TextBox textBoxStdCountry;
        private System.Windows.Forms.TextBox textBoxStdID;
        private System.Windows.Forms.TextBox textBoxStdAge;
        private System.Windows.Forms.TextBox textBoxStdSurname;
        private System.Windows.Forms.TextBox textBoxStdName;
        private System.Windows.Forms.Button buttonStdAdd;
        private System.Windows.Forms.Button buttonTchAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxStdMark;
    }
}

