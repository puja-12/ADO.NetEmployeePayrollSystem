create procedure [SpAddEmployeeDetails]
 (
 @Name varchar(255),
 @Start_Date Date,
 @GENDER varchar(1),
 @Phone varchar(10),
 @address varchar(200),
 @department varchar(255),
 @BasicPay decimal,
 @Deduction decimal,
 @TaxablePay decimal,
 @IncomeTax decimal,
 @NetPay decimal
 )
 as
 begin
  Insert into employee_payroll values(@Name,@Start_Date,@GENDER,@Phone,@address,@department,@BasicPay,@Deduction,@TaxablePay,@IncomeTax,@NetPay)
 End
 select* from employee_payroll;