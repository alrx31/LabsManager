using domain.entities;
using infastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.services
{
    public interface IAuthService
    {
        PersonsBase? Login(string login, string password);
        int RegisterStudent(Student model);
        int RegisterTeacher(Teacher model);
    }


    public class AuthService: IAuthService
    {
        private readonly IPersonRepository _repository;

        public AuthService()
        {
            _repository = new PersonRepository();
        }



        PersonsBase? IAuthService.Login(string login, string password)
        {
            if (login == "admin" && password == "admin")
            {
                return null;
            }
            if(login =="" || password == "")
            {
                return null;
            }
            password = getHash(password);
            var result = _repository.Login(login,password);


            return result;
        }

        public int RegisterStudent(Student model)
        {
            if (model == null)
            {
                return 0;
            }
            if(model.login == "" || model.password == "")
            {
                return 0;
            }
            model.password = getHash(model.password);

            return _repository.RegisterStudent(model);
        }

        public int RegisterTeacher(Teacher model)
        {
            if (model == null)
            {
                return 0;
            }
            if (model.login == "" || model.password == "")
            {
                return 0;
            }
            model.password = getHash(model.password);
            return _repository.RegisterTeacher(model);
        }

        private string getHash(string password)
        {
            var key = "LASifj2po-123LSKJF#INO2";
            var data = Encoding.UTF8.GetBytes(password + key);
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                var hash = sha.ComputeHash(data);
                return Convert.ToBase64String(hash);
            }

        }
    }
}
