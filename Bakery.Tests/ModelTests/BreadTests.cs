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
      Bread newSale = new Bread("3");
      Assert.AreEqual(typeof(Bread), newSale.GetType());
    }
    [TestMethod]
    public void BreadConstructor_ParsesBreadString_int()
    {
      Bread newSale = new Bread("3");
      Assert.AreEqual(3, newSale.BreadCount);
    }
    [TestMethod]
    public void BreadSales_CalculatesBreadTotal_int()
    {
      Bread newSale = new Bread("3");
      newSale.BreadSales();
      Assert.AreEqual(15, newSale.BreadSalesTotal);
    }
    [TestMethod]
    public void BreadDiscount_BuyTwoGetOneFree_int()
    {
      Bread newSale = new Bread("3");
      newSale.BreadSales();
      newSale.BreadDiscount();
      Assert.AreEqual(10, newSale.BreadSalesTotal);
    }
    [TestMethod]
    public void BreadDiscount_EveryThirdLoafMinusFive_int()
    {
      Bread newSale = new Bread("6");
      newSale.BreadSales();
      newSale.BreadDiscount();
      Assert.AreEqual(20, newSale.BreadSalesTotal);
    }

  }
}