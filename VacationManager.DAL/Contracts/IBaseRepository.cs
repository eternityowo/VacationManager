﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VacationManager.DAL.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> All();
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> Where(params Expression<Func<T, bool>>[] predicates);

        bool Any(Expression<Func<T, bool>> predicates);
        T FirstOrDefault();
        T FirstOrDefault(Expression<Func<T, bool>> predicates);
        T First();
        T First(Expression<Func<T, bool>> where);

        T SingleOrDefault();
        T SingleOrDefault(Expression<Func<T, bool>> predicates);
        T Single();
        T Single(Expression<Func<T, bool>> where);

        T FindById(object id);
        Task<T> FindByIdAsync(object id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(object id);
        void Remove(IEnumerable<T> entities);
    }
}
