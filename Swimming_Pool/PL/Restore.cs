using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swimming_Pool.PL
{
    public partial class Restore : Form
    {
        SqlConnection con = new SqlConnection(@"server =.\SQLEXPRESS; DataBase=Swimming_Pool; Integrated Security = true ");
        SqlCommand cmd;
        public Restore()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = textBox1.Text + "\\Swimming_Pool" + DateTime.Now.ToShortDateString().Replace('/', '-');

            string strQuery = " Alter DataBase Swimming_Pool SET OFFLINE WITH ROLLBACK IMMEDIATE ;  Restore DataBase SchoolSystem From Disk='" + textBox1.Text + "'";
            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم استعادة النسخه الاحتياطيه بنجاح", " استعادة النسخه الاحتياطيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }
    }
}
