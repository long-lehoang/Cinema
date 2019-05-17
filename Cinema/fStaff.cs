using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Cinema.DAO;

namespace Cinema
{
    public partial class fStaff : Form
    {
        protected string query = "select * from [VIEW_STAFF]";

        public fStaff()
        {

            InitializeComponent();
            loaddataStaff(query);
        }

        // query with database
        void loaddataStaff(string query)
        {
            try
            {
                dtgvStaff.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            query = "select * from dbo.[VIEW_STAFF] where name='" + txtsearchStaff.Text + "'";
            loaddataStaff(query);
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            query = "select * from [VIEW_STAFF]";
            loaddataStaff(query);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdayofbirth.Text == "" || txtdistrict.Text == "" || txtemail.Text == "" ||
               txtdistrict.Text == "" || txtdistrict.Text == "" || txtdistrict.Text == "" ||
               txtdistrict.Text == "" || txtdistrict.Text == "" || txtdistrict.Text == "" ||
               txtdistrict.Text == "" || txtdistrict.Text == "")
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string ssn = "'" + txtssn.Text + "',";
                    string passw = "'" + txtpassword.Text + "',";
                    string email = "'" + txtemail.Text + "',";
                    string phone = "'" + txtphone.Text + "',";
                    string fname = "'" + txtfname.Text + "',";
                    string lname = "'" + txtlname.Text + "',";
                    string dayofbirth = "'" + txtdayofbirth.Text + "',";
                    string street_addr = "'" + txtstreet_addr.Text + "',";
                    string gender = "'" + txtgender.Text + "',";
                    string district = "'" + txtdistrict.Text + "',";
                    string salary = txtsalary.Text;
                    string picurl = ",'" + pictureBox1.ImageLocation + "'";
                    query = "exec add_staff " + ssn + passw + email + phone + gender + fname + lname + dayofbirth + district + street_addr + salary + picurl;

                    loaddataStaff(query);
                    query = "select * from [VIEW_STAFF]";
                    loaddataStaff(query);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureURL_Click(object sender, EventArgs e)
        {
            string imagelocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;

                    pictureBox1.ImageLocation = imagelocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            query = "exec delete_staff '" + txtdeleteStaff.Text + "'";
            loaddataStaff(query);

            query = "select * from [VIEW_STAFF]";
            loaddataStaff(query);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdayofbirth.Text == "" || txtdistrict.Text == "" || txtemail.Text == "" ||
               txtdistrict.Text == "" || txtdistrict.Text == "" || txtdistrict.Text == "" ||
               txtdistrict.Text == "" || txtdistrict.Text == "" || txtdistrict.Text == "" ||
               txtdistrict.Text == "" || txtdistrict.Text == "")
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string ssn = "'" + txtssn.Text + "',";
                    string passw = "'" + txtpassword.Text + "',";
                    string email = "'" + txtemail.Text + "',";
                    string phone = "'" + txtphone.Text + "',";
                    string fname = "'" + txtfname.Text + "',";
                    string lname = "'" + txtlname.Text + "',";
                    string dayofbirth = "'" + txtdayofbirth.Text + "',";
                    string street_addr = "'" + txtstreet_addr.Text + "',";
                    string gender = "'" + txtgender.Text + "',";
                    string district = "'" + txtdistrict.Text + "',";
                    string salary = txtsalary.Text;
                    string picurl = ",'" + pictureBox1.ImageLocation + "'";
                    query = "exec update_staff " + ssn + passw + email + phone + gender + fname + lname + dayofbirth + district + street_addr + salary + picurl;

                    loaddataStaff(query);

                    query = "select * from [VIEW_STAFF]";
                    loaddataStaff(query);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFood f = new fFood();
            this.Hide();
            f.ShowDialog();
        }

        private void fStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFilm f = new fFilm();
            this.Hide();
            f.ShowDialog();
        }
    }
}
