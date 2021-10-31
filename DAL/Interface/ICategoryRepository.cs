using System.Collections.Generic;

using Domain.Models;

namespace DAL.Interface
{
    public interface ICategoryRepository
    {
        Category Get(int id);
        List<Category> GetAll();
        Category Create(Category tmp);
        void Update(int id, Category tmp);
        void Delete(int id);
    }
}
