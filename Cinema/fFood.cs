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
    public partial class fFood : Form
    {
        string query = "select * from Food with(index(indexname))";
        public fFood()
        {
            InitializeComponent();

            loaddataFood(query);
        }

        void loaddataFood(string query)
        {
            try
            {
                dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            this.Hide();
            f.ShowDialog();
            
        }
        //

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtamount.Text == "" || txtname.Text == "" || txtprice.Text == "" || txtexpire_date.Text == "")
                    MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string name ="'"+ txtname.Text +"',";
                    string amount =  txtamount.Text + ",";
                    string price = txtprice.Text + ",";
                    string expire_date = "'" + txtexpire_date.Text + "'";

                    query = "exec add_food " + name + amount + price + expire_date;
                    loaddataFood(query);

                    query = "select * from Food with(index(indexname))";
                    loaddataFood(query);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            query = "select * from Food with(index(indexname))";
            loaddataFood(query);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtamount.Text == "" || txtname.Text == "" || txtprice.Text == "" || txtexpire_date.Text == "")
                    MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string name = "'" + txtname.Text + "',";
                    string amount = txtamount.Text + ",";
                    string price = txtprice.Text + ",";
                    string expire_date = "'" + txtexpire_date.Text + "'";

                    query = "exec update_food " + name + amount + price + expire_date;
                    loaddataFood(query);

                    query = "select * from Food with(index(indexname))";
                    loaddataFood(query);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            query = "exec delete_food " + txtdelete.Text;
            loaddataFood(query);

            query = "select * from Food with(index(indexname))";
            loaddataFood(query);
        }

        private void fFood_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFilm f = new fFilm();
            this.Hide();
            f.ShowDialog();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            query = "select * from Food with(index(indexname)) where name = '" + txtsearchFood.Text + "'";
            loaddataFood(query);
        }
    }
}
