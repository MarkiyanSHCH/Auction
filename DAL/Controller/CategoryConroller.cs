using System.Collections.Generic;
using System.Linq;

using DAL.EF;
using DAL.Interface;
using Domain.Models;
using DTO.Models;

namespace DAL.Controller
{
    public class CategoryController : IController<Category>
    {
        public Category Get(int id)
        {
            using (AuctionContext db = new AuctionContext())
            {
                return db.Categories.Find(id).MapTo();
            }
        }
        public List<Category> GetAll()
        {
            using (AuctionContext db = new AuctionContext())
            {
                return db.Categories.AsEnumerable().Select(dto => dto.MapTo()).ToList();
            }
        }
        public Category Create(Category tmp)
        {
            using (AuctionContext db = new AuctionContext())
            {
                db.Categories.Add(CategoryDto.MapBack(tmp));
                db.SaveChanges();
            }
            return tmp;
        }
        public void Update(int id, Category tmp)
        {
            using (AuctionContext db = new AuctionContext())
            {
                var cat = db.Categories.Where(x => x.Id == id).SingleOrDefault();
                cat.Name = tmp.Name;
                cat.RowUpdateTime = tmp.RowUpdateTime;
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
