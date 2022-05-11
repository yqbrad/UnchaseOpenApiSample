using SampleApi.Models.Entities;
using SampleApi.Models.Enums;

namespace SampleApi.Models.Results
{
    public class PersonDetails
    {
        public int Id { get; set; }

        /// <summary>
        /// نام
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// سن
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// جنسیت
        /// </summary>
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