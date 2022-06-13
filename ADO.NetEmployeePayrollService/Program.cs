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
                //repo.GetAllEmployee();

            employee.Name = "Mansi";
           
            employee.Start_Date = "05-05-2019";
            employee.GENDER = 'F';
            employee.Phone = "0123586489";
            employee.address = "3-161-21";
            employee.department = "Hr";
            employee.BasicPay = 22000;
            employee.Deduction = 1500;
            employee.TaxablePay = 200;
            employee.IncomeTax = 5000;
            employee.NetPay = 25000;

            repo.AddEmployee(employee);





        }
    }
    }


