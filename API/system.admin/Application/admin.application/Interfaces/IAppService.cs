using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using admin.application.ViewModels;
using admin.domain.Entities;

namespace admin.application.Interfaces
{
    public interface IAppService<T, V> : IDisposable where T : BaseViewModel where V : BaseEntity
    {
        T Add(T obj);
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Update(T obj);
        void Remove(int id);
        IEnumerable<T> Search(Expression<Func<V, bool>> predicate);
    }
}
