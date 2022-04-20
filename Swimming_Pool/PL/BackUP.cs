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
    public partial class Backup : Form
    {

        SqlConnection con = new SqlConnection(@"server=.\SQLEXPRESS; DataBase=Swimming_Pool; Integrated Security = true ");
        SqlCommand cmd;
        public Backup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = textBox1.Text + "\\Swimming_Pool" + DateTime.Now.ToShortDateString().Replace('/', '-');

            string strQuery = "BackUp DataBase Swimming_Pool to Disk ='" + filename + ".back'";
            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم انشاء النسخه الاحتياطيه بنجاح", " انشاء النسخه الاحتياطيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
