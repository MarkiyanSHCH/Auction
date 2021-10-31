using System.Collections.Generic;

using Domain.Models;

namespace BLL.Interface
{
    public interface IProductServices
    {
        Product GetProduct(int id);
        List<Product> GetAllActiveProduct();
        List<Product> GetAllByCategory(int id);
        List<Product> GetAllByUserActive(int id);
        List<Product> GetAllByUserHistory(int id);
        void MakeBid(int userId, int id, double price);
        void Buy(int userId, int id);
        List<Product> FindProductsByCategory(string request);
        void Update(int id);
    }
}
