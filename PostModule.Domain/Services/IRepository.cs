﻿using System.Linq.Expressions;

namespace PostModule.Domain.Services
{
    public interface IRepository<Tkey , T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllBy(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAllQuery();
        IQueryable<T> GetAllByQuery(Expression<Func<T, bool>> expression);
        T GetById(Tkey id);
        bool Create(T Entity);
        bool Delete(T Entity);
        bool ExistBy(Expression<Func<T, bool>> expression);
        bool Save();
    }
}
