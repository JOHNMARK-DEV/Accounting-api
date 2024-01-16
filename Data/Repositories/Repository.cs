
using accounting_api.Cache;
using accounting_api.Data;
using accounting_api.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace accounting_api.Repositories
{
    public class Repository<T1, T2> : IRepository<T1, T2> where T1 : class where T2 : class
    {
        private ApplicationDBContext _dbContext;
        private ApplicationAtDBContext _dbContextAt; 

        public Repository(ApplicationDBContext dbContext, ApplicationAtDBContext dbContextAt)
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
        void IRepository<T1,T2>.Add(T1 entity1,T2 entity2)
        {
            try
            {
                CacheData.Data.Remove(typeof(T1).Name);

                _dbContext.Set<T1>().Add(entity1);
                _dbContextAt.Set<T2>().Add(entity2);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        async Task<IEnumerable<T1>> IRepository<T1, T2>.GetAll()
        {
            IEnumerable<T1> data = null;
             
            checkAgain:
            if (CacheData.Data.TryGetValue(typeof(T1).Name, out var values))
            {
                data =  (IEnumerable<T1>)values;
            }
            else
            {
                //CacheData.Data = new Dictionary<string, System.Collections.IList>();
                CacheData.Data.Add(typeof(T1).Name, await _dbContext.Set<T1>().ToListAsync());
                goto checkAgain;
            }

            return data;
        }

        public T1 GetById(int id)
        {
             return _dbContext.Set<T1>().Find(id);
        }

        void IRepository<T1, T2>.Remove(T1 entity1,T2 entity2)
        {
            CacheData.Data.Remove(typeof(T1).Name);

            _dbContextAt.Set<T2>().Add(entity2);
            _dbContext.Set<T1>().Remove(entity1); 
        }

        void IRepository<T1, T2>.Update(T1 entity1, T2 entity2)
        {
<<<<<<< Updated upstream
            CacheData.Data = null;
=======
            CacheData.Data.Remove(typeof(T1).Name); 

>>>>>>> Stashed changes
            _dbContextAt.Set<T2>().Add(entity2);
            _dbContext.Set<T1>().Update(entity1);
        }
    }
}
