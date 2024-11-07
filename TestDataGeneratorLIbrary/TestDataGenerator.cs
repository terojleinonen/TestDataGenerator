using System;
namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator
    {
        private readonly string[] _firstNameMales =  ["Pekka","Jorma","Ville","Matti","Olli","Juho","Niko","Risto"];
        private readonly string[] _firstNameFemales = ["Anna", "Emilia", "Riina", "Roosa", "Minna", "Hanna","Päivi","Pilvi"];
        private readonly string[] _lastNames = ["Mäkinen","Virtanen","Suomalainen","Ruotsalainen","Hämäläinen","Jokinen","Turpeinen","Grönfors"];
        
        public Person GenerateRandomPerson(string firstname = "",string lastname = "")
        {
            Random random = new();
            Person person = new();
            var randomMaleNameIndex = random.Next(0, _firstNameMales.Length);
            var randomFemaleNameIndex = random.Next(0, _firstNameFemales.Length);
            person.Gender = RandomGender(random.Next(0,2));
            person.FirstName = RandomFirstName(person.Gender, randomMaleNameIndex, randomFemaleNameIndex);
            person.LastName = _lastNames[random.Next(0,_lastNames.Length)];
            person.Age = random.Next(1, 100);
            return person;

        }

        private static Person.GetGender RandomGender(int randomNumber) => randomNumber switch
        {
            0 => Person.GetGender.Male,
            1 => Person.GetGender.Female,
            _ => throw new ArgumentException("Invalid Gender")
        };
        
        private string RandomFirstName(Person.GetGender gender, int randomMaleNameIndex, int randomFemaleNameIndex) => gender switch
        {
            Person.GetGender.Female => _firstNameFemales[randomFemaleNameIndex],
            Person.GetGender.Male => _firstNameMales[randomMaleNameIndex],
            _ => throw new ArgumentException("Invalid Gender")
    };
    }
}
