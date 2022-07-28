using FrackerHub.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return _dbContext.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            // _dbContext.
            return _dbContext.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
             _dbContext.Set<TEntity>().Remove(entity);
        }

        //public void Update(TEntity entity)
        //{
        //    throw new NotImplementedException();
        //}

        public int SaveChanges(TEntity entity)
        {
            return _dbContext.SaveChanges();

        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);

        }
    }
}
