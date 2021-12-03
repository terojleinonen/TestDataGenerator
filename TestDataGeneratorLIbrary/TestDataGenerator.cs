using System;
namespace TestDataGeneratorLIbrary
{
    public class TestDataGenerator
    {
        public string GetRandomStringFromArray(string[] array)
        {
            Random random = new Random();
            string tmp = array[random.Next(0, array.Length - 1)];
            return tmp;
        }

        public Person GenerateRandomPerson(string firstname = "",string lastname = "")
        {
            Person person = new Person();

            if (firstname != "" && lastname != "")
            {
                person.firstName = firstname;
                person.lastName = lastname;
                person.age = RandomInt(0, 100);
                return person;
            }
            else
            {
                if (firstname == "")
                {
                    person.Sex = RandomSex();

                    if (person.Sex == Person.getSex.female)
                    {
                        person.firstName = GetRandomStringFromArray(Person.firstNameFemale);
                    }
                    if(person.Sex == Person.getSex.male)
                    {
                        person.firstName = GetRandomStringFromArray(Person.firstNameMales);
                    }
                }
                else
                {
                    person.firstName = firstname;
                }

                if (lastname == "")
                {
                    person.lastName = GetRandomStringFromArray(Person.lastNames);
                }
                else
                {
                    person.lastName = lastname;
                }

                    person.age = RandomInt(0, 100);
                    return person;
            }      

        }

        public int RandomInt(int MIN, int MAX)
        {
            Random random = new Random();
            return random.Next(MIN, MAX);
        }

        public Person.getSex RandomSex()
        {
            Person.getSex sex = (Person.getSex)(new Random()).Next(0,2);
            
            if (sex == Person.getSex.male)
            {
                return Person.getSex.male;
            }
            else
            {
                return Person.getSex.female;
            }
        }
        

        public TestDataGenerator()
        {
        }
    }
}
