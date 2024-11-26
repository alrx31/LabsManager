using System.Runtime.CompilerServices;
using System.Text;
using FluentAssertions;
using LabsManager.DTO;
using LabsManager.Entities;
using LabsManager.Infrastructure.Repository;
using LabsManager.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Moq;

namespace Tests.Unit.Services;

public class PassServiceTests
{
    private readonly Mock<IPassRepository> _passRepositoryMock;

    private readonly IPassService _service;

    public PassServiceTests()
    {
        _passRepositoryMock = new Mock<IPassRepository>();

        _service = new PassService(
            _passRepositoryMock.Object
        );
    }

    [Fact]
    public async Task AddPassModel_Success()
    {
        // Arrange
        var model = new AddPassModelDTO
        {
            labId = 1,
            studentId = 1,
            teacherId = 1,
            report = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("This is a dummy file")), 0, 0, "Data", "dummy.txt"),
        };
        
        // Act
        
        await _service.AddPassModel(model);
        
        // Assert
        
        _passRepositoryMock.Verify(x=>x.AddPassModel(It.IsAny<PassModel>()), Times.Once);
    }

    [Fact]
    public async Task getAllPassModels_Success()
    {
        // Arrabge
        var models = new List<PassModel>
        {
            new PassModel
            {
                labId = 1,
                studentId = 1,
                teacherId = 1,
                comment = "",
                isChecked = false,
                isPassed = false,
                mark = 0,
                report = new byte[0],
                fileExtension = "fileExtension"
            }
        };
        
        _passRepositoryMock
            .Setup(x => x.getAllPassModels())
            .ReturnsAsync(models);
        
        // Act
        
        var result = await _service.getAllPassModels();
        
        // Assert
        
        result.Should().BeEquivalentTo(models);
    }
}