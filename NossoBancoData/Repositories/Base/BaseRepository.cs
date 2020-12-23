using NossoBancoDomain.Interfaces.Repositories.Base;
using NossoBancoDomain.Entities;
using NossoBancoData.Context;

namespace NossoBancoData.Repositories.Base
{
    public class BaseRepository : IDisposible, IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public TEntity FetchBryId(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
         public IEnumerable<TEntity> FetchAll()
         {
             return _context.Set<TEntity>().ToList();
         }
         public void UpDate(TEntity entity)
         {
             _context.Entry(TEntity).State = EntityState.Modified;
             _context.SaveChanges();
         }
         public void Delete(TEntity entity)
         {
             return _context.Set<TEntity>().Remove(entity);
             _context.SaveChanges();
         }
         public void Insert(TEntity entity)
         {
             return _context.Set<TEntity>().Add(entity);
             _context.SaveChanges();
         }
    }
}