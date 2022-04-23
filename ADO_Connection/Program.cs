using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Connection
{
    public class Program
    {
        public void Main()
        {
            Console.WriteLine("Welcome to ADO.net Program");
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();
            Employee.AddEmployee(employee);
        }
    }
}
