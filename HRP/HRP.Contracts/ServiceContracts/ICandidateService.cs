using HRP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRP.Contracts.ServiceContracts
{
    public interface ICandidateService
    {
        List<Candidate> GetCandidates();
        void AddCandidate(Candidate candidate);
    }
}
