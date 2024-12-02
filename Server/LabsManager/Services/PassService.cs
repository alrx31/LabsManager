
using LabsManager.DTO;
using LabsManager.Entities;
using LabsManager.Infrastructure.Repository;
using Microsoft.AspNetCore.Components.Forms;

namespace LabsManager.Services
{
    public interface IPassService
    {
        Task AddPassModel(AddPassModelDTO model);
        Task<List<PassModel>> getAllPassModels();
        Task PutMarkToLaboratory(int pasLabId, int mark);
    }

    public class PassService : IPassService
    {
        private readonly IPassRepository _passRepository;
        private readonly ILabsRepository _labsRepository;

        public PassService(IPassRepository passRepository, ILabsRepository labsRepository)
        {
            _passRepository = passRepository;
            _labsRepository = labsRepository;
        }

        public async Task AddPassModel(AddPassModelDTO model)
        {
            var passModel = new PassModel
            {
                labId = model.labId,
                studentId = model.studentId,
                teacherId = model.teacherId,
                comment = "",
                isChecked = false,
                isPassed = false,
                mark = 0,
                report = ConvertFileToBytes(model.report),
                fileExtension = model.report.FileName
            };

            await _passRepository.AddPassModel(passModel);
        }

        public async Task<List<PassModel>> getAllPassModels()
        {
            var model = await _passRepository.getAllPassModels();

            if (model is null)
            {
                throw new Exception("no pass models were found");
            }
            
            foreach(var l in model)
            {
                l.student.passModels = null;
                
                l.lab = await _labsRepository.GetLab(l.labId);
                l.lab.passLabs = null;
            }

            return model;
        }

        public async Task PutMarkToLaboratory(int pasLabId, int mark)
        {
            var lab = await _passRepository.GetPassModelById(pasLabId);
            
            lab.isChecked = true;
            lab.mark = mark;
            lab.isPassed = mark >= 4;

            await _passRepository.UpdatePassModel(lab);
        }

        private byte[] ConvertFileToBytes(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
