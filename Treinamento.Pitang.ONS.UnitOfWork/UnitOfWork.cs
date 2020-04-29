using Microsoft.Extensions.Logging;
using Pitang.Treinamento.ONS.Data.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Pitang.ONS.Repository;

namespace Treinamento.Pitang.ONS.UnitOfWork
{
    class UnitOfWork
    {
        private readonly DataContext _treinamentoDbContext;
        private readonly ILogger _logger;
        private IUserRepository _userRepository;

        public UnitOfWork(DataContext treinamentoDbContext, ILogger<UnitOfWork> logger)
        {
            _treinamentoDbContext = treinamentoDbContext;
            _logger = logger;
            ForceBeginTransaction();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ForceBeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void SetIsolationLevel(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }
    }
}
