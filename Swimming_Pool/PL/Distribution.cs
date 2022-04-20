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
    public partial class Distribution : Form
    {
        BL.Schools sch = new BL.Schools();
        BL.Distribution dis = new BL.Distribution();
      //  int ID;
        public Distribution()
        {
            InitializeComponent();
            //dataGridView1.DataSource = dis.Get_describtion();
            //dataGridView1.Columns[0].Visible = false;
            //comboBox1.DataSource = sch.Get_School();
            //comboBox1.DisplayMember = "الاسم";
            //comboBox1.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Home frm = new Home();
            frm.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            //if(comboBox1.Text==String.Empty|| comboBox2.Text == String.Empty|| comboBox3.Text == String.Empty|| from.Text == String.Empty|| to.Text == String.Empty|| txtclass.Text == String.Empty||proid.Text==String.Empty)
            //{
            //    MessageBox.Show("من فضلك ادخل جميع البيانات");
            //    return;
            //}
            //else
            //{
            //    dis.Add_distribution(Convert.ToInt32(comboBox1.SelectedValue), comboBox2.Text, TimeSpan.Parse(from.Text), TimeSpan.Parse(to.Text), Convert.ToInt32(comboBox3.SelectedValue), txtclass.Text,proid.Text);
            //    MessageBox.Show("تم حفظ جميع البيانات");
            //    dataGridView1.DataSource = dis.Get_describtion();
            //    txtclass.Clear();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //comboBox3.DataSource = dis.Genstdnametodistribution(Convert.ToInt32(comboBox1.SelectedValue), comboBox2.Text, TimeSpan.Parse(from.Text), TimeSpan.Parse(to.Text), proid.Text);
            //comboBox3.DisplayMember = "Name";
            //comboBox3.ValueMember = "id";
          

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //from.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //to.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //comboBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //txtclass.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //proid.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //from.Visible = false;
            //to.Visible = false;
            //comboBox1.Enabled = false;
            //comboBox2.Enabled = false;
            //add.Visible = false;

        }

        private void edit_Click(object sender, EventArgs e)
        {
            //ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //if (comboBox1.Text == String.Empty || comboBox2.Text == String.Empty || comboBox3.Text == String.Empty || from.Text == String.Empty || to.Text == String.Empty || txtclass.Text == String.Empty||proid.Text==String.Empty)
            //{
            //    MessageBox.Show("من فضلك ادخل جميع البيانات");
            //    return;
            //}
            //else
            //{
            //    dis.Edit_distribution(Convert.ToInt32(comboBox1.SelectedValue), comboBox2.Text, TimeSpan.Parse(from.Text), TimeSpan.Parse(to.Text), Convert.ToInt32(comboBox3.SelectedValue), txtclass.Text,proid.Text,ID);
            //    MessageBox.Show("تم تعديل جميع البيانات");
            //    from.Visible = false;
            //    to.Visible = false;
            //    comboBox1.Enabled = true;
            //    comboBox2.Enabled = true;
            //    dataGridView1.DataSource = dis.Get_describtion();
            //    add.Visible = true;
            //    txtclass.Clear();
            //}
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //if (MessageBox.Show("هل تريد عملية الحذف؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    dis.Delete_discribtion(ID);
            //    MessageBox.Show("تمت عملية الحذف بنجاح");
            //    dataGridView1.DataSource = dis.Get_describtion();
            //    add.Visible = true;
            //    txtclass.Clear();
                
            //    from.Visible = false;
            //    to.Visible = false;
            //    comboBox1.Enabled = true;
            //    comboBox2.Enabled = true;
            //}
            //else
            //{

            //    txtclass.Clear();
            //    from.Visible = false;
            //    to.Visible = false;
            //    comboBox1.Enabled = true;
            //    comboBox2.Enabled = true;
            //    add.Visible = true;
            //    return;
            //}
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            //if (search.Text == String.Empty)
            //{
            //    dataGridView1.DataSource = dis.Get_describtion();
            //    return;
            //}
            //else
            //{
            //    dataGridView1.DataSource = dis.Search_discribtion(search.Text);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (comboBox4.Text == String.Empty || rptfrom.Text == String.Empty || rptto.Text == String.Empty||rptproid.Text==String.Empty)
            //{
            //    MessageBox.Show("من فضلك ادخل جميع البيانات");
            //    return;
            //}
            //RPT.Getstdbyclass rep = new RPT.Getstdbyclass();
            //rep.SetDataSource(dis.Getstdbyclass(comboBox4.Text,TimeSpan.Parse(rptfrom.Text), TimeSpan.Parse(rptto.Text), rptproid.Text));
            //RPT.FormReport frm = new RPT.FormReport();
            //frm.crystalReportViewer1.ReportSource = rep;
            //frm.Show();
            //Getstdbyclassfromsubscribtion
            if (comboBox4.Text == String.Empty || rptfrom.Text == String.Empty || rptto.Text == String.Empty || rptproid.Text == String.Empty)
            {
                MessageBox.Show("من فضلك ادخل جميع البيانات");
                return;
            }
            RPT.Getstdbyclassfromsubscribtion rep = new RPT.Getstdbyclassfromsubscribtion();
            rep.SetDataSource(dis.Getstdbyclassfromsubscribtion(comboBox4.Text, TimeSpan.Parse(rptfrom.Text), TimeSpan.Parse(rptto.Text), rptproid.Text));
            RPT.FormReport frm = new RPT.FormReport();
            frm.crystalReportViewer1.ReportSource = rep;
            frm.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable dt = dis.Getstdclassbyname(Convert.ToInt32(comboBox3.SelectedValue));
               
            //    txtclass.Text = dt.Rows[0]["clas"].ToString();
            //}
            //catch { }

            // MessageBox.Show(dis.Getstdclassbyname(Convert.ToInt32(comboBox3.SelectedValue)).ToString());
            //txtclass.Text = dis.Getstdclassbyname(Convert.ToInt32(comboBox3.SelectedValue)).ToString();  
        }
    }
}
