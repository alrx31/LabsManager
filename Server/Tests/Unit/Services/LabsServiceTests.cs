using System.Text;
using FluentAssertions;
using LabsManager.DTO;
using LabsManager.Entities;
using LabsManager.Infrastructure.Repository;
using LabsManager.Services;
using Microsoft.AspNetCore.Http;
using Moq;

namespace Tests.Unit.Services;

public class LabsServiceTests
{
    private readonly Mock<ILabsRepository> _labsRepositoryMock;
    private readonly Mock<IPassRepository> _passRepositoryMock;
    private readonly Mock<IPersonRepository> _personRepositoryMock;

    private readonly ILabsService _service;
    
    public LabsServiceTests()
    {
        _labsRepositoryMock = new Mock<ILabsRepository>();
        _passRepositoryMock = new Mock<IPassRepository>();
        _personRepositoryMock = new Mock<IPersonRepository>();
        
        _service = new LabsService(
            _labsRepositoryMock.Object,
            _passRepositoryMock.Object,
            _personRepositoryMock.Object
            );
    }

    [Fact]
    public async Task AddLab_Success_WhenValidModel()
    {
        // Arrange
        var lab = new AddLabDTO
        {
            Name = "name",
            Description = "description",
            Materials = "materials",
            File = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("This is a dummy file")), 0, 0, "Data", "dummy.txt"),
            TeacherId = 1,
            LastTimeToPass = DateTime.Today,
        };

        var teacher = new Teacher
        {
            id = 1,
            login = "login",
            password = "password",
            name = "name",
            cafedra = "cafedra"
        };
        
        // Act

        await _service.AddLab(lab);
        
        // Assert
        
        _labsRepositoryMock.Verify(x => x.AddLab(It.Is<Laba>(x => 
            x.name == lab.Name &&
            x.description == lab.Description &&
            x.materials == lab.Materials &&
            x.teacherId == lab.TeacherId &&
            x.LastTimeToPass == lab.LastTimeToPass
        )), Times.Once);
    }

    [Fact]
    public async Task GetLab_Success_WhenLabExits()
    {
        // Arrange
        var lab = new Laba
        {
            id = 1,
            name = "name",
            description = "description",
            materials = "materials",
            teacherId = 1,
            LastTimeToPass = DateTime.Today,
        };
        
        _labsRepositoryMock.Setup(x => x.GetLab(1)).ReturnsAsync(lab);
        
        // Act
        
        var result = await _service.GetLab(1);
        
        // Assert

        result.Should().BeEquivalentTo(lab);
    }

    [Fact]
    public async Task DeleteLab_Success_WhenLabExist()
    {
        // Arrange

        var lab = new Laba
        {
            id = 1,
            name = "name",
            description = "description",
            materials = "materials",
            teacherId = 1,
            LastTimeToPass = DateTime.Today,
        };
        
        _labsRepositoryMock.Setup(x => x.GetLab(1)).ReturnsAsync(lab);
        
        // Act
        
        await _service.DeleteLab(1);
        
        // Assert
        
        _labsRepositoryMock.Verify(x => x.DeleteLab(lab), Times.Once);
    }

    [Fact]
    public async Task GetStats()
    {
        // Act
        var res = _service.GetStats();
        
        // Assert

        res.Should().NotBeNull();
    }

}