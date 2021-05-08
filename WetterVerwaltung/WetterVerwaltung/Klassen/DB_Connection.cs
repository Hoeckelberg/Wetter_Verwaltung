using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows;

namespace WetterVerwaltung
{
    class DB_Connection
    {
        private string connectionString = "Data Source=localhost; Initial Catalog=DB_Wetter; Integrated Security=true;";
        private SqlDataAdapter sqlDA;
        private SqlConnection sqlCon;

        public DB_Connection()
        {
            sqlCon = new SqlConnection();
            sqlDA = new SqlDataAdapter();
            sqlCon.ConnectionString = connectionString;
        }

        public void OpenConnection()
        {
            try
            {
                sqlCon.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
        public void CloseConnection()
        {
            try
            {
                sqlCon.Close();
                sqlCon.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
        public void SetData(string qry)
        {
            sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = qry;
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
            sqlCon.Close();
        }
        public DataTable GetDataTable(string qry)
        {
            sqlCon.Open();
            using(DataTable dt = new DataTable())
            {
                SqlCommand sqlcmd = new SqlCommand()
                {
                    CommandText = qry,
                    Connection = sqlCon
                };
                sqlDA.SelectCommand = sqlcmd;
                sqlDA.Fill(dt);
                sqlCon.Close();
                return dt;
            }
        }
    }
}
