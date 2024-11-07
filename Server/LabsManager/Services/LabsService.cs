
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
        Task<Stats> GetStats();
    }

    public class LabsService : ILabsService
    {
        private readonly ILabsRepository _labsRepository;
        private readonly IPassRepository _PassLabsRepository;
        private readonly IPersonRepository _personRepository;
        public LabsService(
            ILabsRepository labsRepository,
            IPassRepository passRepository,
            IPersonRepository personRepository
            )
        {
            _labsRepository = labsRepository;
            _PassLabsRepository = passRepository;
            _personRepository = personRepository;
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

        public async Task<Stats> GetStats()
        {
            var stat = new Stats();

            var students =await  _labsRepository.GetAllStudents();
            
            var labs = await _labsRepository.GetAllLabs();
            var passmodels = await _PassLabsRepository.getAllPassModels();
            
            stat.labCounts = labs.Count;
            stat.tryPassCount = passmodels.Count;
            
            stat.passed = passmodels.Where(m=> m.isPassed).Count();
            stat.notPassed = passmodels.Where(m => !m.isPassed).Count();
            stat.notChecked = passmodels.Where(m => !m.isChecked).Count();
            
            stat.percentOfPassed = (int)((stat.passed / (float)stat.tryPassCount) * 100);
            stat.averagePassed = passmodels.Where(m => m.isPassed).Average(m => m.mark);
            stat.averageWithNotPassed = passmodels.Average(m => m.mark);
            stat.averageLabsInOneStudent = passmodels.Count / (float)students.Count;
            
            return stat;
        }
    }
}
