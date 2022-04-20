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
    public partial class Remain_money : Form
    {
        BL.Subscribtion_Form sub = new BL.Subscribtion_Form();
        BL.Schools sch = new BL.Schools();
        public Remain_money()
        {
            InitializeComponent();
            comboBox2.DataSource = sch.Get_School();
            comboBox2.DisplayMember = "الاسم";
            comboBox2.ValueMember = "id";
            year.Format = DateTimePickerFormat.Custom;
            year.CustomFormat = "yyyy";
            year.ShowUpDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Home frm = new Home();
            frm.Show();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || comboBox1.Text == String.Empty||comboBox2.Text == String.Empty)
            {
                MessageBox.Show("من فضلك ادخل جميع البيانات");
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
                dataGridView1.DataSource = sub.Get_Student_remainmoney(textBox1.Text, comboBox1.Text, Convert.ToInt32(year.Text),Convert.ToInt32(comboBox2.SelectedValue));
                //code to put serial number in datagridview
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Remain_money_Load(object sender, EventArgs e)
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
