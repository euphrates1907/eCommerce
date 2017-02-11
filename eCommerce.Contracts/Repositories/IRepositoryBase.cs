using System.Linq;

namespace eCommerce.Contracts.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Commit();
        void Delete(TEntity entity);
        void Dispose();
        IQueryable<TEntity> GetAll();
        TEntity GetById(object id);
        IQueryable<TEntity> GetFullObject(object id);
        IQueryable<TEntity> GetPaged(int top = 20, int skip = 0, object orderBy = null, object filter = null);
        void Insert(TEntity entity);
        void Update(TEntity entity);
    }
}