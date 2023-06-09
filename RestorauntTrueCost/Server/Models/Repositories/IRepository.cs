﻿using System.Linq.Expressions;

namespace RestorauntTrueCost.Server.Models.Repositories
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> Get(int id);
        Task<T> Create(T item);
        Task<T> Update(T item);
        Task<T> Delete(T item);
        Task<T?> GetById(int id);
        Task<IEnumerable<T>> AddRange(IEnumerable<T> list);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> RemoveRange(IEnumerable<T> list);
    }
}
