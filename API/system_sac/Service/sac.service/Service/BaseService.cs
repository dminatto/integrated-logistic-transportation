using System;
using System.Collections.Generic;
using FluentValidation;
using sac.domain.Entities;
using sac.domain.Interfaces;
using sac.infra.data.Repositories;

namespace sac.service.Service
{
    public abstract class BaseService<T> : IService<T> where T : BaseEntity
    {
        private BaseRepository<T> repository = new BaseRepository<T>();

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("O ID não pode ser 0");

            repository.Delete(id);
        }

        public T Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("O ID não pode ser 0");

            return repository.Select(id);
        }

        public IList<T> Get() => repository.SelectAll();

        public T Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Insert(obj);
            return obj;
        }

        public T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Update(obj);
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
