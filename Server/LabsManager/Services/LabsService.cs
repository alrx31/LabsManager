
using LabsManager.DTO;
using LabsManager.Entities;
using LabsManager.Infrastructure.Repository;

namespace LabsManager.Services
{
    public interface ILabsService
    {
        Task<List<Laba>> GetAllLabs();
        Task AddLab(AddLabDTO model);
        Task<Laba> GetLab(int id);
        Task DeleteLab(int labId);
    }

    public class LabsService : ILabsService
    {
        private readonly ILabsRepository _labsRepository;

        public LabsService(ILabsRepository labsRepository)
        {
            _labsRepository = labsRepository;
        }

        public async Task<List<Laba>> GetAllLabs()
        {
            return await _labsRepository.GetAllLabs();
        }

        public async Task AddLab(AddLabDTO model)
        {
            var lab = new Laba
            {
                name = model.Name,
                description = model.Description,
                materials = model.Materials,
                file = ConvertFileToBytes(model.File),
                teacherId = model.TeacherId,
                FileName = model.File.FileName,
                LastTimeToPass = model.LastTimeToPass
            };
            await _labsRepository.AddLab(lab);
        }

        private byte[] ConvertFileToBytes(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }

        public async Task<Laba> GetLab(int id)
        {
            var laba = await _labsRepository.GetLab(id);

            if (laba == null)
            {
                throw new Exception("Lab not found");
            }

            return laba;
        }

        public async Task DeleteLab(int labId)
        {
            var lab = await _labsRepository.GetLab(labId);

            if (lab is null)
            {
                throw new Exception("lab not found");
            }
            
            await _labsRepository.DeleteLab(lab);
        }
    }
}
