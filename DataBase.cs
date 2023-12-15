using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cours_Work1
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (LocalDb)\Cours; Initial Catalog = Data_Base_Criminals; Integrated Security = True");

        public void Open_Connection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }           
        }

        public void Close_Connection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection Get_Connection()
        {
            return sqlConnection;
        }
    }
}
