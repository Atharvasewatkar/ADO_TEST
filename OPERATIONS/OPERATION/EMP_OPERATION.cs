using OPERATIONS.ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATIONS.OPERATION
{
    public class EMP_OPERATION
    {
         private string ConnectionString;
        public EMP_OPERATION(string connectionString)
        {
            ConnectionString = connectionString;
        }

       public EMP_REPORT GetEMP_REPORT(int @EMP_ID, string @FROM_DATE, string @TO_DATE ) 
        {
            EMP_REPORT EMPS = new EMP_REPORT();
            using (SqlConnection connection = new SqlConnection(ConnectionString)) 
            {

                SqlCommand command = new SqlCommand($"EXECUTE [dbo].[EMPLOYEE_SALES_REPORT] '{@EMP_ID}', '{@FROM_DATE}', '{@TO_DATE}'", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader(); 
                while (reader.Read()) 
                {

                    EMPS.EmployeeID = (int)reader[0];
                    EMPS.FIRSTNAME=(string)reader[1];
                    EMPS.LASTNAME = (string)reader[2];
                    EMPS.ORDERID=(int)reader[3];
                    EMPS.TOTAL_ORDERS= (int)reader[4];  
    
                }
                connection.Close();

            }
            return EMPS;
        } 
    }
}
