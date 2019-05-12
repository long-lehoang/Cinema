namespace Cinema
{
    partial class fStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cinemaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new Cinema.CinemaDataSet();
            this.txtsearchStaff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureURL = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtstreet_addr = new System.Windows.Forms.TextBox();
            this.txtdistrict = new System.Windows.Forms.TextBox();
            this.txtdayofbirth = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtssn = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.ssn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdeleteStaff = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // cinemaDataSetBindingSource
            // 
            this.cinemaDataSetBindingSource.DataSource = this.cinemaDataSet;
            this.cinemaDataSetBindingSource.Position = 0;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "CinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtsearchStaff
            // 
            this.txtsearchStaff.Location = new System.Drawing.Point(355, 57);
            this.txtsearchStaff.Name = "txtsearchStaff";
            this.txtsearchStaff.Size = new System.Drawing.Size(331, 20);
            this.txtsearchStaff.TabIndex = 2;
            this.txtsearchStaff.Text = "Nhập tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sách Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edit);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 495);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(216, 456);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 5;
            this.edit.Text = "Sửa";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(110, 456);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.pictureURL);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtsalary);
            this.groupBox2.Controls.Add(this.txtstreet_addr);
            this.groupBox2.Controls.Add(this.txtdistrict);
            this.groupBox2.Controls.Add(this.txtdayofbirth);
            this.groupBox2.Controls.Add(this.txtgender);
            this.groupBox2.Controls.Add(this.txtlname);
            this.groupBox2.Controls.Add(this.txtphone);
            this.groupBox2.Controls.Add(this.txtfname);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.txtssn);
            this.groupBox2.Controls.Add(this.txtpassword);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(17, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 431);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Picture";
            // 
            // pictureURL
            // 
            this.pictureURL.Location = new System.Drawing.Point(82, 403);
            this.pictureURL.Name = "pictureURL";
            this.pictureURL.Size = new System.Drawing.Size(174, 23);
            this.pictureURL.TabIndex = 5;
            this.pictureURL.Text = "Upload";
            this.pictureURL.UseVisualStyleBackColor = true;
            this.pictureURL.Click += new System.EventHandler(this.pictureURL_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "SSN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 380);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Lương";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đường";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quận/Huyện";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(82, 377);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(174, 20);
            this.txtsalary.TabIndex = 2;
            // 
            // txtstreet_addr
            // 
            this.txtstreet_addr.Location = new System.Drawing.Point(82, 355);
            this.txtstreet_addr.Name = "txtstreet_addr";
            this.txtstreet_addr.Size = new System.Drawing.Size(174, 20);
            this.txtstreet_addr.TabIndex = 2;
            // 
            // txtdistrict
            // 
            this.txtdistrict.Location = new System.Drawing.Point(82, 329);
            this.txtdistrict.Name = "txtdistrict";
            this.txtdistrict.Size = new System.Drawing.Size(174, 20);
            this.txtdistrict.TabIndex = 2;
            // 
            // txtdayofbirth
            // 
            this.txtdayofbirth.Location = new System.Drawing.Point(82, 303);
            this.txtdayofbirth.Name = "txtdayofbirth";
            this.txtdayofbirth.Size = new System.Drawing.Size(174, 20);
            this.txtdayofbirth.TabIndex = 2;
            this.txtdayofbirth.Text = "mm-dd-yyyy";
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(82, 277);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(174, 20);
            this.txtgender.TabIndex = 2;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(82, 251);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(174, 20);
            this.txtlname.TabIndex = 2;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(82, 201);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(174, 20);
            this.txtphone.TabIndex = 2;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(82, 225);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(174, 20);
            this.txtfname.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(82, 175);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(174, 20);
            this.txtemail.TabIndex = 2;
            this.txtemail.Text = "name@example.com";
            // 
            // txtssn
            // 
            this.txtssn.Location = new System.Drawing.Point(82, 123);
            this.txtssn.Name = "txtssn";
            this.txtssn.Size = new System.Drawing.Size(174, 20);
            this.txtssn.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(82, 149);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(174, 20);
            this.txtpassword.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(708, 318);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(109, 350);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(174, 20);
            this.textBox8.TabIndex = 2;
            this.textBox8.Text = "Nhập tên nhân viên";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(801, 55);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(80, 23);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Tìm Kiếm";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(801, 318);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(80, 23);
            this.btnrefresh.TabIndex = 1;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.foodToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filmToolStripMenuItem.Text = "Film";
            this.filmToolStripMenuItem.Click += new System.EventHandler(this.filmToolStripMenuItem_Click);
            // 
            // foodToolStripMenuItem
            // 
            this.foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            this.foodToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.foodToolStripMenuItem.Text = "Food";
            this.foodToolStripMenuItem.Click += new System.EventHandler(this.foodToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.AllowUserToAddRows = false;
            this.dtgvStaff.AllowUserToDeleteRows = false;
            this.dtgvStaff.AllowUserToOrderColumns = true;
            this.dtgvStaff.AutoGenerateColumns = false;
            this.dtgvStaff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssn,
            this.name,
            this.email,
            this.phonenumber,
            this.gender,
            this.dayofbirth,
            this.district,
            this.street_addr,
            this.salary});
            this.dtgvStaff.DataSource = this.cinemaDataSetBindingSource;
            this.dtgvStaff.Location = new System.Drawing.Point(355, 84);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.ReadOnly = true;
            this.dtgvStaff.Size = new System.Drawing.Size(526, 226);
            this.dtgvStaff.TabIndex = 7;
            // 
            // ssn
            // 
            this.ssn.DataPropertyName = "ssn";
            this.ssn.HeaderText = "SSN";
            this.ssn.Name = "ssn";
            this.ssn.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Họ Và Tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phonenumber
            // 
            this.phonenumber.DataPropertyName = "phonenumber";
            this.phonenumber.HeaderText = "Số Điện Thoại";
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Giới Tính";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // dayofbirth
            // 
            this.dayofbirth.DataPropertyName = "dayofbirth";
            this.dayofbirth.HeaderText = "Ngày Sinh";
            this.dayofbirth.Name = "dayofbirth";
            this.dayofbirth.ReadOnly = true;
            // 
            // district
            // 
            this.district.DataPropertyName = "district";
            this.district.HeaderText = "Quận/Huyện";
            this.district.Name = "district";
            this.district.ReadOnly = true;
            // 
            // street_addr
            // 
            this.street_addr.DataPropertyName = "street_addr";
            this.street_addr.HeaderText = "Đường";
            this.street_addr.Name = "street_addr";
            this.street_addr.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Lương";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // txtdeleteStaff
            // 
            this.txtdeleteStaff.Location = new System.Drawing.Point(355, 321);
            this.txtdeleteStaff.Name = "txtdeleteStaff";
            this.txtdeleteStaff.Size = new System.Drawing.Size(331, 20);
            this.txtdeleteStaff.TabIndex = 2;
            this.txtdeleteStaff.Text = "Nhập SSN nhân viên";
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 531);
            this.Controls.Add(this.dtgvStaff);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtdeleteStaff);
            this.Controls.Add(this.txtsearchStaff);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fStaff_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cinemaDataSetBindingSource;
        private CinemaDataSet cinemaDataSet;

        private System.Windows.Forms.TextBox txtsearchStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdistrict;
        private System.Windows.Forms.TextBox txtdayofbirth;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtstreet_addr;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button pictureURL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtssn;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn street_addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.TextBox txtdeleteStaff;
    }
}

