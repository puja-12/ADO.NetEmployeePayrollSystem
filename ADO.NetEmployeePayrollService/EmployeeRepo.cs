using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace ADO.NetEmployeePayrollService
{
    public class EmployeeRepo
    {

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DMPB7U8\MSSQLSERVER01; Initial Catalog =payroll_service; Integrated Security = True;");

        public void GetAllEmployee()
        {
            try
            {



                EmployeeModel employeeModel = new EmployeeModel();
                using (this.connection)
                {
                    string query = @"SELECT id,Name,Start_Date,GENDER,Phone,address,department,BasicPay,Deduction,taxablepay,IncomeTax,NetPay FROM employee_payroll;";

                    //define the SqlCommand Object
                    SqlCommand cmd = new SqlCommand(query, this.connection);

                    this.connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    //check if there are records

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            employeeModel.id = dr.GetInt32(0);
                            employeeModel.Name = dr.GetString(1);
                           // employeeModel.Start_Date = dr.GetDateTime(2);
                            //employeeModel.GENDER = Convert.ToChar(dr.GetString(3));
                            //employeeModel.Phone = dr.GetString(4);
                            //employeeModel.address = dr.GetString(5);
                            //employeeModel.department = dr.GetString(6);
                            //employeeModel.BasicPay = dr.GetDecimal(7);
                            //employeeModel.Deduction = dr.GetDecimal(8);
                            //employeeModel.TaxablePay = dr.GetDecimal(9);
                            //employeeModel.IncomeTax = dr.GetDecimal(10);
                            //employeeModel.NetPay = dr.GetDecimal(11);


                            //display retrieve record
                            Console.WriteLine("{0},{1}", employeeModel.id, employeeModel.Name);
                            Console.WriteLine("\n");

                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    //close data reader
                    dr.Close();

                    this.connection.Close();
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }

        }
        public bool AddEmployee(EmployeeModel model)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SpAddEmployeeDetails", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", model.Name);
                 
                    command.Parameters.AddWithValue("@Start_Date", model.Start_Date);
                    command.Parameters.AddWithValue("@GENDER", model.GENDER);
                    command.Parameters.AddWithValue("@Phone", model.Phone);
                    command.Parameters.AddWithValue("@address", model.address);
                    command.Parameters.AddWithValue("@department", model.department);
                    command.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                    command.Parameters.AddWithValue("@Deduction", model.Deduction);
                    command.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                    command.Parameters.AddWithValue("@IncomeTax", model.IncomeTax);
                    command.Parameters.AddWithValue("@NetPay", model.NetPay);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}
