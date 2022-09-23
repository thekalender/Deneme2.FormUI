using Deneme2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deneme2.DataAccess
{
    public interface IEntityRepostory<T> where T : class, IEntity, new()
    {
        public List<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
