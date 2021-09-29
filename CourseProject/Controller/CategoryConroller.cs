using CourseProject.EF;
using CourseProject.Interface;
using CourseProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject.Controller
{
    class CategoryController : IController<Category>
    {
        public Category Get(int id)
        {
            using (AuctionContext db = new AuctionContext())
            {
                return db.Categories.Find(id);
            }
        }
        public List<Category> GetAll()
        {
            using (AuctionContext db = new AuctionContext())
            {
                //if (db.Categories.Count() == 0)
                //{
                   
                //}
                return db.Categories.ToList();
            }
        }
        public void Create(Category tmp)
        {
            using (AuctionContext db = new AuctionContext())
            {
                db.Categories.Add(tmp);
                db.SaveChanges();
            }
        }
        public void Update(int id, Category tmp)
        {
            using (AuctionContext db = new AuctionContext())
            {
                var cat = db.Categories.Where(x => x.Id == id).SingleOrDefault();
                cat.Name = tmp.Name;
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (AuctionContext db = new AuctionContext())
            {
                var cat = db.Categories.Where(x => x.Id == id).SingleOrDefault();
                if (cat != null)
                {
                    db.Categories.Remove(cat);
                    db.SaveChanges();
                }
            }
        }
    }
}
