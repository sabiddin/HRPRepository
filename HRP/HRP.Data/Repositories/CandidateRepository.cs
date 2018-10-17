using HRP.Contracts.DataContracts;
using HRP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRP.Data.Repositories
{
    public class CandidateRepository: BaseRepository<Candidate>,ICandidateRepository
    {
        public CandidateRepository(IDboContext db): base(db)
        {

        }
    }
}
