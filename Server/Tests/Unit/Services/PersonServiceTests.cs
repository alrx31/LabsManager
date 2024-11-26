using FluentAssertions;
using LabsManager.DTO;
using LabsManager.Entities;
using LabsManager.Infrastructure.Repository;
using LabsManager.Services;
using Moq;

namespace Tests.Unit.Services;

public class PersonServiceTests
{
    private readonly Mock<IPassRepository> _passRepositoryMock;
    private readonly Mock<IPersonRepository> _personRepositoryMock;

    private readonly IPersonService _service;

    public PersonServiceTests()
    {
        _passRepositoryMock = new Mock<IPassRepository>();
        _personRepositoryMock = new Mock<IPersonRepository>();

        _service = new PersonService(
            _personRepositoryMock.Object,
            _passRepositoryMock.Object
        );
    }

    [Fact]
    public async Task GetStudentById_Success()
    {
        // Arrange
        var student = new Student
        {
            id = 1,
            login = "login",
            password = "password",
            name = "name",
            group = "cafedra"
        };

        _personRepositoryMock
            .Setup(x => x.getStudentById(1))
            .ReturnsAsync(student);

        // Act

        var result = await _service.GetStudentById(1);

        // Assert

        result.Should().BeEquivalentTo(student);
    }

    [Fact]
    public async Task RegisterStudent_Success()
    {
        // Arrange
        var studentDTO = new RegisterStudentDTO
        {
            Name = "nabe",
            Login = "login",
            Password = "sdfs",
            Group = "group"
        };

        // Act
        await _service.RegisterStudent(studentDTO);

        // Assert

        _personRepositoryMock.Verify(x => x.AddStudent(It.IsAny<Student>()), Times.Once);
    }

    [Fact]
    public async Task RegisterTeacher_Success()
    {
        // Arrange
        var teacherDTO = new RegisterTeacherDTO
        {
            Name = "name",
            Login = "login",
            Password = "password",
            Cafedra = "cafedra"
        };

        // Act
        await _service.RegisterTeacher(teacherDTO);

        // Assert

        _personRepositoryMock.Verify(x => x.AddTeacher(It.IsAny<Teacher>()), Times.Once);
    }
}