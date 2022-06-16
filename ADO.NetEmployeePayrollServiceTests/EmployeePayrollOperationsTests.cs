using Microsoft.VisualStudio.TestTools.UnitTesting;
using ADO.NetEmployeePayrollService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetEmployeePayrollService.Tests
{
    [TestClass()]
    public class EmployeePayrollOperationsTests
    {
        [TestMethod()]
        public void Given10Employee_WhenAddedToList_ShouldMaatchEmployeeEntries()
        {
            List<Employee_Model2> employeeDetails = new List<Employee_Model2>();
            employeeDetails.Add(new Employee_Model2(id: 1, Name: "Viraj", Start_Date: DateTime.Now, GENDER: 'M', Phone: "9999999999", address: "Panvel", department: "Engineer", BasicPay: 10000, Deduction: 200, TaxablePay: 2000, IncomeTax: 1000, NetPay: 6800));
            employeeDetails.Add(new Employee_Model2(id: 2, Name: "Vaibhav", Start_Date: DateTime.Now, GENDER: 'M', Phone: "9999999999", address: "Calgary", department: "Engineer", BasicPay: 10000, Deduction: 200, TaxablePay: 2000, IncomeTax: 1000, NetPay: 6800));
            employeeDetails.Add(new Employee_Model2(id: 3, Name: "Varad", Start_Date: DateTime.Now, GENDER: 'M', Phone: "9999999999", address: "Alibag", department: "Engineer", BasicPay: 10000, Deduction: 200, TaxablePay: 2000, IncomeTax: 1000, NetPay: 6800));
            employeeDetails.Add(new Employee_Model2(id: 4, Name: "Mayuri", Start_Date: DateTime.Now, GENDER: 'M', Phone: "9999999999", address: "Sagaon", department: "Engineer", BasicPay: 10000, Deduction: 200, TaxablePay: 2000, IncomeTax: 1000, NetPay: 6800));
            employeeDetails.Add(new Employee_Model2(id: 5, Name: "Mitali", Start_Date: DateTime.Now, GENDER: 'M', Phone: "9999999999", address: "Karjat", department: "Engineer", BasicPay: 10000, Deduction: 200, TaxablePay: 2000, IncomeTax: 1000, NetPay: 6800));
            employeeDetails.Add(new Employee_Model2(id: 6, Name: "Ram", Start_Date: DateTime.Now, GENDER: 'M', Phone: "9999999999", address: "Neral", department: "Engineer", BasicPay: 10000, Deduction: 200, TaxablePay: 2000, IncomeTax: 1000, NetPay: 6800));
            employeeDetails.Add(new Employee_Model2(id: 7, Name: "Shyam", Start_Date: DateTime.Now, GENDER: 'M', Phone: "9999999999", address: "Uran", department: "Engineer", BasicPay: 10000, Deduction: 200, TaxablePay: 2000, IncomeTax: 1000, NetPay: 6800));
            employeeDetails.Add(new Employee_Model2(id: 8, Name: "Raju", Start_Date: DateTime.Now, GENDER: 'M', Phone: "9999999999", address: "Shelu", department: "Engineer", BasicPay: 10000, Deduction: 200, TaxablePay: 2000, IncomeTax: 1000, NetPay: 6800));
            employeeDetails.Add(new Employee_Model2(id: 9, Name: "Babu", Start_Date: DateTime.Now, GENDER: 'M', Phone: "9999999999", address: "Pali", department: "Engineer", BasicPay: 10000, Deduction: 200, TaxablePay: 2000, IncomeTax: 1000, NetPay: 6800));

            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            DateTime startDateTime = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with Thread: " + (stopDateTimeThread - startDateTimeThread));
        }
    }
}

