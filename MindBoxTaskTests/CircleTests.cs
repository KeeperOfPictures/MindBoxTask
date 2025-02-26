using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MindBoxTask.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void GetAreaTest1()
        {
            var circle = new Circle(1);
            Assert.AreEqual(Math.PI, circle.GetArea());
        }

        [TestMethod()]
        public void GetAreaTest2()
        {
            var circle = new Circle(1);
            circle.Radius = 1.413855043925722;
            var s = circle.GetArea();
            Assert.IsTrue(6.28 - 1e-10 <= s && s <= 6.28 + 1e-10);
        }
    }
}