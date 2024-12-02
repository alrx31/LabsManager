using LabsManager.DTO;
using LabsManager.Entities;
using LabsManager.Infrastructure.Repository;
using System.Text;

namespace LabsManager.Services
{
    public interface IPersonService
    {
        Task<Student> GetStudentById(int id);
        Task<LoginStudentResponse> LoginStudent(LoginDTO model);
        Task<LoginTeacherResponse?> LoginTeacher(LoginDTO model);
        Task RegisterStudent(RegisterStudentDTO model);
        Task RegisterTeacher(RegisterTeacherDTO model);
    }

    public class PersonService
        (
            IPersonRepository personRepository,
            IPassRepository passRepository
        ) : IPersonService
    {

        private readonly IPersonRepository _personRepository = personRepository;
        private readonly IPassRepository _passRepository = passRepository;

        public async Task<Student> GetStudentById(int id)
        {
            return await _personRepository.getStudentById(id);
        }

        public async Task<LoginStudentResponse> LoginStudent(LoginDTO model)
        {
            var response  = new LoginStudentResponse();

            if (model == null)
            {
                return response;
            }

            if (string.IsNullOrEmpty(model.Login) || string.IsNullOrEmpty(model.Password))
            {
                return response;
            }


            model.Password = this.getHash(model.Password);

            var student = await _personRepository.GetStudentByLogin(model.Login);

            if(student is null)
            {
                return response;
            }

            if (model.Password == student.password)
            {
                response.IsLoggedIn = true;
                response.Student = student;
            }

            var models = (await _passRepository.getAllPassModels()).Where(m => m.studentId == student.id);

            foreach (var p in response.Student.passModels)
            {
                p.student = null;
            }

            return response;
        }

        public async Task<LoginTeacherResponse?> LoginTeacher(LoginDTO model)
        {
            var response = new LoginTeacherResponse();

            if (model == null)
            {
                return response;
            }

            if (string.IsNullOrEmpty(model.Login) || string.IsNullOrEmpty(model.Password))
            {
                return response;
            }


            model.Password = this.getHash(model.Password);

            var teacher = await _personRepository.GetTeacherByLogin(model.Login);

            if(teacher is null)
            {
                return response;
            }

            if (model.Password == teacher.password)
            {
                response.IsLoggedIn = true;
                response.Teacher = teacher;
            }

            return response;
        }

        public async Task RegisterStudent(RegisterStudentDTO model)
        {
            var student = await _personRepository.GetStudentByLogin(model.Login);

            if(student is not null)
            {
                throw new Exception("Student already exists");
            }

            var st = new Student
            {
                name = model.Name,
                login = model.Login,
                password = this.getHash(model.Password),
                group = model.Group,
            };

            await _personRepository.AddStudent(st);
        }

        public async Task RegisterTeacher(RegisterTeacherDTO model)
        {
            var teacher = await _personRepository.GetTeacherByLogin(model.Login);

            if (teacher is not null)
            {
                throw new Exception("Teacher already exists");
            }

            var t = new Teacher
            {
                name = model.Name,
                login = model.Login,
                password = this.getHash(model.Password),

                isAdmin = model.Login == "admin",
                cafedra = model.Cafedra
            };

            await _personRepository.AddTeacher(t);
        }

        private string getHash(string pass)
        {
            var data = System.Text.Encoding.ASCII.GetBytes(pass);

            data = System.Security.Cryptography.SHA256.HashData(data);

            return Encoding.ASCII.GetString(data);
        }
    }
}
