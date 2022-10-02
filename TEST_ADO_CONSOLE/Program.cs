using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_ADO_CONSOLE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<");


            Console.WriteLine(" Enter 1 to get Employee's sales report \n Enter 2 to get Product wise report");

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {

                        EMP_SALE_REPORT_MC.Execute();
                        break;
                    }
                case 2:
                    {
                        PWR_REPORT_MC.Execute1();
                        break;
                    }
            }

            Console.ReadLine();
        }
    }
}
