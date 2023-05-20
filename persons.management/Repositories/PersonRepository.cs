using persons.management.Models;

namespace persons.management.Repositories;

public class PersonRepository:IPersonsRepository
{
    private readonly PersonsContext _dbContext=default!;
    protected  PersonRepository(){}

    public PersonRepository(PersonsContext dbContext)
    {
        _dbContext = dbContext;
    }
    public void Add(Person person)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Person> GetPersons()
    {
        throw new NotImplementedException();
    }
}