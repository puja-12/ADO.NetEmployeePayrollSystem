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
        public DateTime Start_Date { get; set; }
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
    public class Employee_Model2
    {

        public Employee_Model2(int id, string Name, DateTime Start_Date, char GENDER, string Phone, string address, string department,
           decimal BasicPay, decimal Deduction, decimal TaxablePay, decimal IncomeTax, decimal NetPay)
        {
            this.id = id;
            this.Name = Name;
            this.Start_Date = Start_Date;
            this.GENDER = GENDER;
            this.Phone = Phone;
            this.address = address;
            this.department = department;
            this.BasicPay = BasicPay;
            this.Deduction = Deduction;
            this.TaxablePay = TaxablePay;
            this.IncomeTax = IncomeTax;
            this.NetPay = NetPay;
        }
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime Start_Date { get; set; }
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


