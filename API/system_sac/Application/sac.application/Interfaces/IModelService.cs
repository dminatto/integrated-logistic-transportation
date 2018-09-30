using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace sac.application.Interfaces
{
    public interface IModelService<T> : IDisposable
    {
        T Add(T obj);
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Update(T obj);
        void Remove(int id);
    }
}
