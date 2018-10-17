using HRP.Contracts.DataContracts;
using HRP.Contracts.ServiceContracts;
using HRP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRP.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        public CandidateService(ICandidateRepository candidateRepository, IUnitOfWorkFactory unitOfWorkFactory)
        {
            _candidateRepository = candidateRepository;
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public void AddCandidate(Candidate candidate)
        {
            using (var uow = _unitOfWorkFactory.GetUnitOfWork())
            {
                uow.CandidateRepository.Add(candidate);
                uow.SaveChanges();
            }
        }

        public List<Candidate> GetCandidates()
        {
            return _candidateRepository.FindAll();
        }
    }
}
