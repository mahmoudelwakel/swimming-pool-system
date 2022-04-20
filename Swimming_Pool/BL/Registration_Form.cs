using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Swimming_Pool.BL
{
    class Registration_Form
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        //Add_Student
        public void Add_Student(String Name, String Mobile,String Address ,DateTime Birth_Date,int Age_day, int Age_month, int Age_year)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 200);
            param[0].Value = @Name;
            param[1] = new SqlParameter("@Mobile", SqlDbType.NVarChar,50);
            param[1].Value = @Mobile;
            param[2] = new SqlParameter("@Address", SqlDbType.NVarChar,200);
            param[2].Value = @Address;
            param[3] = new SqlParameter("@Birth_Date", SqlDbType.DateTime);
            param[3].Value = @Birth_Date;
            param[4] = new SqlParameter("@Age_day", SqlDbType.Int);
            param[4].Value = @Age_day;
            param[5] = new SqlParameter("@Age_month", SqlDbType.Int);
            param[5].Value = @Age_month;
            param[6] = new SqlParameter("@Age_year", SqlDbType.Int);
            param[6].Value = @Age_year;
            dal.ExecuteCommand("Add_Student", param);
            dal.Close();
        }
        //Edit_Sutdent
        public void Edit_Sutdent(String Name, String Mobile, String Address, DateTime Birth_Date, int Age_day, int Age_month, int Age_year,int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 200);
            param[0].Value = @Name;
            param[1] = new SqlParameter("@Mobile", SqlDbType.NVarChar, 50);
            param[1].Value = @Mobile;
            param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, 200);
            param[2].Value = @Address;
            param[3] = new SqlParameter("@Birth_Date", SqlDbType.DateTime);
            param[3].Value = @Birth_Date;
            param[4] = new SqlParameter("@Age_day", SqlDbType.Int);
            param[4].Value = @Age_day;
            param[5] = new SqlParameter("@Age_month", SqlDbType.Int);
            param[5].Value = @Age_month;
            param[6] = new SqlParameter("@Age_year", SqlDbType.Int);
            param[6].Value = @Age_year;
            param[7] = new SqlParameter("@id", SqlDbType.Int);
            param[7].Value = @id;
            dal.ExecuteCommand("Edit_Sutdent", param);
            dal.Close();
        }
        //Get_Student
        public DataTable Get_Student()
        {
            dal.Open();
            DataTable dt = dal.SelectData("Get_Student", null);
            dal.Close();
            return dt;
        }
        //Search_Student
        public DataTable Search_Student(string id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = @id;
            DataTable dt = dal.SelectData("Search_Student", param);
            dal.Close();
            return dt;
        }
        //Delete_Student
        public void Delete_Student(int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = @id;
            dal.ExecuteCommand("Delete_Student", param);
            dal.Close();
        }
    }
}
