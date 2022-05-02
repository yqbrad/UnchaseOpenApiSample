using SampleApi.Models.Enums;

namespace SampleApi.Models.Entities;

public class Person
{
    public int Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
    public Gender Gender { get; private set; }

    public Person(int id,
        string firstName,
        string lastName,
        int age,
        Gender gender)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Gender = gender;
    }
}