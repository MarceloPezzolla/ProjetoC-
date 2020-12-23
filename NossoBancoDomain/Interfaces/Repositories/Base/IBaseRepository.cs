using System;
using System.Collections.Generic;

namespace NossoBancoDomain.Interfaces.Repositories.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
         TEntity FetchBryId(int id);
         IEnumerable<TEntity> FetchAll();
         void UpDate(TEntity entity);
         void Delete(TEntity entity);
         void Insert(TEntity entity);
    }
}