using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WWService.ModelBD;

namespace WWService.Consultas
{
    public class CRUD<TEntity> where TEntity : class
    {
        internal dbDocumentacionEntities contexto;
        internal DbSet<TEntity> dbSet;

        public CRUD(dbDocumentacionEntities contexto)
        {
            this.contexto = contexto;
            contexto.Configuration.ProxyCreationEnabled = false;
            this.dbSet = contexto.Set<TEntity>();

        }

        private readonly char[] splitChart = new char[] { ',' };

        public virtual async Task<IEnumerable<TEntity>> Get(
                Expression<Func<TEntity, Boolean>> filter = null,
                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                String propertys = "", Boolean bitTake = false, int take = 0, int skip = 0)
        {

            IQueryable<TEntity> query = dbSet;



            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!String.IsNullOrEmpty(propertys))
            {
                foreach (var includeProperty in propertys.Split(splitChart, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }


            if (orderBy != null)
            {
                if (bitTake)
                {
                    return await orderBy(query).Take(take).ToListAsync();
                }
                else
                {
                    return await orderBy(query).ToListAsync();
                }
            }
            else
            {
                if (bitTake)
                {
                    return await query.Take(take).ToListAsync();
                }
                else
                {
                    return await query.ToListAsync();
                }
            }
        }


        public virtual async Task<TEntity> GetById(object id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void InsertAll(IEnumerable<TEntity> entitys)
        {
            foreach (var entity in entitys)
            {
                dbSet.Add(entity);
            }
        }

        public virtual void Delete(object id)
        {
            TEntity deleteEntity = dbSet.Find(id);
            Delete(deleteEntity);
        }

        public virtual void Delete(TEntity entity)
        {
            if (contexto.Entry(entity).State == EntityState.Deleted)
            {
                dbSet.Attach(entity);
            }

            dbSet.Remove(entity);
        }

        public virtual Boolean Any(Expression<Func<TEntity, Boolean>> filter = null)
        {
            Boolean result = false;

            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                result = query.Where(filter).Count() > 0;
            }

            return result;

        }

        public virtual void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            contexto.Entry(entity).State = EntityState.Modified;
        }
    }
}
