using System.Collections.Generic;

using Domain.Models;

namespace DAL.Interface
{
    public interface IUserRepository
    {
        User Get(int id);
        List<User> GetAll();
        User GetUserByLogin(string login);
        User Create(User tmp);
        void Update(int id, User tmp);
        void Delete(int id);
    }
}
