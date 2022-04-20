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
    public partial class Subscribtion_Form: Form
    {
        BL.Registration_Form reg = new BL.Registration_Form();
        BL.Schools sch = new BL.Schools();
        BL.Subscribtion_Form sub = new BL.Subscribtion_Form();
        int ID;
        public Subscribtion_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = sub.Get_Subscribtion();
            //code to put serial number in datagridview
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                row.Height = 25;
            }
            dataGridView1.Columns[0].Visible = false;
            
            comboBox1.DisplayMember = "اسم المتدرب";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = reg.Get_Student();
            comboBox2.DataSource = sch.Get_School();
            comboBox2.DisplayMember = "الاسم";
            comboBox2.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Home frm = new Home();
            frm.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = sub.Get_Remain(Convert.ToInt32(comboBox1.SelectedValue));
            if (dt.Rows.Count <1)
            {
                total.Text = "";
            }else
            {
                total.Text = dt.Rows[0]["Remain"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if (paid.Text == String.Empty || listBox1.SelectedItems == null || listBox1.SelectedItems.Count == 0 || total.Text == String.Empty || remain.Text == String.Empty||from.Text==String.Empty||to.Text==String.Empty||clas.Text==String.Empty||proid.Text==String.Empty)
            {
                MessageBox.Show("ادخل جميع البيانات");
                return;
            }
            //used listbox
            String type = "";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                type += listBox1.SelectedItems[i] + ",";

            }
            DataTable dt = sub.Getcountclass(clas.Text, TimeSpan.Parse(from.Text), TimeSpan.Parse(to.Text), type, proid.Text);
            //check number of student in class
            int numberclass = Convert.ToInt32(dt.Rows[0][0]);
            if (numberclass >= 10)
            {
                MessageBox.Show("المستوي مكتمل من فضلك ادخل مستوي اخر");
                clas.Clear();
                clas.Focus();
                return;
            }
            //add Subscribtion
           
                sub.Add_Subscribtion(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), total.Text, paid.Text, remain.Text, comboBox3.Text, type, TimeSpan.Parse(from.Text), TimeSpan.Parse(to.Text),date.Value,clas.Text,proid.Text);
          
            dataGridView1.DataSource = sub.Get_Subscribtion();
            //code to put serial number in datagridview
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                row.Height = 25;
            }
            MessageBox.Show("تم تسديد " );
            total.Clear();
          //  paid.Text="";
            remain.Clear();
            
            clas.Clear();
            listBox1.ClearSelected();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            total.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            paid.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            remain.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            from.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            to.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    date.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            clas.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            proid.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            button2.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (paid.Text == String.Empty || listBox1.SelectedItems == null || listBox1.SelectedItems.Count == 0 || total.Text == String.Empty || remain.Text == String.Empty || from.Text == String.Empty || to.Text == String.Empty||clas.Text==String.Empty || proid.Text == String.Empty)
            {
                MessageBox.Show("ادخل جميع البيانات");
                return;
            }
            String type = "";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                type += listBox1.SelectedItems[i] + ",";

            }
            
                sub.Edit_Subscribtion(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), total.Text, paid.Text, remain.Text, comboBox3.Text, type, TimeSpan.Parse(from.Text), TimeSpan.Parse(to.Text),date.Value,clas.Text,proid.Text,ID);
          
           
            dataGridView1.DataSource = sub.Get_Subscribtion();

            MessageBox.Show("تم تعديل البيانات ");
            //code to put serial number in datagridview
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                row.Height = 25;
            }
            button2.Visible = true;
            try
            {
                total.Clear();
                paid.Text = "";
                remain.Clear();
               
                clas.Clear();
                listBox1.ClearSelected();
            }
            catch { }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == String.Empty)
            {
                dataGridView1.DataSource = sub.Get_Subscribtion();
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
                dataGridView1.DataSource = sub.Search_Subscribtion(search.Text);
                //code to put serial number in datagridview
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("هل تريد عملية الحذف؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sub.Delete_Subscribtion(ID);
                MessageBox.Show("تمت عملية الحذف بنجاح");
                dataGridView1.DataSource = sub.Get_Subscribtion();
                //code to put serial number in datagridview
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
                try
                {
                    button2.Visible = true;
                    total.Clear();
                    paid.Text = "";
                    remain.Clear();
                   
                    clas.Clear();
                }
                catch { }
            }
            else
            {
                try
                {
                    button2.Visible = true;
                    total.Clear();
                    paid.Text = "";
                    remain.Clear();
                  
                    clas.Clear();
                    return;
                }
                catch { }
            }
        }

        private void paid_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    remain.Text = (Convert.ToInt32(total.Text) - Convert.ToInt32(paid.Text)).ToString();
            //}
            //catch { }
            try
            {
                double x = Convert.ToDouble(total.Text);
                remain.Text = (x - Convert.ToDouble(paid.Text)).ToString();
            }
            catch { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Subscribtion_Form_Load(object sender, EventArgs e)
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
