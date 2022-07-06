using FrackerHub.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrackerHub.Repositories.Implementation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext _dbContext;
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TEntity entity)
        {
            //throw new NotImplementedException();
            _dbContext.Set<TEntity>().Add(entity);
        }

        public void Delete(object id)
        {
            //throw new NotImplementedException();
            TEntity entity =  _dbContext.Set<TEntity>().Find(id);
            if (entity != null)
            {
                _dbContext.Set<TEntity>().Remove(entity);
            }

        }

        public TEntity Find(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
