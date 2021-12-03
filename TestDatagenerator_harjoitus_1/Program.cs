using System;
using TestDataGeneratorLIbrary;

namespace TestDatagenerator_harjoitus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDataGenerator test = new TestDataGenerator();
            Person person1 = test.GenerateRandomPerson("Olliriina");
            Person person2 = test.GenerateRandomPerson();
            Person person3 = test.GenerateRandomPerson();
            Person person4 = test.GenerateRandomPerson(lastname:"Heikkinen");
            Person person5 = test.GenerateRandomPerson();
            Person person6 = test.GenerateRandomPerson("ViljaEmilia","Kujantakainen");
            Person person7 = test.GenerateRandomPerson();
        }
    }
}
