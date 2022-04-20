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
    public partial class money : Form
    {
        BL.money mon = new BL.money();
        public money()
        {
            InitializeComponent();
            year.Format = DateTimePickerFormat.Custom;
            year.CustomFormat = "yyyy";
            year.ShowUpDown = true;
        
            exyeardate.Format = DateTimePickerFormat.Custom;
            exyeardate.CustomFormat = "yyyy";
            exyeardate.ShowUpDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PL.Home frm = new Home();
            frm.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
      
            
            if (month.Text == String.Empty || year.Text == String.Empty)
            {
                MessageBox.Show("من فضلك ادخل جميع التفاصيل");
                return;
            }
            DataTable dt = mon.get_paid_insubscribtion(Convert.ToInt32(month.Text), Convert.ToInt32(year.Text));
            if (dt.Rows[0][0] != null)
            {
                trainer.Text = dt.Rows[0][0].ToString();
               


            }
            
            DataTable dt1 = mon.getothermoney(Convert.ToInt32(month.Text), Convert.ToInt32(year.Text));
            if (dt1.Rows[0][0] != null)
            {
                other.Text = dt1.Rows[0][0].ToString();
               

            }
          
            //   getothermoneyusingotherseling
            DataTable dt2 = mon.getothermoneyusingotherseling(Convert.ToInt32(month.Text), Convert.ToInt32(year.Text));
            if (dt2.Rows[0][0] != null)
            {
                othsel.Text = dt2.Rows[0][0].ToString();


            }
        
            //
            DataTable dt3 = mon.getothermoneyusingootherplays(Convert.ToInt32(month.Text), Convert.ToInt32(year.Text));
            if (dt3.Rows[0][0] != null)
            {
                othgame.Text = dt3.Rows[0][0].ToString();


            }

            double x = Convert.ToDouble(trainer.Text);
            double y = Convert.ToDouble(other.Text);
            double z = Convert.ToDouble(othsel.Text);
            double s = Convert.ToDouble(othgame.Text);
            total.Text = (x + y + z + s).ToString();

        }

        private void money_Load(object sender, EventArgs e)
        {

        }

        private void yearserach_Click(object sender, EventArgs e)
        {
            //المصاريف السنوية للمتدربين
            if (exyeardate.Text == String.Empty)
            {
                MessageBox.Show("من فضلك ادخل جميع التفاصيل");
                return;
            }
            DataTable dt = mon.get_yearlypaid_insubscribtion(Convert.ToInt32(exyeardate.Text));
            if (dt.Rows[0][0] != null)
            {
                yeartrainee.Text = dt.Rows[0][0].ToString();



            }
            //المصاريف السنوية للفترات الحره
            DataTable dt1 = mon.getyearlyothermoney( Convert.ToInt32(exyeardate.Text));
            if (dt1.Rows[0][0] != null)
            {
                yearfree.Text = dt1.Rows[0][0].ToString();


            }
            //المصاريف السنوية للمبيعات الحره
            DataTable dt2 = mon.getyearlyothermoneyusingotherseling(Convert.ToInt32(exyeardate.Text));
            if (dt2.Rows[0][0] != null)
            {
                yearsel.Text = dt2.Rows[0][0].ToString();


            }
            //المصاريف السنوية العاب اخري
            DataTable dt3 = mon.getyearlyothermoneyusingootherplays( Convert.ToInt32(exyeardate.Text));
            if (dt3.Rows[0][0] != null)
            {
                yearplay.Text = dt3.Rows[0][0].ToString();


            }
            double x1 = Convert.ToDouble(yeartrainee.Text);
            double y1 = Convert.ToDouble(yearfree.Text);
            double z1 = Convert.ToDouble(yearsel.Text);
            double s1 = Convert.ToDouble(yearplay.Text);
            yeartotal.Text = (x1 + y1 + z1 + s1).ToString();
        }

        private void year_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
