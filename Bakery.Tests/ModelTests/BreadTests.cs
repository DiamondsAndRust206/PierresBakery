using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadBakery.Models;

namespace BreadBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadObject_BreadObject()
    {
      Bread newSale = new Bread();
      Assert.AreEqual(typeof(Bread), newSale.GetType());
    }
  }
}