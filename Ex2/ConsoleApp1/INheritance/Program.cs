namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student john = new Student();
            john.Hi();
            DNPStudent dnpJohn = new DNPStudent();
            dnpJohn.Hi();
            Student exJohn = john;
            exJohn.Hi();
        }
    }
}