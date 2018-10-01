using delivery.logistics.domain.Entities;
using delivery.logistics.domain.Interfaces;
using delivery.logistics.infra.DAO.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace delivery.logistics.infra.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private DataContext context = new DataContext();

        public void Delete(int id)
        {
            var registro = context.Set<T>().Find(id);
            context.Set<T>().Remove(registro);
            context.SaveChanges();
        }

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public T Select(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IList<T> SelectAll()
        {
            return context.Set<T>().ToList();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
