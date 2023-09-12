using System.Linq.Expressions;

namespace GTRAssignment.RepositoryData.IRepository
{
    public interface ICommonRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        Task Add(TEntity entity);
        Task AddRange(IEnumerable<TEntity> entities);
        Task Update(TEntity entity);
        Task Remove(TEntity entity);
        Task RemoveRange(IEnumerable<TEntity> entities);
    }
}
