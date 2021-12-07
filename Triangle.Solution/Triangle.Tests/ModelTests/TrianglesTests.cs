using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleStuff;

namespace TriangleStuff.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_ComposedOfThreeValidLengths_True()
    {
      Triangle testTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual(true, testTriangle.isTriangle());
    }
  }
}