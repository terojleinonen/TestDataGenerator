using System;
using TestDataGeneratorLibrary;

namespace TestDataGenerator
{
    class Program
    {
        private static void Main()
        {
            TestDataGeneratorLibrary.TestDataGenerator test = new TestDataGeneratorLibrary.TestDataGenerator();
            Person person = test.GenerateRandomPerson();
            Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.Age);
        }
    }
}
