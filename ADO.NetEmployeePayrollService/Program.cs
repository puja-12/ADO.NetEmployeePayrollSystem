// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.NetEmployeePayrollService
{
    class program
    {
       
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Employee Payroll!");

                EmployeeRepo repo = new EmployeeRepo();
                EmployeeModel employee = new EmployeeModel();
                repo.GetAllEmployee();  

            }
        }
    }


