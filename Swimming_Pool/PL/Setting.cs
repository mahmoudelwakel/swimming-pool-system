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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.Server;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Home frm = new Home();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = textBox1.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Success Save", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
