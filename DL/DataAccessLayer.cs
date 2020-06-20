using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DL
{
    public class DataAccessLayer
    {
        SqlConnection conn;
        public SqlCommand cmd;
        SqlDataAdapter Da;
        DataTable Dt;
        DataSet ds;
        string a;
        public void DataAccess()
        {
            conn = new SqlConnection();
            cmd = new SqlCommand();
            Da = new SqlDataAdapter();
            cmd.Connection = conn;
            Da.SelectCommand = cmd;
        }
        public void Connect() //method for connect to DB
        {
            conn.ConnectionString = @"Data Source=(local);Initial Catalog=Calorimeter;Integrated Security=True";
            conn.Open();
        }
        public void DisConnect()
        {
            conn.Close();
        }
        public DataTable Select(string Query) //method for select data
        {
            cmd.CommandText = Query;
            Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }
        public bool DoCommand(string query) //method for Insert,DeletUpdate
        {
            cmd.CommandText = query;
            int i = cmd.ExecuteNonQuery();

            if (i != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ExecuteSelect(string Query) //method for select data
        {
            cmd.CommandText = Query;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                a = dr[0].ToString();
            }
            return a;
        }

    }
}