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
    public partial class Users : Form
    {
        BL.LogIn log = new BL.LogIn();
        public Users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.Home frm = new Home();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = log.check_userandpass(textBox1.Text, textBox2.Text);
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("تاكد من اسم المستخدم او كلمة المرور");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                return;
                
            }
            else
            {
                if(textBox1.Text==String.Empty|| textBox2.Text == String.Empty|| textBox3.Text == String.Empty)
                {
                    MessageBox.Show("من فضلك ادخل جميع البيانات");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    return;
                }
                log.Change_Password(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("تم تعديل كلمة المرور بنجاح");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }
    }
}
