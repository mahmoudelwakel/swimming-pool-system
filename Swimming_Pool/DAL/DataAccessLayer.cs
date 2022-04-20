using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimming_Pool.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlConnection;
        public DataAccessLayer()
        {
            sqlConnection = new SqlConnection(@"server=" + Properties.Settings.Default.Server + "; DataBase=Swimming_Pool; Integrated Security =true");

        }
        public void Open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public DataTable SelectData(string stored_prosedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_prosedure;
            sqlcmd.Connection = sqlConnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

        public void ExecuteCommand(string stored_prosedure, SqlParameter[] param)
        {
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.CommandText = stored_prosedure;
            SqlCmd.Connection = sqlConnection;
            if (param != null)
            {
                SqlCmd.Parameters.AddRange(param);
            }
            SqlCmd.ExecuteNonQuery();
        }

    }
}


