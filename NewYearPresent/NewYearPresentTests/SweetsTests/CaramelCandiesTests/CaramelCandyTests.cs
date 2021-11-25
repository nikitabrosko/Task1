﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewYearPresentTests.SweetsTests.CaramelCandiesTests
{
    [TestClass]
    public class CaramelCandyTests
    {
        [TestMethod]
        [DataRow("", 1, 1)]
        [DataRow(null, 1, 1)]
        [DataRow(" ", 1, 1)]
        public void SetInvalidName(string name, double price, float weight)
        {
            Assert.ThrowsException<ArgumentException>(() => new TestCaramelCandy(name, (decimal)price, weight),
                nameof(TestCaramelCandy.Name));
        }

        [TestMethod]
        [DataRow("Test", 1, 1)]
        [DataRow("Name", 1, 1)]
        public void SetValidName(string name, double price, float weight)
        {
            TestCaramelCandy testChocolateBar = new TestCaramelCandy(name, (decimal)price, weight);

            Assert.AreEqual(name, testChocolateBar.Name);
        }

        [TestMethod]
        [DataRow("Test", 0, 1)]
        [DataRow("Test", -1, 1)]
        [DataRow("Test", -10, 1)]
        [DataRow("Test", -100, 1)]
        public void SetInvalidPrice(string name, double price, float weight)
        {
            Assert.ThrowsException<ArgumentException>(() => new TestCaramelCandy(name, (decimal)price, weight),
                nameof(TestCaramelCandy.Price));
        }

        [TestMethod]
        [DataRow("Test", 1, 1)]
        [DataRow("Test", 10, 1)]
        [DataRow("Test", 100, 1)]
        public void SetValidPrice(string name, double price, float weight)
        {
            TestCaramelCandy testChocolateBar = new TestCaramelCandy(name, (decimal)price, weight);

            Assert.AreEqual((decimal)price, testChocolateBar.Price);
        }

        [TestMethod]
        [DataRow("Test", 1, 0)]
        [DataRow("Test", 1, -1)]
        [DataRow("Test", 1, -10)]
        [DataRow("Test", 1, -100)]
        public void SetInvalidWeight(string name, double price, float weight)
        {
            Assert.ThrowsException<ArgumentException>(() => new TestCaramelCandy(name, (decimal)price, weight),
                nameof(TestCaramelCandy.Weight));
        }

        [TestMethod]
        [DataRow("Test", 1, 1)]
        [DataRow("Test", 1, 10)]
        [DataRow("Test", 1, 100)]
        public void SetValidWeight(string name, double price, float weight)
        {
            TestCaramelCandy testChocolateBar = new TestCaramelCandy(name, (decimal)price, weight);

            Assert.AreEqual(weight, testChocolateBar.Weight);
        }

        [TestMethod]
        public void GetValidAmountOfSugar()
        {
            string name = "Test";
            decimal price = 1m;
            float weight = 10f;

            TestCaramelCandy testChocolateBar = new TestCaramelCandy(name, price, weight);

            Assert.AreEqual(4f, testChocolateBar.AmountOfSugar);
        }
    }
}
