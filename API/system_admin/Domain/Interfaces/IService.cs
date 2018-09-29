using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin.domain.Interfaces
{
    public interface IService<T>
    {
        T post<V>(T obj) where V : AbstractValidator<T>;
       
        T put<V>(T obj) where V : AbstractValidator<T>;

        void delete(int id);

        T get(int id);

        IList<T> get();
    }
}
