using LabsManager.DTO;
using LabsManager.Entities;
using LabsManager.Infrastructure.Repository;
using System.Text;

namespace LabsManager.Services
{
    public interface IPersonService
    {
        Task<LoginStudentResponse> LoginStudent(LoginDTO model);
        Task<LoginTeacherResponse?> LoginTeacher(LoginDTO model);
        Task RegisterStudent(RegisterStudentDTO model);
        Task RegisterTeacher(RegisterTeacherDTO model);
    }

    public class PersonService
        (
            IPersonRepository personRepository
        ) : IPersonService
    {

        private readonly IPersonRepository _personRepository = personRepository;

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

            if (model.Password == student.Password)
            {
                response.IsLoggedIn = true;
                response.Student = student;
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

            if (model.Password == teacher.Password)
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
                Name = model.Name,
                Login = model.Login,
                Password = this.getHash(model.Password),
                Group = model.Group,
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
                Name = model.Name,
                Login = model.Login,
                Password = this.getHash(model.Password),

                IsAdmin = model.Login == "admin",
                Cafedra = model.Cafedra
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
