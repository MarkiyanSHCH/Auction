using CourseProject.EF;
using CourseProject.Interface;
using CourseProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject.Controller
{
    public class UserController : IController<User>
    {
        public User Get(int id)
        {
            using (AuctionContext db = new AuctionContext())
            {
                return db.Users.Find(id);
            }
        }
        public List<User> GetAll()
        {
            using (AuctionContext db = new AuctionContext())
            {
                return db.Users.ToList();
            }
        }
        public void Create(User tmp)
        {
            using (AuctionContext db = new AuctionContext())
            {
                db.Users.Add(tmp);
                db.SaveChanges();
            }
        }
        public void Update(int id, User tmp)
        {
            using (AuctionContext db = new AuctionContext())
            {
                User user = db.Users.Where(x => x.Id == id).SingleOrDefault();
                user.Name = tmp.Name;
                user.Role = tmp.Role;
                user.Login = tmp.Login;
                user.Password = tmp.Password;
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (AuctionContext db = new AuctionContext())
            {
                var user = db.Users.Where(x => x.Id == id).SingleOrDefault();
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
            }
        }
    }
}
