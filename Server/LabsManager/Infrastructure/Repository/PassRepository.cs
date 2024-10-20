using LabsManager.Entities;
using Microsoft.AspNetCore.Components.Forms;

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
            
            var passModels = _context.PassModels.ToList();
            for(int i = 0; i < passModels.Count; i++)
            {
                var laba = _context.Labs.FirstOrDefault(l => l.id == passModels[i].labId);
                passModels[i].lab = new Laba
                {
                    id = laba.id,
                    name = laba.name,
                    teacherId = laba.teacherId,
                    description = laba.description,
                    materials = laba.materials,
                    FileName = laba.FileName,
                    file = laba.file,
                    LastTimeToPass = laba.LastTimeToPass
                };
                var st = _context.Students.FirstOrDefault(s => s.id == passModels[i].studentId);
                passModels[i].student = new Student
                {
                    id = st.id,
                    name = st.name,
                    group = st.group,
                    password = st.password,
                    login = st.login
                };
                var tc = _context.Teachers.FirstOrDefault(t => t.id == passModels[i].teacherId);
                passModels[i].teacher = new Teacher
                {
                    id = tc.id,
                    name = tc.name,
                    password = tc.password,
                    login = tc.login,
                    cafedra = tc.cafedra,
                    isAdmin = tc.isAdmin
                };
            }

            return passModels;
        }

        public async Task AddPassModel(PassModel passModel)
        {
            await _context.PassModels.AddAsync(passModel);

            await _context.SaveChangesAsync();
        }
    }
}
