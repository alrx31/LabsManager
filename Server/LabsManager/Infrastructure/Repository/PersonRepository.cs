
using LabsManager.DTO;
using LabsManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace LabsManager.Infrastructure.Repository
{
    public interface IPersonRepository
    {
        Task AddStudent(Student model);
        Task AddTeacher(Teacher model);
        Task<Student> getStudentById(int id);
        Task<Student?> GetStudentByLogin(string login);
        Task<Teacher?> GetTeacherByLogin(string login);
    }

    public class PersonRepository
        (
            ApplicationDbContext context
        ) : IPersonRepository
    {
        private readonly ApplicationDbContext _context = context;

        public async Task AddTeacher(Teacher model)
        {
            await _context.Teachers.AddAsync(model);

            await _context.SaveChangesAsync();
        }

        public async Task AddStudent(Student model)
        {
            await _context.Students.AddAsync(model);

            await _context.SaveChangesAsync();
        }

        public async Task<Student?> GetStudentByLogin(string login)
        {
            return await _context.Students.FirstOrDefaultAsync(st => st.login == login);
        }

        public async Task<Teacher?> GetTeacherByLogin(string login)
        {
            return await _context.Teachers.FirstOrDefaultAsync(st => st.login == login);
        }

        public async Task<Student> getStudentById(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(st => st.id == id);
        }
    }
}
