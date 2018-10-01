using delivery.logistics.domain.Entities;
using System.Collections.Generic;

namespace delivery.logistics.domain.Interfaces
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
