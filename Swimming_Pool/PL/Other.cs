using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swimming_Pool.PL
{
    public partial class Other : Form
    {
        BL.Other other = new BL.Other();
        int ID;
        public Other()
        {
            InitializeComponent();
            dataGridView1.DataSource = other.Get_Other();
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Home frm = new Home();
            frm.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (name.Text == String.Empty || price.Text == String.Empty || count.Text == String.Empty || date.Text == String.Empty || total.Text == String.Empty )
            {
                MessageBox.Show("من فضلك ادخل جميع البيانات");
                return;
            }
            else
            {
                other.Add_Other(name.Text, Convert.ToInt32(count.Text), price.Text,total.Text, date.Value);
                MessageBox.Show("تم اضافة البيانات بنجاح");
                
                count.Clear();
                price.Clear();
                total.Clear();
                
                dataGridView1.DataSource = other.Get_Other();
                //code to put serial number in datagridview
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            count.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            total.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            date.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            add.Visible = false;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (name.Text == String.Empty || price.Text == String.Empty || count.Text == String.Empty || date.Text == String.Empty || total.Text == String.Empty)
            {
                MessageBox.Show("من فضلك ادخل جميع البيانات");
                return;
            }
            else
            {
                other.Edit_Other(name.Text, Convert.ToInt32(count.Text), price.Text, total.Text, date.Value,ID);
                MessageBox.Show("تم تعديل البيانات بنجاح");
                add.Visible = true;
                count.Clear();
                price.Clear();
                total.Clear();

                dataGridView1.DataSource = other.Get_Other();
                //code to put serial number in datagridview
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == String.Empty)
            {
                dataGridView1.DataSource = other.Get_Other();
                //code to put serial number in datagridview
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
                return;
            }
            else
            {
                dataGridView1.DataSource = other.Search_Other(search.Text);
                //code to put serial number in datagridview
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("هل تريد عملية الحذف؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                other.Delete_Other(ID);
                MessageBox.Show("تمت عملية الحذف بنجاح");
                dataGridView1.DataSource = other.Get_Other();
                //code to put serial number in datagridview
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
                add.Visible = true;
                count.Clear();
                price.Text="";
                total.Clear();
            }
            else
            {
                
                add.Visible = true;
                //code to put serial number in datagridview
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
                count.Clear();
                price.Clear();
                total.Clear();
                return;
            }
        }

      


        private void name_SelectedValueChanged(object sender, EventArgs e)
        {
            if (name.Text != "فترات حره")
            {
                count.Text = 0 + "";
                count.Enabled = false;
            }
            else
            {
                count.Text ="";
                count.Enabled = true;
            }
        }

        private void count_TextChanged(object sender, EventArgs e)
        {
         
               
           
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            if(name.Text== "فترات حره")
            {
                try
                {
                    total.Text = (Convert.ToInt32(count.Text) * Convert.ToInt32(price.Text)).ToString();
                }
                catch  { }
            }
            else
            {
                try
                {
                    total.Text = (Convert.ToInt32(count.Text) + Convert.ToInt32(price.Text)).ToString();
                }
                catch { }
            }
        }

        private void Other_Load(object sender, EventArgs e)
        {
            //code to put serial number in datagridview
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                row.Height = 25;
            }
        }
    }
}
