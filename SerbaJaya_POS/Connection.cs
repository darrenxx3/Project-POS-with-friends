﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Connection
{
    public class Connection_Query
    {
        string ConnectionString =
            "Integrated Security=SSPI;" +
            "Persist Security Info=False;" +
            "Initial Catalog=UASVisprog ;" +
            "Data Source=LAPTOP-6ENO241Q\\SQLEXPRESS"; //Ubah Data Sourcenya aja Gan.

        SqlConnection conn;

        public void OpenConnection()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
        }

        public void CloseConnectoin()
        {
            conn.Close();
        }

        public void ExecuteQueires(String Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, conn);
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public object ShowDataInGridVIew(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}
