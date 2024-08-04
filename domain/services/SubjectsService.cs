using Accessibility;
using domain.entities;
using LabsManager.infastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.domain.services
{
    public interface ISubjectsService
    {
        Task<List<Subject>> getAllSubjects();
        Task<bool> checkFollow(Subject subject,int userId);
        Task createRegistration(Subject subject,int userId);
        Task canselRegistration(Subject subject,int userId);
        List<FollowStudentSubject> getFollowsSubjectsList(int userId);
        Task AddSubject(Subject sbj);
    }

    public class SubjectsService: ISubjectsService
    {
        private readonly ISubjectsRepository _repository;

        public SubjectsService()
        {
            _repository = new SubjectsRepository();
        }
    
        async Task<List<Subject>> ISubjectsService.getAllSubjects()
        {
            return await _repository.getAllSubjects();
        }

        async Task<bool> ISubjectsService.checkFollow(Subject subject,int userId)
        {
            return await _repository.checkIsFollow(subject,userId);
        }

        async Task ISubjectsService.createRegistration(Subject subject, int userId)
        {
            if(userId <= 0)
            {
                MessageBox.Show("Неверный юзер");
            }
            if(subject.id <= 0)
            {
                MessageBox.Show("Неверный предмет");
            }
            await _repository.createRegistration(subject, userId);
        }

        async Task ISubjectsService.canselRegistration(Subject subject, int userId)
        {
            if (userId <= 0)
            {
                MessageBox.Show("Неверный юзер");
            }
            if (subject.id <= 0)
            {
                MessageBox.Show("Неверный предмет");
            }

            await _repository.deleteRegistration(subject,userId);  
        }

        List<FollowStudentSubject> ISubjectsService.getFollowsSubjectsList(int userId)
        {
            return _repository.getFollowsSubjectList(userId);
        }

        async Task ISubjectsService.AddSubject(Subject sbj)
        {
            await _repository.addSubject(sbj);
        }
    }
}
