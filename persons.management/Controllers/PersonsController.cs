using Microsoft.AspNetCore.Mvc;
using persons.management.contracts.Persons;
using persons.management.Models;
using persons.management.Services.Persons;

namespace persons.management.Controllers;


[ApiController]
[Route("[controller]")]
public class PersonsController:ApiController
{
    private readonly IPersonsService _personsService;
    public PersonsController(IPersonsService personsService)
    {
        _personsService = personsService;
    }
    [HttpPost]
    public IActionResult CreatePerson(CreatePersonRequest request)
    {
        var person = new Person(Guid.NewGuid(), request.FirstName, request.LastName, request.BirthDate);
        _personsService.CreatePerson(person);
        
        return Ok(person.Id);
    }

    [HttpGet]
    public IActionResult GetPersons()
    {
        var persons = _personsService.GetPersons().Select(x => new PersonResponse(x.Id, x.FirstName, x.LastName));
        
        return Ok();
    }
}