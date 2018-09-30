using System;
using System.Collections.Generic;
using FluentValidation;
using shipping.domain.Entities;
using shipping.domain.Interfaces;
using shipping.infra.data.Repositories;

namespace shipping.service.Services
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        private BaseRepository<T> repository = new BaseRepository<T>();

        public void delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("O ID não pode ser 0");

            repository.delete(id);
        }

        public T get(int id)
        {
            if (id == 0)
                throw new ArgumentException("O ID não pode ser 0");

            return repository.select(id);
        }

        public IList<T> get() => repository.selectAll();

        public T post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.insert(obj);
            return obj;
        }

        public T put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.update(obj);
            return obj;
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
