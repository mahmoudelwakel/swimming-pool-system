using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Swimming_Pool.BL
{
    class Subscribtion_Form
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        //Add_Subscribtion
        /*
         * @Std_id int,
@School_id int,
@Total money,
@Paid money,
@Remain money,
@Part_month nvarchar(50),
@day nvarchar(50),
@From time(7),
@To time(7)
as
         */
        public void Add_Subscribtion(int Std_id, int School_id, String Total, String Paid, String Remain,String Part_month, String day, TimeSpan From, TimeSpan To,DateTime date,string clas,string proid)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@Std_id", SqlDbType.Int);
            param[0].Value = Std_id;
            param[1] = new SqlParameter("@School_id", SqlDbType.Int);
            param[1].Value = School_id;
            param[2] = new SqlParameter("@Total", SqlDbType.NVarChar, 50);
            param[2].Value = Total;
            param[3] = new SqlParameter("@Paid", SqlDbType.NVarChar,50);
            param[3].Value = Paid;
            param[4] = new SqlParameter("@Remain", SqlDbType.NVarChar,50);
            param[4].Value = Remain;
            param[5] = new SqlParameter("@Part_month", SqlDbType.NVarChar, 50);
            param[5].Value = Part_month;
            param[6] = new SqlParameter("@day", SqlDbType.NVarChar,50);
            param[6].Value = day;
            param[7] = new SqlParameter("@From", SqlDbType.Time);
            param[7].Value = From;
            param[8] = new SqlParameter("@To",SqlDbType.Time);
            param[8].Value = To;
            param[9] = new SqlParameter("@date", SqlDbType.DateTime);
            param[9].Value = date;
            param[10] = new SqlParameter("@clas", SqlDbType.NVarChar, 50);
            param[10].Value = clas;
            param[11] = new SqlParameter("@proid", SqlDbType.NVarChar, 50);
            param[11].Value = proid;
            dal.ExecuteCommand("Add_Subscribtion", param);
            dal.Close();
        }
        //Edit_Subscribtion
        public void Edit_Subscribtion(int Std_id, int School_id, String Total, String Paid, String Remain, String Part_month, String day, TimeSpan From, TimeSpan To,DateTime date,string clas,string proid,int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[13];
            param[0] = new SqlParameter("@Std_id", SqlDbType.Int);
            param[0].Value = Std_id;
            param[1] = new SqlParameter("@School_id", SqlDbType.Int);
            param[1].Value = School_id;
            param[2] = new SqlParameter("@Total", SqlDbType.NVarChar, 50);
            param[2].Value = Total;
            param[3] = new SqlParameter("@Paid", SqlDbType.NVarChar, 50);
            param[3].Value = Paid;
            param[4] = new SqlParameter("@Remain", SqlDbType.NVarChar, 50);
            param[4].Value = Remain;
            param[5] = new SqlParameter("@Part_month", SqlDbType.NVarChar, 50);
            param[5].Value = Part_month;
            param[6] = new SqlParameter("@day", SqlDbType.NVarChar, 50);
            param[6].Value = day;
            param[7] = new SqlParameter("@From", SqlDbType.Time);
            param[7].Value = From;
            param[8] = new SqlParameter("@To", SqlDbType.Time);
            param[8].Value = To;
            param[9] = new SqlParameter("@date", SqlDbType.DateTime);
            param[9].Value = date;
            param[10] = new SqlParameter("@clas", SqlDbType.NVarChar, 50);
            param[10].Value = clas;
            param[11] = new SqlParameter("@proid", SqlDbType.NVarChar, 50);
            param[11].Value = proid;
            param[12] = new SqlParameter("@id", SqlDbType.Int);
            param[12].Value = id;
            dal.ExecuteCommand("Edit_Subscribtion", param);
            dal.Close();
        }
        //Get_Subscribtion
        public DataTable Get_Subscribtion()
        {
            dal.Open();
            DataTable dt = dal.SelectData("Get_Subscribtion", null);
            dal.Close();
            return dt;
        }
        //Search_Subscribtion
        public DataTable Search_Subscribtion(string id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = @id;
            DataTable dt = dal.SelectData("Search_Subscribtion", param);
            dal.Close();
            return dt;
        }
        //Delete_Subscribtion
        public void Delete_Subscribtion(int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = @id;
            dal.ExecuteCommand("Delete_Subscribtion", param);
            dal.Close();
        }
        //Get_Student_remainmoney
        public DataTable Get_Student_remainmoney(string total,string month,int year,int sch_id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@total", SqlDbType.Money);
            param[0].Value = total;
            param[1] = new SqlParameter("@month", SqlDbType.NVarChar,50);
            param[1].Value = month;
            param[2] = new SqlParameter("@year", SqlDbType.Int);
            param[2].Value = year;
            param[3] = new SqlParameter("@sch_id", SqlDbType.Int);
            param[3].Value = sch_id;
            DataTable dt = dal.SelectData("Get_Student_remainmoney", param);
            dal.Close();
            return dt;
        }
        //Get_Remain
        public DataTable Get_Remain(int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = dal.SelectData("Get_Remain", param);
            dal.Close();
            return dt;
        }
        //Getcountclass
        public DataTable Getcountclass(string clas,TimeSpan from,TimeSpan to,string day,string proid)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@clas", SqlDbType.NVarChar,50);
            param[0].Value = clas;
            param[1] = new SqlParameter("@from", SqlDbType.Time);
            param[1].Value = from;
            param[2] = new SqlParameter("@to", SqlDbType.Time);
            param[2].Value = to;
            param[3] = new SqlParameter("@day", SqlDbType.NVarChar, 50);
            param[3].Value = day;
            param[4] = new SqlParameter("@proid", SqlDbType.NVarChar, 50);
            param[4].Value = proid;
            DataTable dt = dal.SelectData("Getcountclass", param);
            dal.Close();
            return dt;
        }
    }
}
