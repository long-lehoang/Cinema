using Cinema.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class fFilm : Form
    {
        string videolocation = "";//save url video

        string query = "select * from [VIEW_film]";
        public fFilm()
        {
            InitializeComponent();

            loaddataFilm(query);
        }

        void loaddataFilm(string query)
        {
            try
            {
                dtgvFilm.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            this.Hide();
            f.ShowDialog();
        }

        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFood f = new fFood();
            this.Hide();
            f.ShowDialog();
        }

        private void fFilm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnupload_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "mp4 files(*.mp4)|*.mp4| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    videolocation = dialog.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "" || txtlength.Text == "" || txtproducer.Text == "" ||
               txtlanguage.Text == "" || txtopening_day.Text == "" || txtview_estimation.Text == "" ||
               txtactor.Text == "" || txtintroduce.Text == "" || txtcategory.Text == "" )
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string name = "'" + txtname.Text + "',";
                    string length =  txtlength.Text + ",";
                    string producer = "'" + txtproducer.Text + "',";
                    string opening_day = "'" + txtopening_day.Text + "',";
                    string introduce = "'" + txtintroduce.Text + "',";
                    string trailer = "'" + videolocation + "',";
                    string category = "'" + txtcategory.Text + "',";
                    string language = "'" + txtlanguage.Text + "',";
                    string view_estimation = "'" + txtview_estimation.Text + "',";
                    string actor = "'" + txtactor.Text + "'";

                    query = "exec add_film " + name + length + producer + opening_day + introduce + trailer + category + language + view_estimation + actor ;

                    loaddataFilm(query);
                    query = "select * from [VIEW_film]";
                    loaddataFilm(query);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            query = "select * from [VIEW_film]";
            loaddataFilm(query);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            query = "select * from [VIEW_film] where name = '" + txtsearch.Text + "'";

            loaddataFilm(query);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "" || txtlength.Text == "" || txtproducer.Text == "" ||
               txtlanguage.Text == "" || txtopening_day.Text == "" || txtview_estimation.Text == "" ||
               txtactor.Text == "" || txtintroduce.Text == "" || txtcategory.Text == "")
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string name = "'" + txtname.Text + "',";
                    string length = txtlength.Text + ",";
                    string producer = "'" + txtproducer.Text + "',";
                    string opening_day = "'" + txtopening_day.Text + "',";
                    string introduce = "'" + txtintroduce.Text + "',";
                    string trailer = "'" + videolocation + "',";
                    string category = "'" + txtcategory.Text + "',";
                    string language = "'" + txtlanguage.Text + "',";
                    string view_estimation = "'" + txtview_estimation.Text + "',";
                    string actor = "'" + txtactor.Text + "'";

                    query = "exec update_film " + name + length + producer + opening_day + introduce + trailer + category + language + view_estimation + actor;

                    loaddataFilm(query);
                    query = "select * from [VIEW_film]";
                    loaddataFilm(query);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            query = "exec delete_film '" + txtdelete.Text + "'";

            loaddataFilm(query);
            query = "select * from [VIEW_film]";
            loaddataFilm(query);
            loaddataFilm(query);
        }
    }
}
