using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRP.Contracts.DataContracts
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork GetUnitOfWork();
    }


    public interface IUnitOfWork : IDisposable
    {
        //IDocumentRepository DocumentMetaData { get; }
        //IExceptionLogRepository Exceptions { get; set; }
        //IUserRepository Users { get; set; }
        //IRoleRepository Roles { get; set; }
        //IRepresentativeRepository Representatives { get; set; }
        ICandidateRepository CandidateRepository { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}
