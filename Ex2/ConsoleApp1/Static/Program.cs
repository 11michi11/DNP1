using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun1 = new Gun();
            Gun gun2 = new Gun();
            
            gun1.Shoot();
            gun2.Shoot();

            Console.WriteLine($"gun1 bullet count: {gun1.GetBulletCount()} shoots fired: {gun1.GetShotsFired()}");
            Console.WriteLine($"gun2 bullet count: {gun2.GetBulletCount()} shoots fired: {gun2.GetShotsFired()}");
            
        }
    }
}