using Microsoft.VisualStudio.TestTools.UnitTesting;
using PastryBakery.Models;

namespace PastryBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesAnInstanceOfPastryObject_Pastry()
    {
      Pastry newSale = new Pastry();
      Assert.AreEqual(typeof(Pastry), newSale.GetType());
    }
    
  }
}