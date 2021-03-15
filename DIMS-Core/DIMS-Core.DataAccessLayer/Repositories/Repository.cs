using DIMS_Core.Common.Helpers;
using DIMS_Core.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    /// <summary>
    /// Generic Repository
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class Repository<TEntity> : IDisposable, IRepository<TEntity>
        where TEntity : class
    {
        private readonly DbContext _context;
        protected readonly DbSet<TEntity> _set;

        protected Repository(DbContext context)
        {
            _context = context;
            _set = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _set.AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {

            RepositoriesExceptionHelper.ThrowIfIdInvalid(id, nameof(GetById));

            var objectFromDB = await _set.FindAsync(id);

            RepositoriesExceptionHelper.ThrowIfEntityObjectNotExist(objectFromDB, nameof(objectFromDB), nameof(GetById));

            return objectFromDB;
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            var createdEntity = await _set.AddAsync(entity);

            return createdEntity.Entity;
        }

        public TEntity Update(TEntity entity)
        {
            var updatedEntity = _set.Update(entity);

            return updatedEntity.Entity;
        }

        public async Task Delete(int id)
        {
            var foundedEntity = await GetById(id);

            _set.Remove(foundedEntity);
        }

        #region Disposable

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            _context.Dispose();

            _disposed = true;
        }

        ~Repository()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion Disposable
    }
}