namespace Dictionary
{
    public class Person
    {
        private string Name { get;  }
        private int Age { get; }
        private int  Power { get; set; }

        public Person(string name, int age, int power)
        {
            Name = name;
            Age = age;
            Power = power;
        }

        public override string ToString()
        {
            return $"{Name} age: {Age} power: {Power}";
        }
    }
}