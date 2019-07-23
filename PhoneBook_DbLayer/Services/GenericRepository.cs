using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_DbLayer.Services
{
    public class GenericRepository<T> where T : class
    {
        private Contact_DBEntities _db;
        private DbSet<T> _dbSet;

        public GenericRepository(Contact_DBEntities db)
        {
            this._db = db;
            _dbSet = db.Set<T>();
        }

        public virtual T GetById(object id)
        {
            return _dbSet.Find(id);
        }


        public virtual void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }


        public virtual void Delete(object id)
        {
            var entity = GetById(id);
            Delete(entity);
        }

        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> where = null)
        {
            IQueryable<T> query = _dbSet;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }





    }
}
