using FluentValidation;
using shipping.domain.Entities;
using System.Collections.Generic;

namespace shipping.domain.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        T post<V>(T obj) where V : AbstractValidator<T>;

        T put<V>(T obj) where V : AbstractValidator<T>;

        void delete(int id);

        T get(int id);

        IList<T> get();
    }
}
