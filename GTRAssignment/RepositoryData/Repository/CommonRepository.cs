using GTRAssignment.Data;
using GTRAssignment.RepositoryData.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GTRAssignment.RepositoryData.Repository
{
    public class CommonRepository<TEntity> : ICommonRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDBContext _context;

        public CommonRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public Task Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
