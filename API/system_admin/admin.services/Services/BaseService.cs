using admin.domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using FluentValidation;
using system.infra.data.Repositories;

namespace admin.services.Services
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
                throw new ArgumentException("The id can't be zero.");

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
