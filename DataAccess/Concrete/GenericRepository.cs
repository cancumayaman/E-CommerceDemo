using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly DbContext _context;
        private DbSet<TEntity> _dbSet;
        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();

        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _dbSet.ToList() : _dbSet.Where(filter).ToList();
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {

            return _dbSet.SingleOrDefault(filter);

        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
