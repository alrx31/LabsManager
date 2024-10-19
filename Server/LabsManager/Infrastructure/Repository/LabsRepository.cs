
using LabsManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace LabsManager.Infrastructure.Repository
{
    public interface ILabsRepository
    {
        Task<List<Laba>> GetAllLabs();
        Task AddLab(Laba lab);
        Task<Laba> GetLab(int id);
    }


    public class LabsRepository : ILabsRepository
    {
        private readonly ApplicationDbContext _context;

        public LabsRepository(ApplicationDbContext context) {
            _context = context;
        }


        public async Task<List<Laba>> GetAllLabs()
        {
            return await _context.Labs.ToListAsync();
        }

        public async Task AddLab(Laba lab)
        {
            await _context.Labs.AddAsync(lab);
            await _context.SaveChangesAsync();
        }

        public async Task<Laba> GetLab(int id)
        {
            return await _context.Labs.FirstOrDefaultAsync(l => l.id == id);
        }
    }
}
