using shipping.domain.Entities;
using shipping.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipping.infra.data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void insert(T obj)
        {
            throw new NotImplementedException();
        }

        public T select(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> selectAll()
        {
            throw new NotImplementedException();
        }

        public void update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
