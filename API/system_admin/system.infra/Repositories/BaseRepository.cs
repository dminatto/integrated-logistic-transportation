using System.Collections.Generic;
using admin.domain.Interfaces;
using admin.infra.DAO.Context;
using Domain.Entities;
using System.Linq;
using System;

namespace system.infra.data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private PostgressContext context = new PostgressContext();
        
        public void insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void delete(int id)
        {
          //  context.Set<T>().Remove(SelectById(id));
            //context.SaveChanges();
        }

        public T select(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IList<T> selectAll()
        {
            return context.Set<T>().ToList();
        }

        public void update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
