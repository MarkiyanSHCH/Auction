using Domain.Models;
using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IController<T> where T : class
    {
        List<T> GetAll();
        T Get(int id);
        T Create(T item);
        void Update(int item, T obj);
        void Delete(int id);
    }
}
