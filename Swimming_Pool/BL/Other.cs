using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Swimming_Pool.BL
{
    class Other
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        //Add_Other
        public void Add_Other(String Name, int Number, String Price,string Total, DateTime Date)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = @Name;
            param[1] = new SqlParameter("@Number", SqlDbType.Int);
            param[1].Value = @Number;
            param[2] = new SqlParameter("@Price", SqlDbType.Money);
            param[2].Value = @Price;
            param[3] = new SqlParameter("@Total", SqlDbType.Money);
            param[3].Value = @Total;
            param[4] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[4].Value = @Date;
           
            dal.ExecuteCommand("Add_Other", param);
            dal.Close();
        }
        //Edit_Other
        public void Edit_Other(String Name, int Number, String Price, String Total, DateTime Date,int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = @Name;
            param[1] = new SqlParameter("@Number", SqlDbType.Int);
            param[1].Value = @Number;
            param[2] = new SqlParameter("@Price", SqlDbType.Money);
            param[2].Value = @Price;
            param[3] = new SqlParameter("@Total", SqlDbType.Money);
            param[3].Value = @Total;
            param[4] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[4].Value = @Date;
            param[5] = new SqlParameter("@id", SqlDbType.Int);
            param[5].Value = @id;
            dal.ExecuteCommand("Edit_Other", param);
            dal.Close();
        }
        //Get_Other
        public DataTable Get_Other()
        {
            dal.Open();
            DataTable dt = dal.SelectData("Get_Other", null);
            dal.Close();
            return dt;
        }

        //Search_Other
        public DataTable Search_Other(string id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = @id;
            DataTable dt = dal.SelectData("Search_Other", param);
            dal.Close();
            return dt;
        }
        //Delete_Other
        public void Delete_Other(int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = @id;
            dal.ExecuteCommand("Delete_Other", param);
            dal.Close();
        }
    }
}
