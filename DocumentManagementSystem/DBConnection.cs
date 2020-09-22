using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DocumentManagementSystem
{
    class DBConnection
    {
        //connect with database
        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LEOI7B2\\SQLEXPRESS;Initial Catalog=DMSProject;Integrated Security=True");

        //the method of open the connection
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        //the method of close the connection 
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        //the method of get the connection
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
