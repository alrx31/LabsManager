using LabsManager.Infrastructure;
using LabsManager.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Tests.Unit.Repositories;

public class PersonRepositoryTests
{
    private readonly ApplicationDbContext _context;
    
    private readonly PersonRepository _personRepository;

    public PersonRepositoryTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "Test")
            .Options;
        
        _context = new ApplicationDbContext(options);
        _personRepository = new PersonRepository(_context);
    }
}