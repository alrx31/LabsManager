using LabsManager.DTO;
using LabsManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace LabsManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PassController:ControllerBase
    {
        private readonly IPassService _passService;

        public PassController(IPassService passService)
        {
            _passService = passService;
        }

        [HttpGet]
        public async Task<IActionResult> getAllPassModels()
        {
            return Ok(await _passService.getAllPassModels());
        }

        [HttpPut]
        public async Task<IActionResult> addPassLabModel([FromForm] AddPassModelDTO model)
        {
            await _passService.AddPassModel(model);

            return Ok();
        }
    }
}
