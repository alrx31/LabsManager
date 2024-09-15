
using LabsManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace LabsManager.Infrastructure.Repository
{
    public interface IPersonRepository
    {
        Task<Student?> GetStudentByLogin(string login);
    }

    public class PersonRepository
        (
            ApplicationDbContext context
        ) : IPersonRepository
    {
        private readonly ApplicationDbContext _context;

        public async Task<Student?> GetStudentByLogin(string login)
        {
            return await _context.Students.FirstOrDefaultAsync(st => st.Login == login);
        }
    }
}
