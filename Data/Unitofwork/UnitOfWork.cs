using accounting_api.Data.Repositories; 
using accounting_api.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Data.Common;

namespace accounting_api.Data.Unitofwork
{
    public class UnitOfWork : SetupRepositoryContainer, IUnitOfWork
    {
        private ApplicationDBContext? _dbContext;
        private ApplicationAtDBContext? _dbContextAt;
        private readonly IDbContextTransaction _dbTransaction;
        public UnitOfWork(ApplicationDBContext dbContext, ApplicationAtDBContext dbContextAt) : base(dbContext, dbContextAt)
        {
            try
            {
                _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
                _dbContextAt = dbContextAt ?? throw new ArgumentNullException(nameof(dbContextAt));
                _dbTransaction = _dbContext.Database.BeginTransaction();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}"); 
            }
        }  
        public void Dispose()
        {
            try
            {
                // Commit changes if no exception occurred
                _dbTransaction?.Commit();
            }
            catch
            {
                // Rollback changes if an exception occurred during commit
                _dbTransaction?.Rollback();
            }
            finally
            {
                // Dispose of the transaction and database contexts
                _dbTransaction?.Dispose();
                _dbContext.Dispose();
                _dbContextAt.Dispose();
            }
        }
          
        public void SaveChanges()
        {
            try { 
                _dbContext.SaveChanges();
                _dbContextAt.SaveChanges();

                _dbTransaction?.Commit();

            } catch {
                _dbTransaction.Rollback();
                throw;
            }
            
        } 
    }
}
