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
      Pastry newSale = new Pastry("3");
      Assert.AreEqual(typeof(Pastry), newSale.GetType());
    }
    [TestMethod]
    public void PastryConstructor_ParsesPastriesString_int()
    {
      Pastry newSale = new Pastry("3");
      Assert.AreEqual(3, newSale.PastryCount);
    }
    [TestMethod]
    public void PastrySales_CalculatePastryTotal_int()
    {
      Pastry newSale = new Pastry("3");
      Assert.AreEqual(6, newSale.PastrySalesTotal);
    }

  }
}