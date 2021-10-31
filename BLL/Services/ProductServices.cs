using BLL.Interface;
using DAL.Interface;
using Domain.Models;

using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        public ProductServices(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            this._productRepository = productRepository;
            this._categoryRepository = categoryRepository;
        }

        public Product GetProduct(int id)
            => this._productRepository.GetById(id);
        public List<Product> GetAllActiveProduct()
        {
            List<Product> products = _productRepository.GetAll();
            var selectedproducts = from product in products
                                   where product.EndDate < System.DateTime.Now
                                   select product.Id;
            foreach (var id in selectedproducts)
                Update(id);

            return this._productRepository.GetAll().FindAll(x => x.Sell == false);
        }
        public List<Product> GetAllByCategory(int id)
          => this._productRepository.GetByCategory(id);
        public List<Product> GetAllByUserActive(int id)
          => this._productRepository.GetByUser(id).FindAll(x => x.EndDate > System.DateTime.Now && x.Sell == false);
        public List<Product> GetAllByUserHistory(int id)
          => this._productRepository.GetByUser(id).FindAll(x => x.EndDate < System.DateTime.Now && x.Sell == true);
        public void MakeBid(int userId, int id, double price)
            => this._productRepository.Update(id, new Product
            {
                UserId = userId,
                AuctionPrice = price
            });

        public void Buy(int userId, int id)
            => this._productRepository.Update(id, new Product
            {
                UserId = userId,
                Sell = true
            });

        public void Update(int id)
            => this._productRepository.UpdateIfSold(id);

        public List<Product> FindProductsByCategory(string request)
        {
            List<Product> products = this.GetAllActiveProduct();
            var selectedproducts = from product in products
                                   where this._categoryRepository.Get(product.CategoryId).Name.ToLower() == request.ToLower()
                                   select product;
            List<Product> findedproducts = new List<Product>();
            foreach (Product item in selectedproducts)
            {
                findedproducts.Add(item);
            }
            return findedproducts;
        }
    }
}
