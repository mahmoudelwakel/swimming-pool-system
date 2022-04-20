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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BL.LogIn login = new BL.LogIn();

            DataTable dt = login.Login(textBox1.Text, textBox2.Text);
          
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                 
                 
                    PL.Home frm = new Home();
                    frm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Failed");
                }
               
            }
            Properties.Settings.Default.username = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.Setting frm = new Setting();
            frm.Show();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BL.LogIn login = new BL.LogIn();

                DataTable dt = login.Login(textBox1.Text, textBox2.Text);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {

                    
                        PL.Home frm = new Home();
                        frm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                Properties.Settings.Default.username = textBox1.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
