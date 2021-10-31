using Domain.Models;

namespace BLL.Interface
{
    public interface IUserServices
    {
        User GetUserById(int id);
        User GetUserByLogin(string login);
        bool Login(string login, string password);
        void Register();
    }
}
