using System.Collections.Generic;
using System.Linq;

using DAL.EF;
using DAL.Interface;
using Domain.Models;
using DTO.Models;

namespace DAL.Controller
{
    public class UserController : IController<User>
    {
        public User Get(int id)
        {
            using (AuctionContext db = new AuctionContext())
            {
                return db.Users.Find(id).MapTo();
            }
        }
        public List<User> GetAll()
        {
            using (AuctionContext db = new AuctionContext())
            {
                return db.Users.AsEnumerable().Select(dto => dto.MapTo()).ToList();
            }
        }
        public User Create(User tmp)
        {
            using (AuctionContext db = new AuctionContext())
            {
                db.Users.Add(UserDto.MapBack(tmp));
                db.SaveChanges();
            }
            return tmp;
        }
        public void Update(int id, User tmp)
        {
            using (AuctionContext db = new AuctionContext())
            {
                UserDto user = db.Users.Where(x => x.Id == id).SingleOrDefault();
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
