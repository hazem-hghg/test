using persons.management.Models;

namespace persons.management.Repositories;

public interface IPersonsRepository
{
    public void Add(Person person);
    public IEnumerable<Person> GetPersons();
}