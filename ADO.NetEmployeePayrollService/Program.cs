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
            while (true)
            {
                Console.WriteLine("Choose the option :\n1)Create/connect database\n2)Retrieve values from Database and insert\n3)Update salary\n5)Get details of employess using particulare date range\n6)Aggregate functions");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        repo.GetAllEmployee();
                        break;
                    case 2:
                        employee.Name = "Terrisa";

                        // employee.Start_Date = "05-05-2019";
                        employee.GENDER = 'F';
                        employee.Phone = "0123586489";
                        employee.address = "3-161-21";
                        employee.department = "Hr";
                        employee.BasicPay = 22000;
                        employee.Deduction = 1500;
                        employee.TaxablePay = 200;
                        employee.IncomeTax = 5000;
                        employee.NetPay = 25000;

                        //  repo.AddEmployee(employee); */
                        break;
                    case 3:
                        repo.updateSalary();

                        break;
                    case 6:
                        while (true)
                        {
                            Console.WriteLine("Choose the option :\n1)Count\n2)Average\n3)sum of salary\n4)MinimumOfSalary\n5)Maximum of salary");
                            int option1 = Convert.ToInt16(Console.ReadLine());
                            switch (option1)
                            {
                                case 1:
                                    int count = repo.CountOfEntries();
                                    Console.WriteLine("Count of Records :" + count);
                                    break;
                                case 2:
                                    decimal Avg = repo.AverageOfSalary();
                                    Console.WriteLine("Average salary :" + Avg);
                                    break;
                                case 3:
                                    decimal Sum = repo.SumOfSalary();
                                    Console.WriteLine("Sum of salaries is :" + Sum);
                                    break;
                                case 4:
                                    decimal minimum = repo.MinimumOfSalary();
                                    Console.WriteLine("Minimum of salaries is :" + minimum);
                                    break;
                                case 5:
                                    decimal maximum = repo.MaximumOfSalary();
                                    Console.WriteLine("Maximum of salaries is :" + maximum);
                                    break;

                                default:
                                    Console.WriteLine("Please choose the correct option");
                                    break;
                            }
                        }
                }
            }
        }
    }
}





        

