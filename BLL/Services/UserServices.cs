using BLL.Interface;
using DAL.Interface;
using Domain.Models;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BLL.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        public UserServices(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public User GetUserById(int id)
           => this._userRepository.Get(id);
        public User GetUserByLogin(string login)
            => this._userRepository.GetUserByLogin(login);

        public bool ConfirmPass(string enteredPass, string dbString)
        {
            string[] objects = dbString.Split('.');
            int iteration = Convert.ToInt32(objects[0]);
            string salt = objects[1];
            string expectedPass = objects[2];
            string pass = salt + enteredPass;
            if (expectedPass == Convert.ToBase64String(Hash(pass, iteration)))
                return true;
            else
                return false;
        }
        public string GenerateSalt()
        {
            RNGCryptoServiceProvider rncCsp = new RNGCryptoServiceProvider();
            byte[] salt = new byte[16];
            rncCsp.GetBytes(salt);
            return Convert.ToBase64String(salt);
        }
        public string HashPass(string pass, int iteration)
        {
            string salt = GenerateSalt();
            pass = salt + pass;
            byte[] hashed;
            using (var sha = SHA256.Create())
            {
                var asBytes = Encoding.Default.GetBytes(pass);
                for (int i = 0; i < iteration; i++)
                {
                    asBytes = sha.ComputeHash(asBytes);
                }

                hashed = sha.ComputeHash(asBytes);
                return iteration.ToString() + "." + salt + "." + Convert.ToBase64String(hashed);
            }
        }
        public byte[] Hash(string pass, int iteration)
        {
            byte[] hashed;
            using (var sha = SHA256.Create())
            {
                var asBytes = Encoding.Default.GetBytes(pass);
                for (int i = 0; i < iteration; i++)
                {
                    asBytes = sha.ComputeHash(asBytes);
                }

                hashed = sha.ComputeHash(asBytes);
                string str = Convert.ToBase64String(hashed);
                return hashed;
            }
        }

        public void Register()
        {
            User user = new User();
            user.Name = "Max";
            user.Role = "User";
            string passC;
            user.Login = "max02";
            passC = "5678";
            string pass = HashPass(passC, 4);
            user.Password = pass;
            _userRepository.Create(user);
        }

        public bool Login(string login, string password)
        {
            User user = _userRepository.GetUserByLogin(login);
            if (user != null)
                return ConfirmPass(password, user.Password);

            return false;
        }
    }
}
