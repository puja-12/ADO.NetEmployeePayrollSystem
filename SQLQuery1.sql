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


 create or alter procedure SpAddressBook
(@FirstName varchar(50),
 @LastName varchar(50),
 @Address varchar(50),
 @City varchar(50),
 @State varchar(50),
 @Zip varchar(50),
 @Email varchar(50),
 @phone bigint,
 @Type varchar(50)
 )
 as
 begin
 Insert into AddressBook(FirstName,LastName,Address,City,State,Zip,Email,phone,Type)
 values(
@FirstName,
 @LastName,
 @Address,
 @City,
 @State,
 @Zip,
 @Email,
 @phone,
 @Type
)
SET NOCOUNT ON;
End
select * from AddressBook