using Microsoft.EntityFrameworkCore;
using persons.management.Models;

namespace persons.management;

public class PersonsContext:DbContext
{
    public DbSet<Person> Persons { get; set; }=default! ;
    protected  PersonsContext(){}

    public PersonsContext(DbContextOptions<PersonsContext> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //modelBuilder.ApplyConfiguration(ne());
    }
}