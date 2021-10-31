using DAL.Controller;
using DAL.Interface;
using Domain.Models;
using NUnit.Framework;
using System;

using System.Linq;

namespace UnitTests
{
    [TestFixture]

    public class ProductTest
    {

        IController<Product> productRep;
        [OneTimeSetUp]
        public void InitialSetupTest()
        {
            productRep = new ProductRepository();
        }

        [Test]
        public void GetByIdTest()
        {
            var res = productRep.Get(1);
            Assert.IsTrue(res.Name == "IBM_500");
        }

        [Test]
        public void CreateTest()
        {
            Product c = new Product
            {
                Name = "Obj",
                CategoryId = 1,
                RowInsertTime = DateTime.Now,
                RowUpdateTime = DateTime.Now
            };
            var res = productRep.Create(c);
            Assert.IsTrue(res.Name == "Obj");
        }

        [Test]
        public void GetAllTest()
        {
            var categories = productRep.GetAll();

            Assert.IsTrue(categories.Any(c => c.Name == "BMW"));

        }
        [Test]
        public void UpdateTest()
        {
            Product c = new Product
            {
                Name = "Opel",
                RowUpdateTime = DateTime.Now
            };
            productRep.Update(2, c);
            Assert.IsTrue(productRep.Get(2).Name == "Opel");
        }

        [Test]
        public void DeleteTest()
        {
            productRep.Delete(3);
            Assert.IsTrue(!productRep.GetAll().Any(c => c.Id == 3));
        }
    }
}