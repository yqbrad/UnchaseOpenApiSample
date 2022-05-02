using SampleApi.Models.Entities;
using SampleApi.Models.Enums;
using SampleApi.Models.Requests;

namespace SampleApi.Models;

public class PeopleRepository
{
    public List<Person> Persons { get; set; } = new();

    public PeopleRepository()
    {
        Persons.Add(new Person(1, "Mohammad", "Yaghoubi", 31, Gender.Man));
    }

    public int Add(AddPerson req)
    {
        var id = Persons.Max(s => s.Id);
        Persons.Add(new Person(id + 1, req.FirstName, req.LastName, req.Age, req.Gender));
        return id;
    }
}