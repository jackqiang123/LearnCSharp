using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            var curProduct = new Product();
            curProduct.ProductName = "Saw";
            curProduct.ProductId = 1;
            curProduct.Description = "gg";
            curProduct.ProductVender.CompanyName = "ABC Corp";
            var expect = "Hello Saw (1): gg";
            Assert.AreEqual(expect, curProduct.SayHello());
        }

        [TestMethod()]
        public void SayHelloTestParaConstructor()
        {
            var curProduct = new Product(1,"Saw","gg");
            var expect = "Hello Saw (1): gg";
            Assert.AreEqual(expect, curProduct.SayHello());
        }

        [TestMethod()]
        public void SayHelloTest_null()
        {
            Product curProduct = null;
            var companyName = curProduct?.ProductName;
            var expect = "Hello Saw (1): gg";
            Assert.AreEqual(1, 1);
        }
    }
}