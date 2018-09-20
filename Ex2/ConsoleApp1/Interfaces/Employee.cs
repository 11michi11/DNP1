namespace Interfaces
{
    public abstract class Employee
    {
        private string _name;

        public Employee(string name)
        {
            _name = name;
        }

        public abstract double GetMonthSalary();
    }
}