﻿using RestorauntTrueCost.Server.Models.DatabaseContext;
using System.Linq.Expressions;

namespace RestorauntTrueCost.Server.Models.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly RestorauntDbContext _context;

        protected BaseRepository(RestorauntDbContext context)
        {
            _context = context;
        }

        public async Task<T> Create(T item)
        {
            _context.Set<T>().Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<T> Delete(T item)
        {
            _context.Set<T>().Remove(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public void Dispose()
        {

        }

        public async Task<T?> Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<T> Update(T item)
        {
            _context.Set<T>().Update(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public async Task<T?> GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task<IEnumerable<T>> AddRange(IEnumerable<T> list)
        {
            _context.Set<T>().AddRange(list);
            await _context.SaveChangesAsync();
            return list;
        }

        public async Task<IEnumerable<T>> RemoveRange(IEnumerable<T> list)
        {
            _context.Set<T>().RemoveRange(list);
            await _context.SaveChangesAsync();
            return list;
        }
    }
}
