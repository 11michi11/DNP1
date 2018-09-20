using System;

namespace Interfaces
{
    class Program
    {
        public static void Main(string[] args)
        {
            Company();
        }

        public static void Company()
        {
            Company company = new Company();
            company.EmployNewEmployee(new FullTimeEmployee("John", 30000.0));
            company.EmployNewEmployee(new PartTimeEmployee("Steve", 40, 125));
            Console.WriteLine(company.GetMonthlySalaryTotal());
        }
    }
}