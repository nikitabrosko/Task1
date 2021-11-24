using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewYearPresentTests.SweetsTests.ChocolateBarsTests
{
    [TestClass]
    public class ChocolateBarTests
    {
        [TestMethod]
        [DataRow("", 1, 1)]
        [DataRow(null, 1, 1)]
        [DataRow(" ", 1, 1)]
        public void SetInvalidName(string name, double price, float weight)
        {
            Assert.ThrowsException<ArgumentException>(() => new TestChocolateBar(name, (decimal)price, weight),
                nameof(TestChocolateBar.Name));
        }

        [TestMethod]
        [DataRow("Test", 1, 1)]
        [DataRow("Name", 1, 1)]
        public void SetValidName(string name, double price, float weight)
        {
            TestChocolateBar testChocolateBar = new TestChocolateBar(name, (decimal)price, weight);

            Assert.AreEqual(name, testChocolateBar.Name);
        }

        [TestMethod]
        [DataRow("Test", 0, 1)]
        [DataRow("Test", -1, 1)]
        [DataRow("Test", -10, 1)]
        [DataRow("Test", -100, 1)]
        public void SetInvalidPrice(string name, double price, float weight)
        {
            Assert.ThrowsException<ArgumentException>(() => new TestChocolateBar(name, (decimal)price, weight),
                nameof(TestChocolateBar.Price));
        }

        [TestMethod]
        [DataRow("Test", 1, 1)]
        [DataRow("Test", 10, 1)]
        [DataRow("Test", 100, 1)]
        public void SetValidPrice(string name, double price, float weight)
        {
            TestChocolateBar testChocolateBar = new TestChocolateBar(name, (decimal)price, weight);

            Assert.AreEqual((decimal)price, testChocolateBar.Price);
        }

        [TestMethod]
        [DataRow("Test", 1, 0)]
        [DataRow("Test", 1, -1)]
        [DataRow("Test", 1, -10)]
        [DataRow("Test", 1, -100)]
        public void SetInvalidWeight(string name, double price, float weight)
        {
            Assert.ThrowsException<ArgumentException>(() => new TestChocolateBar(name, (decimal)price, weight),
                nameof(TestChocolateBar.Weight));
        }

        [TestMethod]
        [DataRow("Test", 1, 1)]
        [DataRow("Test", 1, 10)]
        [DataRow("Test", 1, 100)]
        public void SetValidWeight(string name, double price, float weight)
        {
            TestChocolateBar testChocolateBar = new TestChocolateBar(name, (decimal)price, weight);

            Assert.AreEqual(weight, testChocolateBar.Weight);
        }
        
        [TestMethod]
        public void GetValidAmountOfSugar()
        {
            string name = "Test";
            decimal price = 1m;
            float weight = 10f;

            TestChocolateBar testChocolateBar = new TestChocolateBar(name, price, weight);

            Assert.AreEqual(5f, testChocolateBar.AmountOfSugar);
        }
    }
}
