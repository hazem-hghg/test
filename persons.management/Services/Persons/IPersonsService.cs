using persons.management.Models;

namespace persons.management.Services.Persons;

public interface IPersonsService
{
     public void CreatePerson(Person person);
     public IEnumerable<Person> GetPersons();
}