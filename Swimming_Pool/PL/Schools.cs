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
    public partial class Schools : Form
    {
        BL.Schools sch = new BL.Schools();
        int ID;
        public Schools()
        {
            InitializeComponent();
            dataGridView1.DataSource = sch.Get_School();
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Home frm = new Home();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(name.Text==String.Empty|| cost.Text == String.Empty || number.Text == String.Empty)
            {
                MessageBox.Show("من فضلك ادخل جميع البيانات");
                return;
            }
            else
            {
                sch.Add_School(name.Text, cost.Text, Convert.ToInt32(number.Text));
                MessageBox.Show("تم اضافة البيانات بنجاح");
                name.Clear();
                cost.Clear();
                number.Clear();
                dataGridView1.DataSource = sch.Get_School();
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
            cost.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            number.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            add.Visible = false;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            ID=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (name.Text == String.Empty || cost.Text == String.Empty || number.Text == String.Empty)
            {
                MessageBox.Show("من فضلك ادخل جميع البيانات");
                return;
            }
            else
            {
                sch.Edit_School(name.Text, cost.Text, Convert.ToInt32(number.Text),ID);
                MessageBox.Show("تم تعديل البيانات بنجاح");
                name.Clear();
                cost.Clear();
                number.Clear();
                dataGridView1.DataSource = sch.Get_School();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
                add.Visible = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == String.Empty)
            {
                dataGridView1.DataSource = sch.Get_School();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
                return;
            }else
            {
                dataGridView1.DataSource = sch.Search_School(search.Text);
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
                sch.Delete_School(ID);
                MessageBox.Show("تمت عملية الحذف بنجاح");
                dataGridView1.DataSource = sch.Get_School();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
            }
            else
            {
                return;
            }
        }

        private void Schools_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                row.Height = 25;
            }
        }
    }
}
