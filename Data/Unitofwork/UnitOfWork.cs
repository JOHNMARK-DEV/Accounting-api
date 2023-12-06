using accounting_api.Data.Repositories;
using accounting_api.Models.Setup.Tax;
using accounting_api.Models.Setup.User;
using accounting_api.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

namespace accounting_api.Data.Unitofwork
{
    public class UnitOfWork : SetupRepositoryContainer, IUnitOfWork
    {
        private ApplicationDBContext? _dbContext;
        private ApplicationAtDBContext? _dbContextAt;
        public UnitOfWork(ApplicationDBContext dbContext, ApplicationAtDBContext dbContextAt) : base(dbContext, dbContextAt)
        {
            try
            {
                _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
                _dbContextAt = dbContextAt ?? throw new ArgumentNullException(nameof(dbContextAt));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}"); 
            }
        }  
        public void Dispose()
        {
            _dbContext.Dispose();
            _dbContextAt.Dispose();
        }
          
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
            _dbContextAt.SaveChanges();
        } 
    }
}
