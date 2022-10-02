using OPERATIONS.ENTITIES;
using OPERATIONS.OPERATION;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_ADO_CONSOLE
{
    internal class PWR_REPORT_MC
    {
        private static string connectionString = @"Data Source=DESKTOP-J5B203A;Initial Catalog=Northwind;Integrated Security=True";

        private static PWR_OPERATION pwrss = new PWR_OPERATION(connectionString);

        public static void Execute1()
        {

            Console.WriteLine("Enter product name");
            string @ProductName = Console.ReadLine();
            Console.WriteLine("Enter month");

            string @month = Console.ReadLine();// "1996-07-04";
            Console.WriteLine("Enter year");

            int @YEAR = int.Parse(Console.ReadLine());//"1997-07-04";

            PWR_REPORT pwr = pwrss.GetPWR_REPORT(@ProductName, @month, @YEAR);




            Console.WriteLine("productName\t: " + pwr.ProductName);
            Console.WriteLine("firstname\t: " +   pwr.month )     ;
            Console.WriteLine("lastname\t: " + pwr.TotalCost);



        }
    }
}
