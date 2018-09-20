using System;

namespace Generic_Interfaces
{
    public class Bomb : IExploadable<double>
    {
        public void Explode(double radius)
        {
            Console.WriteLine($"BOOM! {Math.PI*radius*radius}");
        }
    }
}