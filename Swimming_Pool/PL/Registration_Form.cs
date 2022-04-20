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
    public partial class Registration_Form : Form
    {
        BL.Registration_Form reg = new BL.Registration_Form();
        int ID;
        public Registration_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = reg.Get_Student();
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
            if (name.Text == String.Empty || mobile.Text == String.Empty || address.Text == String.Empty||date.Text == String.Empty|| day.Text == String.Empty|| month.Text == String.Empty|| year.Text == String.Empty)
            {
                MessageBox.Show("من فضلك ادخل جميع البيانات");
                return;
            }
            else
            {
                reg.Add_Student(name.Text, mobile.Text,address.Text,date.Value, Convert.ToInt32(day.Text), Convert.ToInt32(month.Text), Convert.ToInt32(year.Text));
                MessageBox.Show("تم اضافة البيانات بنجاح");
                name.Clear();
                mobile.Clear();
                address.Clear();
                day.Clear();
                month.Clear();
                year.Clear();
                dataGridView1.DataSource = reg.Get_Student();
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
            mobile.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            date.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            day.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            month.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            year.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            add.Visible = false;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            ID=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (name.Text == String.Empty || mobile.Text == String.Empty || address.Text == String.Empty || date.Text == String.Empty || day.Text == String.Empty || month.Text == String.Empty || year.Text == String.Empty)
            {
                MessageBox.Show("من فضلك ادخل جميع البيانات");
                return;
            }
            else
            {
                reg.Edit_Sutdent(name.Text, mobile.Text, address.Text, date.Value, Convert.ToInt32(day.Text), Convert.ToInt32(month.Text), Convert.ToInt32(year.Text),ID);
                MessageBox.Show("تم تعديل البيانات بنجاح");
                add.Visible = true;
                name.Clear();
                mobile.Clear();
                address.Clear();
                day.Clear();
                month.Clear();
                year.Clear();
                dataGridView1.DataSource = reg.Get_Student();
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
                dataGridView1.DataSource = reg.Get_Student();
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
                dataGridView1.DataSource = reg.Search_Student(search.Text);
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
                reg.Delete_Student(ID);
                MessageBox.Show("تمت عملية الحذف بنجاح");
                dataGridView1.DataSource = reg.Get_Student();
                //code to put serial number in datagridview
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
                add.Visible = true;
            }
            else
            {
                return;
                //code to put serial number in datagridview
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
            }
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int currentYear = DateTime.Now.Year;
                int currentMonth = DateTime.Now.Month;
                int currentDay = DateTime.Now.Day;
                DateTime date1 = date.Value;
                int kday = date1.Day;
                int kmonth = date1.Month;
                int kyear = date1.Year;
                if (kday > currentDay)
                {
                    currentDay += 30;
                    currentMonth -= 1;
                }
                if (kmonth > currentMonth)
                {
                    currentMonth += 12;
                    currentYear -= 1;
                }
                int td = currentDay - kday;
                int tm = currentMonth - kmonth;
                int ty = currentYear - kyear;
                //MessageBox.Show(td+"");
                day.Text = td.ToString();
                month.Text = tm.ToString();
                year.Text = ty.ToString();

         
            }
        }

        private void Registration_Form_Load(object sender, EventArgs e)
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
