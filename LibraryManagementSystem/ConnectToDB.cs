using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class ConnectToDB
    {
        public static SqlConnection ConnectDB()
        {
            string configuration = ConfigurationManager.ConnectionStrings["ConnectSQLDB"].ConnectionString;
            SqlConnection connection = new SqlConnection(configuration);
            connection.Open();
            return connection;
        } // end of ConnectDB
    } // end of class ConnectToDB
} // end of namespace BallGame