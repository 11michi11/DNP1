using System;

namespace Serialization
{
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }

        public Person(string firstName, string lastName, int ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Ssn = ssn;
        }
    }
}