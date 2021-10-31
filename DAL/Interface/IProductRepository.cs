using System.Collections.Generic;

using Domain.Models;

namespace DAL.Interface
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> GetByCategory(int id);
        List<Product> GetByUser(int id);
        Product Create(Product tmp);
        void Update(int id, Product tmp);
        void UpdateIfSold(int id);
        void Delete(int id);
    }
}
