using Ardalis.GuardClauses;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Components.RenderTree;
using persons.management.Errors.Persons;

namespace persons.management.Models;

public class Person
{
    public static readonly int MaxAge = 150;
    public  Guid Id { get; }
    public  string FirstName { get; }
    public string LastName { get; } 
    public DateTime BirthDate { get; }
    protected Person(){}

    public Person(Guid id, string firstName, string lastName, DateTime birthDate)
    {
        Guard.Against.InvalidInput(birthDate, nameof(BirthDate), AgePredicate, PersonsErrors.AgeError);
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
    }

    private bool AgePredicate(DateTime date)
    {
        var diff = DateTime.Today - date;
        return (int)(diff.TotalDays/365) <= 150;



    }
}