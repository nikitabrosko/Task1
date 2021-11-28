using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewYearPresent.Sweets;
using NewYearPresent.Sweets.CaramelCandies;
using NewYearPresent.Sweets.ChocolateBars;
using NewYearPresent.Sweets.ChocolateCandies;
using NewYearPresent.Sweets.GummyCandies;

namespace NewYearPresentTests.SweetsTests
{
    [TestClass]
    public class SweetnessBaseTests
    {
        //Testing Sweets classes AmountOfSugar property
        [TestMethod]
        [DataRow(typeof(MalibuCaramelCandy), 3.6f)]
        public void CheckReturningAmountOfSugarForCaramelCandies(Type candyType, float expectedAmountOfSugar)
        {
            var candyInstance = (ISweetness)Activator.CreateInstance(candyType);

            Assert.AreEqual(expectedAmountOfSugar, candyInstance.AmountOfSugar);
        }

        [TestMethod]
        [DataRow(typeof(MarsChocolateBar), 23.9f)]
        public void CheckReturningAmountOfSugarForChocolateBars(Type candyType, float expectedAmountOfSugar)
        {
            var candyInstance = (ISweetness)Activator.CreateInstance(candyType);

            Assert.AreEqual(expectedAmountOfSugar, candyInstance.AmountOfSugar);
        }

        [TestMethod]
        [DataRow(typeof(AlenkaChocolateCandy), 5.4f)]
        public void CheckReturningAmountOfSugarForChocolateCandies(Type candyType, float expectedAmountOfSugar)
        {
            var candyInstance = (ISweetness) Activator.CreateInstance(candyType);

            Assert.AreEqual(expectedAmountOfSugar, candyInstance.AmountOfSugar);
        }

        [TestMethod]
        [DataRow(typeof(JellyGummyCandy), 2.4f)]
        public void CheckReturningAmountOfSugarForGummyCandies(Type candyType, float expectedAmountOfSugar)
        {
            var candyInstance = (ISweetness)Activator.CreateInstance(candyType);

            Assert.AreEqual(expectedAmountOfSugar, candyInstance.AmountOfSugar);
        }

        //Testing Sweets classes Name, Price and Weight properties
        [TestMethod]
        [DataRow("", 1, 1)]
        [DataRow(null, 1, 1)]
        [DataRow(" ", 1, 1)]
        public void SetInvalidName(string name, double price, float weight)
        {
            Assert.ThrowsException<ArgumentException>(() => new TestSweetness(name, (decimal)price, weight),
                nameof(TestSweetness.Name));
        }

        [TestMethod]
        [DataRow("Test", 1, 1)]
        [DataRow("Name", 1, 1)]
        public void SetValidName(string name, double price, float weight)
        {
            TestSweetness testChocolateBar = new TestSweetness(name, (decimal)price, weight);

            Assert.AreEqual(name, testChocolateBar.Name);
        }

        [TestMethod]
        [DataRow("Test", 0, 1)]
        [DataRow("Test", -1, 1)]
        [DataRow("Test", -10, 1)]
        [DataRow("Test", -100, 1)]
        public void SetInvalidPrice(string name, double price, float weight)
        {
            Assert.ThrowsException<ArgumentException>(() => new TestSweetness(name, (decimal)price, weight),
                nameof(TestSweetness.Price));
        }

        [TestMethod]
        [DataRow("Test", 1, 1)]
        [DataRow("Test", 10, 1)]
        [DataRow("Test", 100, 1)]
        public void SetValidPrice(string name, double price, float weight)
        {
            TestSweetness testChocolateBar = new TestSweetness(name, (decimal)price, weight);

            Assert.AreEqual((decimal)price, testChocolateBar.Price);
        }

        [TestMethod]
        [DataRow("Test", 1, 0)]
        [DataRow("Test", 1, -1)]
        [DataRow("Test", 1, -10)]
        [DataRow("Test", 1, -100)]
        public void SetInvalidWeight(string name, double price, float weight)
        {
            Assert.ThrowsException<ArgumentException>(() => new TestSweetness(name, (decimal)price, weight),
                nameof(TestSweetness.Weight));
        }

        [TestMethod]
        [DataRow("Test", 1, 1)]
        [DataRow("Test", 1, 10)]
        [DataRow("Test", 1, 100)]
        public void SetValidWeight(string name, double price, float weight)
        {
            TestSweetness testChocolateBar = new TestSweetness(name, (decimal)price, weight);

            Assert.AreEqual(weight, testChocolateBar.Weight);
        }
    }
}
