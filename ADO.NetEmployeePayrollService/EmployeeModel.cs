using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetEmployeePayrollService
{
   public class EmployeeModel
    {
    
        public int id { get; set; }
        public string Name { get; set; }
        public string Start_Date { get; set; }
        public char GENDER { get; set; }
        public string Phone { get; set; }
        public string address { get; set; }
        public string department { get; set; }
        public decimal BasicPay { get; set; }
        public decimal Deduction { get; set; }
        public decimal TaxablePay { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal NetPay { get; set; }


    }
}
    
