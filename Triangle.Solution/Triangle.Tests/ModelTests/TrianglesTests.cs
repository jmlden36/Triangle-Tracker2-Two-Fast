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
    
    [TestMethod]
    public void IsTriangle_ComposedOfThreeValidLengths_False()
    {
      Triangle testTriangle = new Triangle(10, 3, 3);
      Assert.AreEqual(false, testTriangle.isTriangle());
    }

    [TestMethod]

    public void IsTriangle_Equilateral_True()
    {
      Triangle testTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual(true, testTriangle.isEquilateral());
    }

    [TestMethod]

    public void IsTriangle_Equilateral_False()
    {
      Triangle testTriangle = new Triangle(4, 3, 3);
      Assert.AreEqual(false, testTriangle.isEquilateral());
    }

    [TestMethod]

    public void IsTriangle_Isosceles_True()
    {
      Triangle testTriangle = new Triangle(4,3,3);
      Assert.AreEqual(true, testTriangle.isIsosceles());
    }
    [TestMethod]
    public void IsTriangle_Isosceles_False()
    {
      Triangle testTriangle = new Triangle(3,3,3);
      Assert.AreEqual(false, testTriangle.isIsosceles());
    }
    [TestMethod]
    public void IsTriangle_Scalene_True()
    {
      Triangle testTriangle = new Triangle(2, 3, 4);
      Assert.AreEqual(true, testTriangle.isScalene());
    }
    [TestMethod]
    public void IsTriangle_Scalene_False()
    {
      Triangle testTriangle = new Triangle(2, 2, 4);
      Assert.AreEqual(false, testTriangle.isScalene());
    }
  }
}