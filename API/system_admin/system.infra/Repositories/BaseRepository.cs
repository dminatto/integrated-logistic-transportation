using System.Collections.Generic;
using admin.domain.Interfaces;
using admin.infra.DAO.Context;
using Microsoft.EntityFrameworkCore;

namespace system.infra.Repositories
{
    public class BaseRepository<T> : IRepository<T>
    {
        private PostgressContext context = new PostgressContext();


        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void insert(T obj)
        {
            context.DbSet<T>().Add(obj);
            context.SaveChanges();
        }

        public void remove(T obj)
        {
            throw new System.NotImplementedException();
        }

        public T select(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<T> selectAll()
        {
            throw new System.NotImplementedException();
        }

        public void update(T obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
