using accounting_api.Data.Repositories;
using accounting_api.Models.Setup;
using accounting_api.Models.Setup.Book;
using accounting_api.Models.Setup.Chart;
using accounting_api.Models.Setup.Others;
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
        public IRepository<Setup_Bank_model, Setup_Bank_model_at> Setup_Bank_model => new Repository<Setup_Bank_model, Setup_Bank_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Currency_model, Setup_Currency_model_at> Setup_Currency_model => new Repository<Setup_Currency_model, Setup_Currency_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Industry_model, Setup_Industry_model_at> Setup_Industry_model => new Repository<Setup_Industry_model, Setup_Industry_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Category_model, Setup_Category_model_at> Setup_Category_model => new Repository<Setup_Category_model, Setup_Category_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Department_model, Setup_Department_model_at> Setup_Department_model => new Repository<Setup_Department_model, Setup_Department_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Project_model, Setup_Project_model_at> Setup_Project_model => new Repository<Setup_Project_model, Setup_Project_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Terms_model, Setup_Terms_model_at> Setup_Terms_model => new Repository<Setup_Terms_model, Setup_Terms_model_at>(_dbContext, _dbContextAt);

        public IRepository<Setup_Outputvat_model, Setup_Outputvat_model_at> Setup_Outputvat_model => new Repository<Setup_Outputvat_model, Setup_Outputvat_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Inputvat_model, Setup_Inputvat_model_at> Setup_Inputvat_model => new Repository<Setup_Inputvat_model, Setup_Inputvat_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Finaltax_model, Setup_Finaltax_model_at> Setup_Finaltax_model => new Repository<Setup_Finaltax_model, Setup_Finaltax_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Expandedtax_model, Setup_Expandedtax_model_at> Setup_Expandedtax_model => new Repository<Setup_Expandedtax_model, Setup_Expandedtax_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Users_model, Setup_Users_model_at> Setup_Users_model => new Repository<Setup_Users_model, Setup_Users_model_at>(_dbContext, _dbContextAt);

        //Book   
        public IRepository<Setup_Book_model, Setup_Book_model_at> Setup_Book_model => new Repository<Setup_Book_model, Setup_Book_model_at>(_dbContext, _dbContextAt);

        //Chart   
        public IRepository<Setup_Chartclass_model, Setup_Chartclass_model_at> Setup_Chartclass_model => new Repository<Setup_Chartclass_model, Setup_Chartclass_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Chartgroup_model, Setup_Chartgroup_model_at> Setup_Chartgroup_model => new Repository<Setup_Chartgroup_model, Setup_Chartgroup_model_at>(_dbContext, _dbContextAt);
        public IRepository<Setup_Chartofaccount_model, Setup_Chartofaccount_model_at> Setup_Chartofaccount_model => new Repository<Setup_Chartofaccount_model, Setup_Chartofaccount_model_at>(_dbContext, _dbContextAt);

        //Aging
        public IRepository<Setup_Aging_model, Setup_Aging_model_at> Setup_Aging_model => new Repository<Setup_Aging_model, Setup_Aging_model_at>(_dbContext, _dbContextAt);

        //Company
        public IRepository<Setup_Company_model, Setup_Company_model_at> Setup_Company_model => new Repository<Setup_Company_model, Setup_Company_model_at>(_dbContext, _dbContextAt);

        //Company
        public IRepository<Setup_Businesspartner_model, Setup_Businesspartner_model_at> Setup_Businesspartner_model => new Repository<Setup_Businesspartner_model, Setup_Businesspartner_model_at>(_dbContext, _dbContextAt);

    }
      
}
