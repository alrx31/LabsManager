using LabsManager.DTO;
using LabsManager.Infrastructure.Repository;
using System.Text;

namespace LabsManager.Services
{
    public interface IPersonService
    {
        Task<LoginResponse> LoginStudent(LoginDTO model);
    }

    public class PersonService
        (
            IPersonRepository personRepository
        ): IPersonService
    {

        private readonly IPersonRepository _personRepository = personRepository;

        public async Task<LoginResponse> LoginStudent(LoginDTO model)
        {
            var response  = new LoginResponse();
            model.Password = this.getHash(model.Password);

            var user = await _personRepository.GetStudentByLogin(model.Login);

            // TODO

            return response;
        }
        
        private string getHash(string pass)
        {
            var data = System.Text.Encoding.ASCII.GetBytes(pass);
            data = System.Security.Cryptography.SHA256.HashData(data);

            return Encoding.ASCII.GetString(data);
        }
    }
}
