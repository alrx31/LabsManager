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
    }
}
