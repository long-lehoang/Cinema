namespace Cinema
{
    partial class fFilm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupload = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtactor = new System.Windows.Forms.TextBox();
            this.txtview_estimation = new System.Windows.Forms.TextBox();
            this.txtlanguage = new System.Windows.Forms.TextBox();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.txtintroduce = new System.Windows.Forms.TextBox();
            this.txtopening_day = new System.Windows.Forms.TextBox();
            this.txtproducer = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlength = new System.Windows.Forms.TextBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdelete = new System.Windows.Forms.TextBox();
            this.dtgvFilm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinemaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new Cinema.CinemaDataSet();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.foodToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.staffToolStripMenuItem.Text = "Nhân Viên";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filmToolStripMenuItem.Text = "Film";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnupload);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.txtactor);
            this.panel1.Controls.Add(this.txtview_estimation);
            this.panel1.Controls.Add(this.txtlanguage);
            this.panel1.Controls.Add(this.txtcategory);
            this.panel1.Controls.Add(this.txtintroduce);
            this.panel1.Controls.Add(this.txtopening_day);
            this.panel1.Controls.Add(this.txtproducer);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtlength);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 406);
            this.panel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(155, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Thông Tin Film";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Diễn viên tham gia";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Lượt xem dự kiến";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngôn ngữ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thể loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Trailer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới thiệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày công chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà sản xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời lượng(phút)";
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(130, 174);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(229, 23);
            this.btnupload.TabIndex = 0;
            this.btnupload.Text = "Upload";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(217, 355);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Thêm ";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtactor
            // 
            this.txtactor.Location = new System.Drawing.Point(130, 278);
            this.txtactor.Name = "txtactor";
            this.txtactor.Size = new System.Drawing.Size(229, 20);
            this.txtactor.TabIndex = 3;
            // 
            // txtview_estimation
            // 
            this.txtview_estimation.Location = new System.Drawing.Point(130, 252);
            this.txtview_estimation.Name = "txtview_estimation";
            this.txtview_estimation.Size = new System.Drawing.Size(229, 20);
            this.txtview_estimation.TabIndex = 3;
            this.txtview_estimation.Text = "Yêu cầu >200";
            // 
            // txtlanguage
            // 
            this.txtlanguage.Location = new System.Drawing.Point(130, 226);
            this.txtlanguage.Name = "txtlanguage";
            this.txtlanguage.Size = new System.Drawing.Size(229, 20);
            this.txtlanguage.TabIndex = 3;
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(130, 200);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(229, 20);
            this.txtcategory.TabIndex = 3;
            // 
            // txtintroduce
            // 
            this.txtintroduce.Location = new System.Drawing.Point(130, 148);
            this.txtintroduce.Name = "txtintroduce";
            this.txtintroduce.Size = new System.Drawing.Size(229, 20);
            this.txtintroduce.TabIndex = 3;
            // 
            // txtopening_day
            // 
            this.txtopening_day.Location = new System.Drawing.Point(130, 122);
            this.txtopening_day.Name = "txtopening_day";
            this.txtopening_day.Size = new System.Drawing.Size(229, 20);
            this.txtopening_day.TabIndex = 3;
            // 
            // txtproducer
            // 
            this.txtproducer.Location = new System.Drawing.Point(130, 96);
            this.txtproducer.Name = "txtproducer";
            this.txtproducer.Size = new System.Drawing.Size(229, 20);
            this.txtproducer.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(130, 44);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(229, 20);
            this.txtname.TabIndex = 3;
            // 
            // txtlength
            // 
            this.txtlength.Location = new System.Drawing.Point(130, 70);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(229, 20);
            this.txtlength.TabIndex = 3;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(307, 355);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 0;
            this.btnedit.Text = "Cập nhật";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtdelete);
            this.panel2.Controls.Add(this.dtgvFilm);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.btnrefresh);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Location = new System.Drawing.Point(403, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 406);
            this.panel2.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Danh Sách Film";
            // 
            // txtdelete
            // 
            this.txtdelete.Location = new System.Drawing.Point(16, 357);
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(159, 20);
            this.txtdelete.TabIndex = 5;
            this.txtdelete.Text = "Nhập tên";
            // 
            // dtgvFilm
            // 
            this.dtgvFilm.AllowUserToAddRows = false;
            this.dtgvFilm.AllowUserToDeleteRows = false;
            this.dtgvFilm.AllowUserToOrderColumns = true;
            this.dtgvFilm.AutoGenerateColumns = false;
            this.dtgvFilm.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dtgvFilm.DataSource = this.cinemaDataSetBindingSource;
            this.dtgvFilm.Location = new System.Drawing.Point(15, 84);
            this.dtgvFilm.Name = "dtgvFilm";
            this.dtgvFilm.ReadOnly = true;
            this.dtgvFilm.Size = new System.Drawing.Size(355, 249);
            this.dtgvFilm.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "Tên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "length";
            this.Column2.HeaderText = "Thời Lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "producer";
            this.Column3.HeaderText = "Nhà sản xuất";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "opening_day";
            this.Column4.HeaderText = "Ngày công chiếu";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "introduce";
            this.Column5.HeaderText = "Giới thiệu";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "category";
            this.Column6.HeaderText = "Thể loại";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "language";
            this.Column7.HeaderText = "Ngôn ngữ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "views_estimation";
            this.Column8.HeaderText = "Lượt xem dự kiến";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "actor";
            this.Column9.HeaderText = "Diễn viên";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
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
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(15, 48);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(229, 20);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.Text = "Nhập tên ";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(296, 355);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 2;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(195, 355);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(296, 46);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // fFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fFilm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fFilm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox txtdelete;
        private System.Windows.Forms.DataGridView dtgvFilm;
        private System.Windows.Forms.BindingSource cinemaDataSetBindingSource;
        private CinemaDataSet cinemaDataSet;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtproducer;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.TextBox txtactor;
        private System.Windows.Forms.TextBox txtview_estimation;
        private System.Windows.Forms.TextBox txtlanguage;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.TextBox txtintroduce;
        private System.Windows.Forms.TextBox txtopening_day;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label13;
    }
}