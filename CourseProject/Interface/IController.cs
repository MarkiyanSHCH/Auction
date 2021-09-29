using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Interface
{
    public interface IController<T> where T : class
    {
        List<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(int item, T obj);
        void Delete(int id);
    }
}
