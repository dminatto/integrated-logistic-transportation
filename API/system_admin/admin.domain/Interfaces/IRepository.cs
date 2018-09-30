using Domain.Entities;
using System.Collections.Generic;

namespace admin.domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void insert(T obj);

        void update(T obj);

        void delete(int id);

        T select(int id);

        IList<T> selectAll();
    }
}
