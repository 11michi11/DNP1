using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Company
    {
        private List<Employee> _employees = new List<Employee>();

        public void EmployNewEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public double GetMonthlySalaryTotal()
        {
            return _employees.Sum(employee => employee.GetMonthSalary());
        }
    }
}