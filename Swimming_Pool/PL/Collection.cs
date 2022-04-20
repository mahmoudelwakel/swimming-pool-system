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
    public partial class Collection : Form
    {
        BL.Schools sch = new BL.Schools();
        BL.Attendance att = new BL.Attendance();
        int ID;
        public Collection()
        {
            InitializeComponent();
            //dataGridView1.DataSource = att.Get_Attendance();
           // dataGridView1.Columns[0].Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //if (comboBox2.Text == String.Empty || from.Text == String.Empty || to.Text == String.Empty || date.Text == String.Empty || comboBox1.Text == String.Empty || comboBox3.Text == String.Empty )
            //{
            //    MessageBox.Show("من فضلك ادخل جميع البيانات");
            //    return;
            //}
            //else
            //{
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                string check = "";
                string name = (dataGridView1.Rows[i].Cells[1].Value.ToString());
                string school = (dataGridView1.Rows[i].Cells[2].Value.ToString()); 
                string from=(dataGridView1.Rows[i].Cells[3].Value.ToString());
                string to = (dataGridView1.Rows[i].Cells[4].Value.ToString()); 
                string proid = (dataGridView1.Rows[i].Cells[5].Value.ToString()); 
              
              
                   bool serv =Convert.ToBoolean (dataGridView1.Rows[i].Cells[0].Value);
                if (serv)
                {
                    check = "حاضر";
                   
                }else
                {
                    check = "غائب";
          
                }
                att.Add_Attendance(check, school, TimeSpan.Parse(from), TimeSpan.Parse(to), proid, name, DateTime.Now);
              
                   
                }
                MessageBox.Show("تم اضافة البيانات بنجاح");
              
                
                //dataGridView1.DataSource = att.Get_Attendance();
           // }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Visible = true;
     
            if (comboBox2.Text==String.Empty|| from.Text == String.Empty || to.Text == String.Empty || proid.Text == String.Empty)
            {
                MessageBox.Show("من فضلك ادخل جميع البيانات");
                return;
            }
            try
            {
             
             
                dataGridView1.DataSource = att.Getstudnametoattendance(Convert.ToInt32(comboBox2.SelectedValue), TimeSpan.Parse(from.Text), TimeSpan.Parse(to.Text),proid.Text,comboday.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }

            }
            catch
            {
                MessageBox.Show("ادخل الوقت بالصيغة00:00  ");
                return;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //if (textBox4.Text == String.Empty)
            //{
            //    dataGridView1.DataSource = att.Get_Attendance();
            //    return;
            //}
            //else
            //{
            //    dataGridView1.DataSource = att.Search_Attendance(textBox4.Text);
            //}
        }

        private void Collection_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                row.Height = 25;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            
                if (txtsearch.Text == String.Empty)
                {
                    dataGridView1.DataSource = att.Get_Attendance();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
                return;
                }
                else
                {
                    dataGridView1.DataSource = att.Search_Attendance(txtsearch.Text);
                dataGridView1.Columns[0].Visible = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                    row.Height = 25;
                }
            }
            }
        }
}
