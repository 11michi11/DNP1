using System;
using System.Collections.Generic;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            
            cars.Add(new Car("blue", 2.5, 7));
            cars.Add(new Car("red", 1.5, 4));
            cars.Add(new Car("green", 3.75, 15));


            cars.FindAll(IsRed).ForEach(Console.WriteLine);
            cars.FindAll(car => car.EngineSize < 2.0).ForEach(Console.WriteLine);
            cars.FindAll(car => car.FuelEconomy > 10).ForEach(Console.WriteLine);
            cars.FindAll(car => car.Color.Equals("blue") && car.EngineSize > 2.0).ForEach(Console.WriteLine);
            
            
        }

        public static bool IsRed(Car car)
        {
            return car.Color.Equals("red");
        }
    }
    
    
}