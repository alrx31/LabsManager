using FluentAssertions;
using LabsManager.Entities;
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

    [Fact]
    public async Task AddTeacher_Success()
    {
        // Arrenge
        var teacher = new Teacher
        {
            login = "login",
            password = "password",
            name = "name",
            cafedra = "TEST",
            isAdmin = false
        };
        
        // Act
        
        await _personRepository.AddTeacher(teacher);
        
        // Assert
        
        var result = await _context.Teachers.FirstOrDefaultAsync();

        result.Should().Be(teacher);
    }

    [Fact]
    public async Task AddStudent_Success()
    {
        // Arrange
        var student = new Student
        {
            login = "login",
            password = "password",
            name = "name",
            group = "TEST"
        };
        
        // Act
        
        await _personRepository.AddStudent(student);
        
        // Assert
        
        var result = await _context.Students.FirstOrDefaultAsync();

        result.Should().BeEquivalentTo(student);
    }

    [Fact]
    public async Task GetStudentByLogin_Success()
    {
        // Arrange
        var student = new Student
        {
            login = "login",
            password = "password",
            name = "name",
            group = "TEST"
        };
        
        await _context.Students.AddAsync(student);
        
        await _context.SaveChangesAsync();
        
        // Act
        
        var result = await _personRepository.GetStudentByLogin("login");
        
        // Assert
        
        result.Should().BeEquivalentTo(student);
    }

    [Fact]
    public async Task GetTeacherBylogin_Success()
    {
        // Arrange
        var teacher = new Teacher
        {
            login = "login",
            password = "password",
            name = "name",
            cafedra = "TEST",
            isAdmin = false
        };
        
        await _context.Teachers.AddAsync(teacher);
        
        await _context.SaveChangesAsync();
        
        // Act
        
        var result = await _personRepository.GetTeacherByLogin("login");
        
        // Assert
        
        result.Should().BeEquivalentTo(teacher);
    }

    [Fact]
    public async Task GetStudentById_Success()
    {
        // Arrange
        var student = new Student
        {
            id = 2,
            login = "login",
            password = "password",
            name = "name",
            group = "TEST"
        };
        
        await _context.Students.AddAsync(student);
        
        await _context.SaveChangesAsync();
        
        // Act

        var result = await _personRepository.getStudentById(student.id);
        
        // Assert

        result.Should().BeEquivalentTo(student);
    }

    [Fact]
    public async Task GetAllStudents_Success()
    {
        // Arrange
        var sts = new List<Student>
        {
            new Student
            {
                id = 2,
                login = "login",
                password = "password",
                name = "name",
                group = "TEST"
            },
            new Student
            {
                id = 4,
                login = "login",
                password = "password",
                name = "name",
                group = "TEST"
            }
        };

        await _context.Students.AddRangeAsync(sts);

        await _context.SaveChangesAsync();
        
        // Act
        
        var result = await _personRepository.GetAllStudents();
        
        // Assert
        
        result.Should().BeEquivalentTo(sts);
    }
}