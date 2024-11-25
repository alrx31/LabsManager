using FluentAssertions;
using LabsManager.Entities;
using LabsManager.Infrastructure;
using LabsManager.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Tests.Unit.Repositories;

public class LabsRepositoryTests
{
    private readonly ApplicationDbContext _context;
    
    private readonly LabsRepository _labsRepository;
    
    public LabsRepositoryTests()
    {
        _context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options);
        
        _labsRepository = new LabsRepository(_context);
    }

    [Fact]
    public async Task GetAllLabs_Success()
    {
        // Arrange
        var labs = new List<Laba>
        {
            new Laba
            {
                id = 1,
                name = "Lab1",
                description = "Description1",
                materials = "met",
                FileName = "file",
                file = new byte[1],
                teacherId = 1,
                LastTimeToPass = DateTime.Now,
            },
            new Laba
            {
                id = 2,
                name = "Lab1",
                description = "Description1",
                materials = "met",
                FileName = "file",
                file = new byte[1],
                teacherId = 1,
                LastTimeToPass = DateTime.Now,
            }
        };
        
        await _context.Labs.AddRangeAsync(labs);
        
        await _context.SaveChangesAsync();
        
        // Act
        var result = await _labsRepository.GetAllLabs();

        // Assert
        result.Should().BeEquivalentTo(labs);
    }

    [Fact]
    public async Task GetLab_Success()
    {
        // Arrange
        var lab = new Laba
        {
            name = "Lab1",
            description = "Description1",
            materials = "met",
            FileName = "file",
            file = new byte[1],
            teacherId = 1,
            LastTimeToPass = DateTime.Now,
        };
        
        await _context.Labs.AddAsync(lab);
        
        await _context.SaveChangesAsync();
        
        // Act
        var result = await _labsRepository.GetLab(1);
        
        // Assert
        
        result.Should().BeEquivalentTo(lab);
    }

    [Fact]
    public async Task DeleteLab_Success()
    {
        // Arrange
        var lab = new Laba
        {
            name = "Lab1",
            description = "Description1",
            materials = "met",
            FileName = "file",
            file = new byte[1],
            teacherId = 1,
            LastTimeToPass = DateTime.Now,
        };
        
        await _context.Labs.AddAsync(lab);
        
        await _context.SaveChangesAsync();
        
        // Act
        
        await _labsRepository.DeleteLab(lab);
        
        var result = await _context.Labs.FirstOrDefaultAsync();
        
        // Assert
        
        result.Should().BeNull();
    }
}