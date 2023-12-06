namespace accounting_api.Data.Unitofwork
{
    public interface IUnitOfWork:IDisposable
    {
        void SaveChanges(); 
    }
}
 