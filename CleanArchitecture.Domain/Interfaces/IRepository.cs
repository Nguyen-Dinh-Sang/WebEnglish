using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        T GetBy(int? Id);
        IEnumerable<T> GetAll();

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Remove(int? Id);
    }
}
