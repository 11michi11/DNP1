namespace Interfaces
{
    public class FullTimeEmployee  : Employee
    {
        private double _monthlySalary;


        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            _monthlySalary = monthlySalary;
        }

        public override double GetMonthSalary()
        {
            return _monthlySalary;
        }
    }
}