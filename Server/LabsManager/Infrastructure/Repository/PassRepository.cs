using LabsManager.Entities;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace LabsManager.Infrastructure.Repository
{
    public interface IPassRepository
    {
        Task AddPassModel(PassModel passModel);
        Task<List<PassModel>> getAllPassModels();
        Task<PassModel> GetPassModelById(int pasLabId);
        Task UpdatePassModel(PassModel lab);
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
            return await _context.PassModels
                .Include(u=>u.student)
                .ToListAsync();
        }

        public async Task AddPassModel(PassModel passModel)
        {
            await _context.PassModels.AddAsync(passModel);

            await _context.SaveChangesAsync();
        }

        public async Task<PassModel> GetPassModelById(int pasLabId)
        {
            return await _context.PassModels.FirstOrDefaultAsync(l=>l.id == pasLabId);
        }

        public async Task UpdatePassModel(PassModel lab)
        {
            _context.Update(lab);

            await _context.SaveChangesAsync();
        }
    }
}
