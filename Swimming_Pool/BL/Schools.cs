using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Swimming_Pool.BL
{
    class Schools
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public void Add_School(String Name, String Cost,int Num_Of_Course)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = @Name;
            param[1] = new SqlParameter("@Cost", SqlDbType.Money);
            param[1].Value = @Cost;
            param[2] = new SqlParameter("@Num_Of_Course", SqlDbType.Int);
            param[2].Value = @Num_Of_Course;
            dal.ExecuteCommand("Add_School", param);
            dal.Close();
        }
        //Edit_School
        public void Edit_School(String Name, String Cost, int Num_Of_Course,int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = @Name;
            param[1] = new SqlParameter("@Cost", SqlDbType.Money);
            param[1].Value = @Cost;
            param[2] = new SqlParameter("@Num_Of_Course", SqlDbType.Int);
            param[2].Value = @Num_Of_Course;
            param[3] = new SqlParameter("@id", SqlDbType.Int);
            param[3].Value = @id;
            dal.ExecuteCommand("Edit_School", param);
            dal.Close();
        }
        //Get_School
        public DataTable Get_School()
        {
            dal.Open();
            DataTable dt = dal.SelectData("Get_School", null);
            dal.Close();
            return dt;
        }
        //Search_School
        public DataTable Search_School(string id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = @id;
            DataTable dt = dal.SelectData("Search_School", param);
            dal.Close();
            return dt;
        }
        //Delete_School
        public void Delete_School(int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = @id;
            dal.ExecuteCommand("Delete_School", param);
            dal.Close();
        }
    }
}
