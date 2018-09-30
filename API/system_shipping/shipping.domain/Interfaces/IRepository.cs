using shipping.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipping.domain.Interfaces
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
