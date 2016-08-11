using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EricStore.Models;

namespace EricStore.Tests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            ProductModel c = new ProductModel();
            c.ShoeName = "Cole Haan";
            Assert.AreEqual("Cole Haan", c.ShoeName);
        }

        /*public void CartPropertiesTest()
        {
            CartModel c = new CartModel();
            c.Email = "eric@codingtemple.com";
            Assert.AreEqual("eric@codingtemple.com", c.Email);

            c.PhoneNumber = "222-222-2222";
            Assert.AreEqual("222-222-2222", c.PhoneNumber);

            
        }
        */
    }
}
