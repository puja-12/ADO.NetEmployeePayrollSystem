using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.NetEmployeePayrollService;

namespace ADO.NetEmployeePayrollServiceTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void updateSalaryTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeeModel model = new EmployeeModel();
            decimal expected = 3000000;
            employeeRepo.updateSalary();
            decimal BasicPay = employeeRepo.updateSalary();
            Assert.AreEqual(expected, BasicPay);
        }
    }
}
