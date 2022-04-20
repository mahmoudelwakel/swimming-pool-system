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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                this.Close();
                PL.Registration_Form frm = new Registration_Form();
                frm.Show();
            
          
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username == "admin")
            {
                this.Hide();
                PL.Subscribtion_Form frm = new Subscribtion_Form();
                frm.Show();
            }
            else
            {
                this.Focus();
                ((Button)sender).Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PL.Schools frm = new Schools();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Remain_money frm = new Remain_money();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            PL.Distribution frm = new Distribution();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Collection frm = new Collection();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            PL.Users frm = new Users();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username == "admin")
            {
                this.Close();
                PL.Other frm1 = new Other();
             
                frm1.Show();
            }
            else
            {
                this.Focus();
                ((Button)sender).Enabled = false;
            }
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PL.Backup frm = new Backup();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PL.Restore frm = new Restore();
            frm.Show();
        }

        private void money_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username == "admin")
            {
                this.Hide();
                PL.money frm = new PL.money();
                frm.Show();
            }
            else
            {
                this.Focus();
                ((Button)sender).Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الخروج من البرنامج ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
