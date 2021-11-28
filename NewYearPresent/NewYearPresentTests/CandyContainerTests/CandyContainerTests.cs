using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewYearPresent.CandyContainer;
using NewYearPresent.Sweets;
using NewYearPresent.Sweets.CaramelCandies;

namespace NewYearPresentTests.CandyContainerTests
{
    [TestClass]
    public class CandyContainerTests
    {
        [TestMethod]
        [DataRow("", "Test")]
        [DataRow(null, "Test")]
        [DataRow(" ", "Test")]
        public void SetInvalidName(string name, string description)
        {
            Assert.ThrowsException<ArgumentException>(() => new CandyBox(name, description),
                nameof(ICandyContainer.Name));
        }

        [TestMethod]
        [DataRow("Test", "Test")]
        [DataRow("Name", "Test")]
        public void SetValidName(string name, string description)
        {
            var candyContainer = new CandyBox(name, description);

            Assert.AreEqual(name, candyContainer.Name);
        }

        [TestMethod]
        [DataRow("Test", "")]
        [DataRow("Test", null)]
        [DataRow("Test", " ")]
        public void SetInvalidDescription(string name, string description)
        {
            Assert.ThrowsException<ArgumentException>(() => new CandyBox(name, description),
                nameof(ICandyContainer.Description));
        }

        [TestMethod]
        [DataRow("Test", "Test")]
        [DataRow("Test", "Name")]
        public void SetValidDescription(string name, string description)
        {
            var candyContainer = new CandyBox(name, description);

            Assert.AreEqual(description, candyContainer.Description);
        }

        [TestMethod]
        public void TestAddMethodWithOneParameter()
        {
            var candyContainer = new CandyBox("Test", "Test");
            var candyInstance = new MalibuCaramelCandy();

            candyContainer.Add(candyInstance);

            Assert.AreEqual(candyInstance, candyContainer.Sweets.First());
        }

        [TestMethod]
        public void TestAddMethodWithMoreThanOneParameter()
        {
            var candyContainer = new CandyBox("Test", "Test");
            var candyInstanceFirst = new MalibuCaramelCandy();
            var candyInstanceSecond = new AlenkaCaramelCandy();
            var candyInstanceThird = new LollipopCaramelCandy();

            candyContainer.Add(candyInstanceFirst, candyInstanceSecond, candyInstanceThird);

            Assert.IsTrue(candyContainer.Sweets.ToArray().SequenceEqual(new ISweetness[]
                { candyInstanceFirst, candyInstanceSecond, candyInstanceThird }));
        }

        [TestMethod]
        public void TestRemoveMethod()
        {
            var candyContainer = new CandyBox("Test", "Test");
            var candyInstance = new MalibuCaramelCandy();
            candyContainer.Add(candyInstance);

            candyContainer.Remove(candyInstance);

            Assert.IsFalse(candyContainer.Sweets.Contains(candyInstance));
        }

        [TestMethod]
        public void TestRemoveAtMethod()
        {
            var candyContainer = new CandyBox("Test", "Test");
            var candyInstance = new MalibuCaramelCandy();
            candyContainer.Add(candyInstance);

            candyContainer.RemoveAt(0);

            Assert.IsFalse(candyContainer.Sweets.Contains(candyInstance));
        }
    }
}
