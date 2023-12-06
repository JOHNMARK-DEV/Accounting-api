using accounting_api.Data.Repositories;
using accounting_api.Models.Setup.Tax;
using accounting_api.Models.Setup.User;
using accounting_api.Repositories;
using Microsoft.EntityFrameworkCore;

namespace accounting_api.Data
{
    public class SetupRepositoryContainer
    {
        protected readonly ApplicationDBContext _dbContext;
        protected readonly ApplicationAtDBContext _dbContextAt;
        public SetupRepositoryContainer(ApplicationDBContext dbContext, ApplicationAtDBContext dbContextAt)
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

        public IRepository<Setup_Outputvat_model, Setup_Outputvat_model_at> Setup_Outputvat_model => new Repository<Setup_Outputvat_model, Setup_Outputvat_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Inputvat_model, Setup_Inputvat_model_at> Setup_Inputvat_model => new Repository<Setup_Inputvat_model, Setup_Inputvat_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Finaltax_model, Setup_Finaltax_model_at> Setup_Finaltax_model => new Repository<Setup_Finaltax_model, Setup_Finaltax_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Expandedtax_model, Setup_Expandedtax_model_at> Setup_Expandedtax_model => new Repository<Setup_Expandedtax_model, Setup_Expandedtax_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Users_model, Setup_Users_model_at> Setup_Users_model => new Repository<Setup_Users_model, Setup_Users_model_at>(_dbContext, _dbContextAt);

    }
}
