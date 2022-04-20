using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Swimming_Pool.BL
{
    class Attendance
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public DataTable Getstudnametoattendance(int id, TimeSpan from,TimeSpan to,string proid,string day)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@from", SqlDbType.Time);
            param[1].Value = from;
            param[2] = new SqlParameter("@to", SqlDbType.Time);
            param[2].Value = to;
            param[3] = new SqlParameter("@proid", SqlDbType.NVarChar,50);
            param[3].Value = proid;
            param[4] = new SqlParameter("@day", SqlDbType.NVarChar, 50);
            param[4].Value = day;
            DataTable dt = new DataTable();
            dt = dal.SelectData("Getstudnametoattendance", param);
            dal.Close();
            return dt;

        }

        //Add_Attendance
       /* @status nvarchar(50),
@schoolname nvarchar(50),
@From time,
@To time,
@proid nvarchar(50),
@Name nvarchar(50),
@Date datetime*/
        public void Add_Attendance(string status, string schoolname, TimeSpan From, TimeSpan To, string proid, string Name, DateTime Date)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@status", SqlDbType.NVarChar,50);
            param[0].Value = status;
            param[1] = new SqlParameter("@schoolname", SqlDbType.NVarChar,50);
            param[1].Value = schoolname;
            param[2] = new SqlParameter("@From", SqlDbType.Time);
            param[2].Value = From;
            param[3] = new SqlParameter("@To", SqlDbType.Time);
            param[3].Value = To;
            param[4] = new SqlParameter("@proid", SqlDbType.NVarChar, 50);
            param[4].Value = proid;
            param[5] = new SqlParameter("@Name", SqlDbType.NVarChar,50);
            param[5].Value = Name;
            param[6] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[6].Value = Date;
         

            dal.ExecuteCommand("Add_Attendance", param);
            dal.Close();
        }
        //Edit_Attendance
        public void Edit_Attendance(int Sub_id, TimeSpan From, TimeSpan To, string Name, string Attendace, DateTime Date,int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Sub_id", SqlDbType.Int);
            param[0].Value = Sub_id;
            param[1] = new SqlParameter("@From", SqlDbType.Time);
            param[1].Value = From;
            param[2] = new SqlParameter("@To", SqlDbType.Time);
            param[2].Value = To;
            param[3] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[3].Value = Name;
            param[4] = new SqlParameter("@Attendace", SqlDbType.NVarChar, 50);
            param[4].Value = Attendace;
            param[5] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[5].Value = Date;
            param[6] = new SqlParameter("@id", SqlDbType.Int);
            param[6].Value = id;

            dal.ExecuteCommand("Edit_Attendance", param);
            dal.Close();
        }
        //Get_Attendance
        public DataTable Get_Attendance()
        {
            dal.Open();
            DataTable dt = dal.SelectData("Get_Attendance", null);
            dal.Close();
            return dt;
        }
        //Delete_Attendance
        public void Delete_Attendance(int id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = @id;
            dal.ExecuteCommand("Delete_Attendance", param);
            dal.Close();
        }
        //[Search_Attendance]
        public DataTable Search_Attendance(string id)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = @id;
            DataTable dt = dal.SelectData("Search_Attendance", param);
            dal.Close();
            return dt;
        }
    }

}
