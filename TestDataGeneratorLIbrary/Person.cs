using System;
using System.Collections.Generic;

namespace TestDataGeneratorLIbrary
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public enum getSex { male, female };
        static public string[] firstNameMales =  {"Pekka","Jorma","Ville","Matti","Olli","Juho","Niko","Risto"};
        static public string[] firstNameFemale = { "Anna", "Emilia", "Riina", "Roosa", "Minna", "Hanna","Päivi","Pilvi" };
        static public string[] lastNames = {"Mäkinen","Virtanen","Suomalainen","Ruotsalainen","Hämäläinen","Jokinen","Turpeinen","Grönfors" };
        
        public getSex Sex { get; set; }

        public void PrintPerson(Person person)
        {
            Console.WriteLine("");
            Console.WriteLine("Name:    "+person.firstName+" "+person.lastName);
            Console.WriteLine("Age:     "+person.age);
            Console.WriteLine("Sex:     "+person.Sex);
        }

        public void PrintPeople(List<Person> peopleList)
        {
            foreach (var item in peopleList)
            {
                Console.WriteLine("");
                Console.WriteLine("Name:        "+item.firstName+" "+item.lastName);
                Console.WriteLine("Age:         "+item.age);
                Console.WriteLine("Gender:      "+item.Sex);
            }

            Console.WriteLine("");
            Console.WriteLine("There was "+peopleList.Count+" people on the list!");

        }

        public List<Person> GetListOfRandomPersons(int QuantityOfPeoples)
        {
            List<Person> people = new List<Person>();

            for (int i = 0; i < QuantityOfPeoples; i++)
            {
                Person person = new Person();
                TestDataGenerator temp = new TestDataGenerator();
                person = temp.GenerateRandomPerson();
                people.Add(person);

            }

            return people;
        }

        public Person(string firstname, string lastname, int age, getSex sex)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.age = age;
            this.Sex = sex;
        }

        public Person()
       {
       }

    }
}
