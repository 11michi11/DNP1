using System;

namespace Collections
{
    public class Animal : IComparable<Animal>
    {
        private string type;
        private double weight;
        private int runSpeed;

        public Animal(string type, double weight, int runSpeed)
        {
            this.type = type;
            this.weight = weight;
            this.runSpeed = runSpeed;
        }

        public override string ToString()
        {
            return $"Type: {type} weight: {weight} run speed: {runSpeed}";
        }

        public int CompareTo(Animal other)
        {
            if (Math.Abs(runSpeed - other.runSpeed) < 0.1)
                return 0;
            return weight < other.weight ? 1 : -1;
        }
    }
}