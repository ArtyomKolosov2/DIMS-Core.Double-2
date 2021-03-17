using System.Linq;

namespace DIMS_Core.DataAccessLayer.Interfaces
{
    public interface IReadOnlyRepository<TEntity> where TEntity : class 
    {
        IQueryable<TEntity> GetAll();
    }
}