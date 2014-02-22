using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal DfwContext Context;
        internal DbSet<TEntity> Dbset;

        public GenericRepository(DfwContext Context)
        {
            this.Context = Context;
            this.Dbset = Context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return  Dbset.AsQueryable();
        }

        public virtual TEntity GetById(object id)
        {
            return Dbset.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            Dbset.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = Dbset.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                Dbset.Attach(entityToDelete);
            }
            Dbset.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            Dbset.Attach(entityToUpdate);
            Context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
