using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Cinema.DAO
{
    class DataProvider
    {
        private static DataProvider instance;

        private string connectionstr = "Data Source=DESKTOP-JLGS3G1;Initial Catalog = Cinema; Integrated Security = True";

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set => instance = value;
        }

        public DataTable ExecuteQuery(string query)
        {

            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionstr))
            { 

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                //get data to form
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
    }
}
