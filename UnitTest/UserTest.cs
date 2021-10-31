using DAL.Controller;
using DAL.Interface;
using Domain.Models;
using NUnit.Framework;
using System;

using System.Linq;

namespace UnitTests
{
    [TestFixture]

    public class UserTest
    {

        IController<User> userRep;
        [OneTimeSetUp]
        public void InitialSetupTest()
        {
            userRep = new UserRepository();
        }

        [Test]
        public void GetByIdTest()
        {
            var res = userRep.Get(6);
            Assert.IsTrue(res.Name == "Obj");
        }

        [Test]
        public void CreateTest()
        {
            User c = new User
            {
                Name = "Obj",
                Login = "Login",
                Password = "Password",
                RowInsertTime = DateTime.Now,
                RowUpdateTime = DateTime.Now
            };
            var res = userRep.Create(c);
            Assert.IsTrue(res.Login == "Login");
        }

        [Test]
        public void GetAllTest()
        {
            var categories = userRep.GetAll();

            Assert.IsTrue(categories.Any(c => c.Name == "Obj"));

        }
        [Test]
        public void UpdateTest()
        {
            User c = new User
            {
                Name = "Obj1",
                Login = "login1",
                Password = "Password",
                RowUpdateTime = DateTime.Now
            };
            userRep.Update(5, c);
            Assert.IsTrue(userRep.Get(5).Login == "login1");
        }

        [Test]
        public void DeleteTest()
        {
            userRep.Delete(5);
            Assert.IsTrue(!userRep.GetAll().Any(c => c.Id == 5));
        }
    }
}