using System.Collections.Generic;
using admin.domain.Entities;

namespace admin.domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);

        T Select(int id);

        IList<T> SelectAll();
    }
}
