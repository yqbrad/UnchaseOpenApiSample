using SampleApi.Models.Enums;

namespace SampleApi.Models.Requests
{
    public class AddPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}