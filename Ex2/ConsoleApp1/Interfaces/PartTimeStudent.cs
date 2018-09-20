namespace Interfaces
{
    public class PartTimeStudent : PartTimeEmployee, IStudent
    {
        private int startOfEducation;

        public PartTimeStudent(string name, int hoursPerMonth, double hourlyWage) : base(name, hoursPerMonth,
            hourlyWage)
        {
        }

        public void Register(int year)
        {
            startOfEducation = year;
        }
    }
}