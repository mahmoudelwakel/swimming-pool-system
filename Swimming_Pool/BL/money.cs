using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Swimming_Pool.BL
{
    class money
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        //get_paid_insubscribtion
        public DataTable get_paid_insubscribtion(int month,int year)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@month", SqlDbType.Int);
            param[0].Value = month;
            param[1] = new SqlParameter("@year", SqlDbType.Int);
            param[1].Value = year;
            DataTable dt = dal.SelectData("get_paid_insubscribtion", param);
            dal.Close();
            return dt;
        }
        //get_yearlypaid_insubscribtion
        public DataTable get_yearlypaid_insubscribtion( int year)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@year", SqlDbType.Int);
            param[0].Value = year;
            DataTable dt = dal.SelectData("get_yearlypaid_insubscribtion", param);
            dal.Close();
            return dt;
        }
        //getothermoney
        public DataTable getothermoney(int month, int year)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@month", SqlDbType.Int);
            param[0].Value = month;
            param[1] = new SqlParameter("@year", SqlDbType.Int);
            param[1].Value = year;
            DataTable dt = dal.SelectData("getothermoney", param);
            dal.Close();
            return dt;
        }
        //[getyearlyothermoney]
        public DataTable getyearlyothermoney(int year)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
          
            param[0] = new SqlParameter("@year", SqlDbType.Int);
            param[0].Value = year;
            DataTable dt = dal.SelectData("getyearlyothermoney", param);
            dal.Close();
            return dt;
        }
        //getothermoneyusingotherseling
        public DataTable getothermoneyusingotherseling(int month, int year)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@month", SqlDbType.Int);
            param[0].Value = month;
            param[1] = new SqlParameter("@year", SqlDbType.Int);
            param[1].Value = year;
            DataTable dt = dal.SelectData("getothermoneyusingotherseling", param);
            dal.Close();
            return dt;
        }
        //getyearlyothermoneyusingotherseling
        public DataTable getyearlyothermoneyusingotherseling(int year)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            
            param[0] = new SqlParameter("@year", SqlDbType.Int);
            param[0].Value = year;
            DataTable dt = dal.SelectData("getyearlyothermoneyusingotherseling", param);
            dal.Close();
            return dt;
        }
        //getothermoneyusingootherplays
        public DataTable getothermoneyusingootherplays(int month, int year)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@month", SqlDbType.Int);
            param[0].Value = month;
            param[1] = new SqlParameter("@year", SqlDbType.Int);
            param[1].Value = year;
            DataTable dt = dal.SelectData("getothermoneyusingootherplays", param);
            dal.Close();
            return dt;
        }
        //getyearlyothermoneyusingootherplays
        public DataTable getyearlyothermoneyusingootherplays(int year)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
          
            param[0] = new SqlParameter("@year", SqlDbType.Int);
            param[0].Value = year;
            DataTable dt = dal.SelectData("getyearlyothermoneyusingootherplays", param);
            dal.Close();
            return dt;
        }
    }
}
