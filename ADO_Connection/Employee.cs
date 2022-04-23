using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO_Connection
{
    public class Employee
    {
        public static void AddEmployee(EmployeeModel model)
        {
            string ConnectionString = @" Data Source=DESKTOP-LM9061V;Initial Catalog=PayRollService;Integrated Security=True;";
            model = new EmployeeModel
            {
                EmployeeID = 15,
                StartDate=DateTime.Now,
                Salary=40000,
                EmployeeName="rahul"

            };
            SqlConnection connection = new SqlConnection(ConnectionString);
            var sql = "Insert into Employee Payroll values" + model.EmployeeID + "," + model.EmployeeName + "," + model.Salary + "," + model.StartDate.ToString();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = System.Data.CommandType.Text;
            connection.Open();
            var reader = command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Record Added");

        }
    }
}
