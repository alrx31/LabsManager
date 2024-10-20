using LabsManager.DTO;
using LabsManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace LabsManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController
        (
            IPersonService personService
        ) : ControllerBase
    {
        private readonly IPersonService _personService = personService;

        [HttpPost("student-login")]
        public async Task<IActionResult> LoginStudent([FromBody] LoginDTO model)
        {
            return Ok(await _personService.LoginStudent(model));
        }

        [HttpPost("teacher-login")]
        public async Task<IActionResult> LoginTeacher([FromBody] LoginDTO model)
        {
            return Ok(await _personService.LoginTeacher(model));
        }

        [HttpPut("student-register")]
        public async Task<IActionResult> RegisterStudent([FromBody] RegisterStudentDTO model)
        {
            await _personService.RegisterStudent(model);
            
            return Ok();
        }

        [HttpPut("teacher-register")]
        public async Task<IActionResult> RegisterTeacher([FromBody] RegisterTeacherDTO model)
        {
            await _personService.RegisterTeacher(model);

            return Ok();
        }

        [HttpGet("student/{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            return Ok(await _personService.GetStudentById(id));
        }
    }
}
