namespace OperatorOverloading
{
    public class Time
    {
        private int Hours { get; set; }
        private int Minutes { get; set; }

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public static Time operator +(Time t1, Time t2)
        {
            return new Time(t1.Hours + t2.Hours, t1.Minutes + t1.Minutes);
        }

        public override string ToString()
        {
            return $"{Hours}:{Minutes}";
        }
    }
}