using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using VP.BackgroundJobManager.EntityFrameworkCore;

namespace VP.BackgroundJobManager
{
    public class TransactionRepository : EfCoreRepository<BackgroundJobManagerDbContext, Transaction, Guid>, ITransactionRepository
    {
        public TransactionRepository(IDbContextProvider<BackgroundJobManagerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
