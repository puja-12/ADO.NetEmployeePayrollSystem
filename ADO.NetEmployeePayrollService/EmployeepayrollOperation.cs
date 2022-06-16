using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetEmployeePayrollService
{
    public class EmployeePayrollOperations
    {
        List<Employee_Model2> employeePayrollDetailList = new List<Employee_Model2>();

        public void addEmployeeToPayroll(List<Employee_Model2> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {

                Console.WriteLine("Employee being added: " + employeeData.Name);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine("Employee Added: " + employeeData.Name);
            });

            Console.WriteLine(this.employeePayrollDetailList.ToString());
        }


        public void addEmployeePayroll(Employee_Model2 emp)
        {
            employeePayrollDetailList.Add(emp);
        }
        public void addEmployeeToPayrollWithThread(List<Employee_Model2> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added: " + employeeData.Name);
                    this.addEmployeePayroll(employeeData);
                    Console.WriteLine("Employee Added: " + employeeData.Name);
                });
                thread.Start();
            });
            Console.WriteLine(this.employeePayrollDetailList.Count);
        }


    }


}
