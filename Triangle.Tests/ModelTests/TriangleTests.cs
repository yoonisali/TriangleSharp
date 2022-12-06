using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;


namespace TriangleTracker.TestTools
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void IsTriangleLength_EqualOnAllSides_True()
        {
            Triangle testTriangle = new Triangle();
            Assert.AreEqual(true, testTriangle.IsTriangleLength(3, 3, 3)
            );
        }
        [TestMethod]
        public void IsTriangleLength_NotEqualOnExactlyTwoSides_False()
        {
            Triangle testTriangle = new Triangle();
            Assert.AreEqual(false, testTriangle.IsTriangleLength(2, 8, 8)
            );
        }
        [TestMethod]
        public void IsTriangleLength_NotEqualOnAllSides_True()
        {
            Triangle testTriangle = new Triangle();
            Assert.AreEqual(true, testTriangle.IsTriangleLength(9, 10, 2));
        }
        [TestMethod]
        public void IsTriangleLength_NotATriangle_False()
        {
            Triangle testTriangle = new Triangle();
            Assert.AreEqual(false, testTriangle.IsTriangleLength(1, 1, 1));
        }
    }
}