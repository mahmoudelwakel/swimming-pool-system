using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Swimming_Pool.BL
{
    class Distribution
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

        public DataTable Genstdnametodistribution(int School_id,string day, TimeSpan from, TimeSpan to,string proid)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@School_id", SqlDbType.Int);
            param[0].Value = School_id;
            param[1] = new SqlParameter("@day", SqlDbType.NVarChar,50);
            param[1].Value = day;
            param[2] = new SqlParameter("@from", SqlDbType.Time);
            param[2].Value = from;
            param[3] = new SqlParameter("@to", SqlDbType.Time);
            param[3].Value = to;
            param[4] = new SqlParameter("@proid", SqlDbType.NVarChar,50);
            param[4].Value = proid;

            DataTable dt = new DataTable();
            dt = dal.SelectData("Genstdnametodistribution", param);
            dal.Close();
            return dt;

        }
        //Getstdbyclass

        public DataTable Getstdbyclass(string day, TimeSpan from, TimeSpan to,string proid)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@day", SqlDbType.NVarChar, 50);
            param[0].Value = day;
            param[1] = new SqlParameter("@from", SqlDbType.Time);
            param[1].Value = from;
            param[2] = new SqlParameter("@to", SqlDbType.Time);
            param[2].Value = to;
            param[3] = new SqlParameter("@proid", SqlDbType.NVarChar,50);
            param[3].Value = proid;
            DataTable dt = new DataTable();
            dt = dal.SelectData("Getstdbyclass", param);
            dal.Close();
            return dt;

        }
        /*create proc Add_distribution
@Sch_id int,
@day nvarchar(50),
@From time,
@To time,
@Std_id int,
@Class nvarchar(50)
as*/
        public void Add_distribution(int Sch_id, string day, TimeSpan From, TimeSpan To, int Std_id, string Class,string proid)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Sch_id", SqlDbType.Int);
            param[0].Value = Sch_id;
            param[1] = new SqlParameter("@day", SqlDbType.NVarChar,50);
            param[1].Value = day;
            param[2] = new SqlParameter("@From", SqlDbType.Time);
            param[2].Value = From;
            param[3] = new SqlParameter("@To", SqlDbType.Time);
            param[3].Value = To;
            param[4] = new SqlParameter("@Std_id", SqlDbType.Int);
            param[4].Value = Std_id;
            param[5] = new SqlParameter("@Class", SqlDbType.NVarChar, 50);
            param[5].Value = Class;
            param[6] = new SqlParameter("@proid", SqlDbType.NVarChar, 50);
            param[6].Value = proid;

            dal.ExecuteCommand("Add_distribution", param);
            dal.Close();
        }
        //Edit_distribution
        public void Edit_distribution(int Sch_id, string day, TimeSpan From, TimeSpan To, int Std_id, string Class,string proid,int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@Sch_id", SqlDbType.Int);
            param[0].Value = Sch_id;
            param[1] = new SqlParameter("@day", SqlDbType.NVarChar, 50);
            param[1].Value = day;
            param[2] = new SqlParameter("@From", SqlDbType.Time);
            param[2].Value = From;
            param[3] = new SqlParameter("@To", SqlDbType.Time);
            param[3].Value = To;
            param[4] = new SqlParameter("@Std_id", SqlDbType.Int);
            param[4].Value = Std_id;
            param[5] = new SqlParameter("@Class", SqlDbType.NVarChar, 50);
            param[5].Value = Class;
            param[6] = new SqlParameter("@proid", SqlDbType.NVarChar, 50);
            param[6].Value = proid;
            param[7] = new SqlParameter("@id", SqlDbType.Int);
            param[7].Value = id;

            dal.ExecuteCommand("Edit_distribution", param);
            dal.Close();
        }
        //Get_describtion
        public DataTable Get_describtion()
        {
            dal.Open();
            DataTable dt = dal.SelectData("Get_describtion", null);
            dal.Close();
            return dt;
        }
        //Delete_discribtion
        public void Delete_discribtion(int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = @id;
            dal.ExecuteCommand("Delete_discribtion", param);
            dal.Close();
        }
        //[Search_discribtion]
        public DataTable Search_discribtion(string id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = @id;
            DataTable dt = dal.SelectData("Search_discribtion", param);
            dal.Close();
            return dt;
        }
        //Getstdclassbyname
        public DataTable Getstdclassbyname(int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = @id;
            DataTable dt = dal.SelectData("Getstdclassbyname", param);
            dal.Close();
            return dt;

        }
        //Getstdbyclassfromsubscribtion
        public DataTable Getstdbyclassfromsubscribtion(string day, TimeSpan from, TimeSpan to, string proid)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@day", SqlDbType.NVarChar, 50);
            param[0].Value = day;
            param[1] = new SqlParameter("@from", SqlDbType.Time);
            param[1].Value = from;
            param[2] = new SqlParameter("@to", SqlDbType.Time);
            param[2].Value = to;
            param[3] = new SqlParameter("@proid", SqlDbType.NVarChar, 50);
            param[3].Value = proid;
            DataTable dt = new DataTable();
            dt = dal.SelectData("Getstdbyclassfromsubscribtion", param);
            dal.Close();
            return dt;

        }
    }
}
