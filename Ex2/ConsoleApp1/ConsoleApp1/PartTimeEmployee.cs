namespace ConsoleApp1
{
    public class PartTimeEmployee : Employee
    {
        private double _hourlyWage;
        private int _hoursPerMonth;

        public PartTimeEmployee(string name, int hoursPerMonth, double hourlyWage)
            : base(name)
        {
            _hoursPerMonth = hoursPerMonth;
            _hourlyWage = hourlyWage;
        }

        public override double GetMonthSalary()
        {
            return _hourlyWage * _hoursPerMonth;
        }
    }
}