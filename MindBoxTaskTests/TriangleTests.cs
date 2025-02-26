using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindBoxTask.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void IsRightTest()
        {
            var trinagle = new Triangle(3, 4, 5);
            Assert.IsTrue(trinagle.IsRight());
        }

        [TestMethod()]
        public void IsRightTestFail()
        {
            var trinagle = new Triangle(3, 4, 6);
            Assert.IsFalse(trinagle.IsRight());
        }

        [TestMethod()]
        public void GetArea()
        {
            var trinagle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, trinagle.GetArea());
        }
    }
}