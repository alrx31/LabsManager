using domain.entities;
using infrastructure.persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.VisualBasic.ApplicationServices;
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
       Task<bool> checkIsFollow(Subject subject,int userId);
       Task createRegistration(Subject subject, int userId);
       Task deleteRegistration(Subject subject, int userId);
        List<FollowStudentSubject> getFollowsSubjectList(int userId);
        Task addSubject(Subject sbj);
        List<Subject> getTeacherSubjects(int teacherId);
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

        async Task<bool> ISubjectsRepository.checkIsFollow(Subject subject,int userId)
        {
            var res = await _context.follows.FirstOrDefaultAsync(e => e.subjectId == subject.id && e.studentId == userId);
            return res != null;
        }

        async Task ISubjectsRepository.createRegistration(Subject subject, int userId)
        {
            await _context.follows.AddAsync(new FollowStudentSubject
            {
                subjectId = subject.id,
                studentId = userId ,
                followDate = DateTime.UtcNow,
            });
            await _context.SaveChangesAsync();
        }

        async Task ISubjectsRepository.deleteRegistration(Subject subject, int userId)
        {
            var entity = await _context.follows.FirstOrDefaultAsync(e=>e.subjectId == subject.id && e.studentId == userId);
            _context.follows.Remove(entity);
            await _context.SaveChangesAsync();
        }

        List<FollowStudentSubject> ISubjectsRepository.getFollowsSubjectList(int userId)
        {
            var res = (from follows in _context.follows
                       where follows.studentId == userId
                       join subjects in _context.subjects
                       on follows.subjectId equals subjects.id
                       select new { follows.id,follows.followDate, follows.subjectId,follows.studentId,follows.student,subjects}).ToList();
            var res2 = new List<FollowStudentSubject>();

            foreach (var r in res)
            {
                res2.Add(new FollowStudentSubject()
                {
                    id = r.id,
                    subjectId = r.subjectId,
                    studentId = r.studentId,
                    followDate = r.followDate,
                    subject = r.subjects
                }) ;
            }

            return res2;
        }

        async Task ISubjectsRepository.addSubject(Subject sbj)
        {
            MessageBox.Show(sbj.ToString());

                await _context.subjects.AddAsync(sbj);
                await _context.SaveChangesAsync();
            
        }

        List<Subject> ISubjectsRepository.getTeacherSubjects(int teacherId)
        {
            var res = (from subject in _context.subjects
                       where subject.authorId == teacherId
                       join teacher in _context.teachers
                       on subject.authorId equals teacher.id
                       select new { subject.name, subject.needHours, subject.id, subject.authorId, subject.description, subject.author });

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
