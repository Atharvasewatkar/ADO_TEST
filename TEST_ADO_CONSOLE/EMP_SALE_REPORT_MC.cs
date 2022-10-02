using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPERATIONS.OPERATION;
using OPERATIONS.ENTITIES;

namespace TEST_ADO_CONSOLE
{

  
    public class EMP_SALE_REPORT_MC
    {


        private static string connectionString = @"Data Source=DESKTOP-J5B203A;Initial Catalog=Northwind;Integrated Security=True";

        private static EMP_OPERATION ESR = new EMP_OPERATION(connectionString);

        public static void Execute() 
        {

            Console.WriteLine("Enter employee id");
            int @EMP_ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter from date");

            string @FROM_DATE = Console.ReadLine();// "1996-07-04";
            Console.WriteLine("Enter to date");

            string @TO_DATE = Console.ReadLine();//"1997-07-04";

            EMP_REPORT EMR = ESR.GetEMP_REPORT(@EMP_ID, @FROM_DATE, @TO_DATE);

            


                Console.WriteLine("EmployeID\t: "+EMR.EmployeeID);
                Console.WriteLine("Firstname\t: "+EMR.FIRSTNAME);
                Console.WriteLine("Lastname\t: "+EMR.LASTNAME);
                Console.WriteLine("OrderID\t\t: "+EMR.ORDERID);
                Console.WriteLine("Total Orders\t: "+EMR.TOTAL_ORDERS);
            

          //  Console.ReadLine();
        }


    }
}
