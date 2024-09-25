using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Mortgage_calculator
{
    class DataBase
    {

        SQLiteConnection sqlConnection = new SQLiteConnection(@"Data Source=mortgage.db;Version=3;");

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) { 
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SQLiteConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
