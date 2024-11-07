
namespace TestDataGeneratorLibrary
{
    public class Person
    {
        public enum GetGender { Male, Female};
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public GetGender Gender { get; set; }
    }
}
