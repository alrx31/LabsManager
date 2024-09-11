using domain.entities;
using infrastructure.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infastructure.repositories
{
    internal interface IPersonRepository
    {
        internal PersonsBase Login(string login, string password);
        internal int RegisterStudent(Student model);
        internal int RegisterTeacher(Teacher model);
    }

    internal class PersonRepository: IPersonRepository
    {

        private readonly LabsManagerDbContext _context;

        public PersonRepository()
        {
            _context = new LabsManagerDbContext();
        }

        PersonsBase IPersonRepository.Login(string login, string password)
        {
            PersonsBase person = _context.students.FirstOrDefault(p => p.login == login && p.password == password);
            if(person == null)
            {
                person = _context.teachers.FirstOrDefault(p => p.login == login && p.password == password);
            }

            return person;
        }

        int IPersonRepository.RegisterStudent(Student model)
        {
            
                _context.students.Add(model);
                _context.SaveChanges();
            
            return 1;
        }

        int IPersonRepository.RegisterTeacher(Teacher model)
        {
            _context.teachers.Add(model);
            _context.SaveChanges();
            return 1;
        }
    }
}
