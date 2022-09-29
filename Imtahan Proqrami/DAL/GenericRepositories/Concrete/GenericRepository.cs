using Imtahan_Proqrami.DAL.DatabaseContext;
using Imtahan_Proqrami.DAL.GenericRepositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imtahan_Proqrami.DAL.GenericRepositories.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {

        protected DataContext _dataContext;
        private DbSet<TEntity> _dbset;
        public GenericRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _dbset = dataContext.Set<TEntity>();
        }

        public async Task Add(TEntity entity)
        {
            await _dbset.AddAsync(entity);
        }

        public async Task Delete(int Id)
        {
            TEntity entity = await _dbset.FindAsync(Id);
            _dbset.Remove(entity);
        }

        public async Task<List<TEntity>> Get()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<TEntity> GetId(int Id)
        {
            return await _dbset.FindAsync(Id);
        }

        public async Task Update(TEntity entity)
        {
            _dbset.Update(entity);
        }
    }
}
