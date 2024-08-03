using domain.entities;
using infrastructure.persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.infastructure.repositories
{

    public interface ISubjectsRepository
    {
       Task<List<Subject>> getAllSubjects();
    }

    public class SubjectsRepository: ISubjectsRepository
    {
        private readonly LabsManagerDbContext _context;

        public SubjectsRepository()
        {
            _context = new LabsManagerDbContext();
        }

        async Task<List<Subject>> ISubjectsRepository.getAllSubjects()
        {
            var res = (from subject in _context.subjects
                       join teacher in _context.teachers
                       on subject.authorId equals teacher.id
                       select new { subject.name,subject.needHours, subject.id, subject.authorId, subject.description, subject.author });
            
            var res2 = new List<Subject>();

            foreach (var r in res)
            {
                res2.Add(new Subject()
                {
                    id = r.id,
                    name = r.name,
                    authorId = r.authorId,
                    description = r.description,
                    author = r.author,
                    needHours = r.needHours
                });
            }

            return res2;            
        }


    }
}
