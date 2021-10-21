using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using DAL.EF;
using DAL.Interface;
using Domain.Models;
using DTO.Models;

namespace DAL.Controller
{
    public class ProductController : IController<Product>
    {
        public Product Get(int id)
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
        public List<Product> GetAll()
        {
            using (AuctionContext db = new AuctionContext())
            {
                return db.Products.AsEnumerable().Select(dto => dto.MapTo()).ToList();
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
                prod.Name = tmp.Name;
                prod.Description = tmp.Description;
                prod.Photo = tmp.Photo;
                prod.FixPrice = tmp.FixPrice;
                prod.AuctionPrice = tmp.AuctionPrice;
                prod.Sell = tmp.Sell;
                prod.StartDate = tmp.StartDate;
                prod.EndDate = tmp.EndDate;
                prod.CategoryId = tmp.CategoryId;
                prod.UserId = tmp.UserId;
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
