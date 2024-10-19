
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
    }

    public class PassService : IPassService
    {
        private readonly IPassRepository _passRepository;

        public PassService(IPassRepository passRepository) {
            _passRepository = passRepository;
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
                report = ConvertFileToBytes(model.report)
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

            return model;
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
