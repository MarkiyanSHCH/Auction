using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using DAL.EF;
using DAL.Interface;
using Domain.Models;
using DTO.Models;

namespace DAL.Controller
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAll()
        {
            using (AuctionContext db = new AuctionContext())
            {
                return db.Products.AsEnumerable().Select(dto => dto.MapTo()).ToList();
            }
        }
        public Product GetById(int id)
        {
            using (AuctionContext db = new AuctionContext())
            {
                return db.Products.Find(id).MapTo();
            }
        }
        public List<Product> GetByCategory(int id)
        {
            using (AuctionContext db = new AuctionContext())
            {
                Microsoft.Data.SqlClient.SqlParameter param = new Microsoft.Data.SqlClient.SqlParameter("@id", id);
                return db.Products.FromSqlRaw("ReadProductsByCategory @id", param).AsEnumerable().Select(dto => dto.MapTo()).ToList();
            }
        }
        public List<Product> GetByUser(int id)
        {
            using (AuctionContext db = new AuctionContext())
            {
                Microsoft.Data.SqlClient.SqlParameter param = new Microsoft.Data.SqlClient.SqlParameter("@id", id);
                return db.Products.FromSqlRaw("ReadProductsByUser @id", param).AsEnumerable().Select(dto => dto.MapTo()).ToList();
            }
        }
        public Product Create(Product tmp)
        {
            using (AuctionContext db = new AuctionContext())
            {
                db.Products.Add(ProductDto.MapBack(tmp));
                db.SaveChanges();
            }
            return tmp;
        }
        public void Update(int id, Product tmp)
        {
            using (AuctionContext db = new AuctionContext())
            {
                ProductDto prod = db.Products.Where(x => x.Id == id).SingleOrDefault();
                if (tmp.AuctionPrice != null)
                    prod.AuctionPrice += tmp.AuctionPrice;
                else
                    prod.Sell = true;
                prod.UserId = tmp.UserId;
              
                db.SaveChanges();
            }
        }

        public void UpdateIfSold(int id)
        {
            using (AuctionContext db = new AuctionContext())
            {
                ProductDto prod = db.Products.Where(x => x.Id == id).SingleOrDefault();
                prod.Sell = true;

                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (AuctionContext db = new AuctionContext())
            {
                var prod = db.Products.Where(x => x.Id == id).SingleOrDefault();
                if (prod != null)
                {
                    db.Products.Remove(prod);
                    db.SaveChanges();
                }
            }
        }
    }
}
