using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Swimming_Pool.BL
{
    
    class LogIn
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public DataTable Login(String User_Name, String Password)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@User_Name", SqlDbType.VarChar, 50);
            param[0].Value = @User_Name;
            param[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[1].Value = @Password;
            DataTable dt = new DataTable();
            dt = dal.SelectData("Login", param);
            dal.Close();
            return dt;

        }
        //Change_Password
        public void Change_Password(String username, String oldpass, String newpass)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
            param[0].Value = username;
            param[1] = new SqlParameter("@oldpass", SqlDbType.NVarChar,50);
            param[1].Value = oldpass;
            param[2] = new SqlParameter("@newpass", SqlDbType.NVarChar,50);
            param[2].Value = newpass;
            dal.ExecuteCommand("Change_Password", param);
            dal.Close();
        }
        //check_userandpass
        public DataTable check_userandpass(String username, String oldpass)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
            param[0].Value = username;
            param[1] = new SqlParameter("@oldpass", SqlDbType.NVarChar, 50);
            param[1].Value = oldpass;
            DataTable dt = new DataTable();
            dt = dal.SelectData("check_userandpass", param);
            dal.Close();
            return dt;

        }
    }
}
