using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace inspection_tool
{
    class DBConnection
    {
        private static DBConnection _dbInstance;
        private string connStr;
        private SqlConnection connToDB;

        private DBConnection()
        {
            connStr = Properties.Settings.Default.InspectionDBConnection;
        }

        public static DBConnection getDBInstance()
        {
            // Create instance if there isn't already one
            if (_dbInstance == null)
            {
                _dbInstance = new DBConnection();
            }

            return _dbInstance;
        }

        public DataSet getDataSet(string sqlQuery)
        {
            // empty db
            DataSet dataSet = new DataSet();

            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

                dataAdapter.Fill(dataSet);
            }

            return dataSet;
        }

        public void saveNewInspectorToDB(string sqlQuery, string username, string email, string password)
        {
            using (SqlConnection connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("username", username));
                sqlCommand.Parameters.Add(new SqlParameter("email", email));
                sqlCommand.Parameters.Add(new SqlParameter("password", password));

                sqlCommand.ExecuteNonQuery();

                connToDB.Close();
            }
        }
    }
}
