using System;

namespace Inheritance
{
    public class DNPStudent : Student
    {
        public new void Hi()
        {
            base.Hi();
            Console.WriteLine("Hi, I'm DNP student");
        }
        
    }
}