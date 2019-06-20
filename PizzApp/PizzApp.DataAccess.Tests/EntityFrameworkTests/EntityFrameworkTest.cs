using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzApp.DataAccess.Concrete.EntityFramework;

namespace PizzApp.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_products()
        {
            //EfProductDal test.
            EfProductDal productDal = new EfProductDal(); //şimdilik test için dependency injectionsız.

            var result = productDal.GetList();
            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        public void Get_all_also_parameter_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList(p => p.ProductTypeId == 1);  //2 pizza var.
            Assert.AreEqual(2, result.Count);
        }
    }
}
