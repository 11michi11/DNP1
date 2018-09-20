using System.Drawing;

namespace Lambdas
{
    public class Car
    {
        public string Color { get; }
        public double EngineSize { get; }
        public double FuelEconomy{ get; }

        public Car(string color, double engineSize, double fuelEconomy)
        {
            Color = color;
            EngineSize = engineSize;
            FuelEconomy = fuelEconomy;
        }

        public override string ToString()
        {
            return $"Color: {Color}, Engine: {EngineSize}, FuelEconomy: {FuelEconomy}";
        }
    }
}