namespace accounting_api.Data.Repositories
{
    public interface IRepository<T1, T2> where T1 : class
    {
        public void Add(T1 entity1, T2 entity2);
        public void Remove(T1 entity1, T2 entity2);
        public void Update(T1 entity1, T2 entity2);

        public T1 GetById(int id);
        public Task<IEnumerable<T1>> GetAll();  

    }
}
