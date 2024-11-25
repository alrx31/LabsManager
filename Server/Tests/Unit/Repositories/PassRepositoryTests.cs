using FluentAssertions;
using LabsManager.Entities;
using LabsManager.Infrastructure;
using LabsManager.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Tests.Unit.Repositories;

public class PassRepositoryTests
{
    private readonly ApplicationDbContext _context;
    
    private readonly PassRepository _passRepository;

    public PassRepositoryTests()
    {
        _context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options);
        
        _passRepository = new PassRepository(_context);
    }
    
    [Fact]
    public async Task GetAllPassModels_Success()
    {
        // Arrange
        var passModels = new List<PassModel>
        {
            new PassModel
            {
                id = 1,
                labId = 1,
                studentId = 1,
                teacherId = 1,
                comment = "comment",
                mark = 2,
                report = new byte[1],
                fileExtension = "pdf"
            },
            new PassModel
            {
                id = 2,
                labId = 1,
                studentId = 1,
                teacherId = 1,
                comment = "comment",
                mark = 2,
                report = new byte[1],
                fileExtension = "pdf"
            }
        };

        await _context.Students.AddAsync(new Student
        {
            id = 1,
            group = "group",
            login = "login",
            name = "name",
            password = "password"
        });
        await _context.Teachers.AddAsync(new Teacher
        {
            id = 1,
            cafedra = "cafedra",
            isAdmin = true,
            login = "login",
            name = "name",
            password = "password"
        });
        await _context.Labs.AddAsync(new Laba
        {
            description = "description",
            file = new byte[1],
            FileName = "FileName",
            LastTimeToPass = DateTime.Now,
            materials = "materials",
            name = "name",
            teacherId = 1
        });
        
        await _context.PassModels.AddRangeAsync(passModels);
        
        await _context.SaveChangesAsync();
        
        // Act
        var result = await _passRepository.getAllPassModels();
        
        // Assert
        result.Should().BeEquivalentTo(passModels);
    }

    [Fact]
    public async Task AddPassModel_Success()
    {
        // Arrange
        var passModel = new PassModel
        {
            id = 1,
            labId = 1,
            studentId = 1,
            teacherId = 1,
            comment = "comment",
            mark = 2,
            report = new byte[1],
            fileExtension = "pdf"
        };
        
        // Act
        await _passRepository.AddPassModel(passModel);
        
        // Assert
        
        var result = await _context.PassModels.FirstOrDefaultAsync(l => l.id == passModel.id);
        
        result.Should().BeEquivalentTo(passModel);
    }

    [Fact]
    public async Task UpdatePassmodel_Success()
    {
        var passModel = new PassModel
        {
            id = 1,
            labId = 1,
            studentId = 1,
            teacherId = 1,
            comment = "comment",
            mark = 2,
            report = new byte[1],
            fileExtension = "pdf"
        };
        
        await _context.PassModels.AddAsync(passModel);
        
        await _context.SaveChangesAsync();
        
        // Act
        
        passModel.mark = 5;
        
        await _passRepository.UpdatePassModel(passModel);
        
        // Assert
        
        var result = await _context.PassModels.FirstOrDefaultAsync(l => l.id == passModel.id);
        
        result.Should().BeEquivalentTo(passModel);
    }
}