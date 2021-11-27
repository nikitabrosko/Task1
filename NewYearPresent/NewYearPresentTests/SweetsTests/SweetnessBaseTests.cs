using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NewYearPresent.Sweets;
using NewYearPresent.Sweets.GummyCandies;
using NewYearPresentTests.SweetsTests.GummyCandiesTests;

namespace NewYearPresentTests.SweetsTests
{
    [TestClass]
    public class SweetnessBaseTests
    {
        [TestMethod]
        public void SetInvalidName()
        {
            var mock = new Mock<GummyCandy>();
            mock.Setup(x => new TestGummyCandy("Test", 1, 10));

            var amountOfSugar = mock.Object.AmountOfSugar;

            Assert.AreEqual(3.3f, amountOfSugar);
        }
    }
}
