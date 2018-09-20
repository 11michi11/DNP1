using System;

namespace Intro1 {
    public class Person {

        string name;

        public Person(string name) {
            this.name = name;
        }

        public void Introduce() {
            Console.Write(name);
        }
    }
}