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
    }
}
