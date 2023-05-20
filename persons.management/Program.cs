using persons.management;
using persons.management.Repositories;
using persons.management.Services.Persons;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddTransient<IPersonsService, PersonService>();
    builder.Services.AddScoped<IPersonsRepository, PersonRepository>();
    //TODO: add configuration
    builder.Services.AddDbContext<PersonsContext>();
}


var app = builder.Build();
{
    app.UseHttpsRedirection();}

    app.UseAuthorization();

    app.MapControllers();


    app.Run();


}
