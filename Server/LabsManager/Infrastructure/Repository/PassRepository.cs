using LabsManager.Entities;

namespace LabsManager.Infrastructure.Repository
{
    public interface IPassRepository
    {
        Task AddPassModel(PassModel passModel);
        Task<List<PassModel>> getAllPassModels();
    }

    public class PassRepository : IPassRepository
    {
        public ApplicationDbContext _context { get; set; }

        public PassRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PassModel>> getAllPassModels()
        {
            return _context.PassModels.ToList<PassModel>();
        }

        public async Task AddPassModel(PassModel passModel)
        {
            await _context.PassModels.AddAsync(passModel);

            await _context.SaveChangesAsync();
        }
    }
}
