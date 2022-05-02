using SampleApi.Models.Entities;
using SampleApi.Models.Enums;

namespace SampleApi.Models.Results
{
    public class PersonDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public PersonDetails() { }

        public PersonDetails(Person person)
        {
            Id = person.Id;
            FirstName = person.FirstName;
            LastName = person.LastName;
            Age = person.Age;
            Gender = person.Gender;
        }
    }
}