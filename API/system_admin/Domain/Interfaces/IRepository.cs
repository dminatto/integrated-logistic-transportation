using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.domain.Interfaces
{
    public interface IRepository<T> : IDisposable
    {
        void insert(T obj);

        void update(T obj);

        void remove(T obj);

        T select(int id);

        IList<T> selectAll();
    }
}
