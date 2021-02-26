using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeerMorten;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerMorten.Tests
{
    [TestClass()]
    public class BeerTests
    {
        private Beer beer1;
        [TestInitialize]
        public void init()
        {
            beer1 = new Beer();
        }
        [TestMethod()]
        public void IdTest()
        {
            beer1.Id = 1;
            Assert.AreEqual(1,beer1.Id);
        }
        [TestMethod()]
        public void NameTest()
        {
            beer1.Name = "Good beer";
            Assert.AreEqual("Good beer",beer1.Name);
            Assert.ThrowsException<ArgumentException>(() => beer1.Name = "bdb");
        }
        [TestMethod()]
        public void PriceTest()
        {
            beer1.Price = 30;
            Assert.AreEqual(30,beer1.Price);
            Assert.ThrowsException<ArgumentException>(() => beer1.Price = 0);
            Assert.ThrowsException<ArgumentException>(() => beer1.Price = -1);
        }
        [TestMethod()]
        public void AbvTest()
        {
            beer1.Abv = 5.5;
            Assert.AreEqual(5.5,beer1.Abv);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer1.Abv = -1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer1.Abv = 101);
        }
        [TestMethod()]
        public void ToStringTest()
        {
            beer1.Id = 1;
            beer1.Name = "Good beer";
            beer1.Price = 30;
            beer1.Abv = 5.5;
            Assert.AreEqual("Nr. 1 Name Good beer abv is 5,5 with a price of 30", beer1.ToString());
        }
    }
}

