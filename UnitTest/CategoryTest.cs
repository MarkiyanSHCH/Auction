using DAL.Controller;
using DAL.Interface;
using Domain.Models;
using NUnit.Framework;
using System;

using System.Linq;

namespace UnitTests
{
    [TestFixture]

    public class CategoryTest
    {
        IController<Category> categoryRep;
        [OneTimeSetUp]
        public void InitialSetupTest()
        {
            categoryRep = new CategoryController();
        }

        [Test]
        public void GetByIdTest()
        {
            var res = categoryRep.Get(1);
            Assert.IsTrue(res.Name == "PC");
        }

        [Test]
        public void CreateTest()
        {
            Category c = new Category
            {
                Name = "Obj",
                RowInsertTime = DateTime.Now,
                RowUpdateTime = DateTime.Now
            };
            var res = categoryRep.Create(c);
            Assert.IsTrue(res.Name == "Obj");
        }

        [Test]
        public void GetAllTest()
        {
            var categories = categoryRep.GetAll();

            Assert.IsTrue(categories.Any(c => c.Name == "PC"));

        }
        [Test]
        public void UpdateTest()
        {
            Category c = new Category
            {
                Name = "Knifes",
                RowUpdateTime = DateTime.Now
            };
            categoryRep.Update(5, c);
            Assert.IsTrue(categoryRep.Get(5).Name == "Knifes");
        }

        [Test]
        public void DeleteTest()
        {
            categoryRep.Delete(7);
            Assert.IsTrue(!categoryRep.GetAll().Any(c => c.Id == 7));
        }
    }
}