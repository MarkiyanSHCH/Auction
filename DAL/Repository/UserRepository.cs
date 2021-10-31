using System.Collections.Generic;
using System.Linq;

using DAL.EF;
using DAL.Interface;
using Domain.Models;
using DTO.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Controller
{
    public class UserRepository : IUserRepository
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
        public User GetUserByLogin(string login)
        {
            using (AuctionContext db = new AuctionContext())
            {
                Microsoft.Data.SqlClient.SqlParameter param = new Microsoft.Data.SqlClient.SqlParameter("@Login", login);
                UserDto user = db.Users.FromSqlRaw("spUsers_GetUserByLogin @Login", param).AsEnumerable().FirstOrDefault();
                return user == null ? null : user.MapTo();
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
