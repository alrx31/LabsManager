using LabsManager.DTO;
using LabsManager.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace LabsManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LabsController
        (
            ILabsService labsService
        ) :ControllerBase
    {
        private readonly ILabsService _labsService = labsService;


        [HttpGet]
        public async Task<IActionResult> GetAllLabs()
        {
            return Ok(await _labsService.GetAllLabs());
        }

        [HttpPut]
        public async Task<IActionResult> AddLab([FromForm] AddLabDTO model)
        {
            if (model.File == null || model.File.Length == 0)
            {
                return BadRequest("File is not selected.");
            }

            await _labsService.AddLab(model);

            return Ok(new { Message = "Lab added successfully" });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLab(int id)
        {
            var lab = await _labsService.GetLab(id);

            if (lab == null)
            {
                return NotFound();
            }

            var res = new
            {
                lab.id,
                lab.name,
                lab.description,
                lab.materials,
                FileBase64 = Convert.ToBase64String(lab.file),
                lab.teacherId,
                Teacher = lab.teacher,
                passLabs = lab.passLabs,
                FileExtension = Path.GetExtension(lab.FileName),
                lab.LastTimeToPass
            };

            return Ok(res);
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        

        [HttpDelete("{labId}")]
        public async Task<IActionResult> DeleteLab(int labId)
        {
            await _labsService.DeleteLab(labId);
            return Ok();
        }

        [HttpGet("stats")]
        public async Task<IActionResult> GetStats()
        {
            return Ok(await _labsService.GetStats());
        }
    }
}
