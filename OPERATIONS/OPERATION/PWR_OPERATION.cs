using OPERATIONS.ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATIONS.OPERATION
{
    public class PWR_OPERATION
    {
        private string ConnectionString;
        public PWR_OPERATION(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public PWR_REPORT GetPWR_REPORT(string PROD_NAME, string MONTH, int YEAR)
        {


           PWR_REPORT PWRS = new PWR_REPORT();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                SqlCommand command = new SqlCommand($"EXECUTE [dbo].[PRODUCT_WISE_REPORT] '{PROD_NAME}', '{MONTH}', '{YEAR}'", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    PWRS.ProductName= (string)reader[0];
                    PWRS.month      = (string)reader[1];
                    PWRS.TotalCost = (decimal)reader[2];
                   
                }
                connection.Close();

            }
            return PWRS;
        }
    }
}
