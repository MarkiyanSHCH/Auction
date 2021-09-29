using CourseProject.EF;
using CourseProject.Interface;
using CourseProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject.Controller
{
    class ProductController: IController<Product>
    {
        public Product Get(int id)
        {
            using (AuctionContext db = new AuctionContext())
            {
                return db.Products.Find(id);
            }
        }
        public List<Product> GetAll()
        {
            using (AuctionContext db = new AuctionContext())
            {
                return db.Products.ToList();
            }
        }
        public void Create(Product tmp)
        {
            using (AuctionContext db = new AuctionContext())
            {
                db.Products.Add(tmp);
                db.SaveChanges();
            }
        }
        public void Update(int id, Product tmp)
        {
            using (AuctionContext db = new AuctionContext())
            {
                Product prod = db.Products.Where(x => x.Id == id).SingleOrDefault();
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
