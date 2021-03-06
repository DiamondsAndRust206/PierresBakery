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
      newSale.PastrySales();
      Assert.AreEqual(6, newSale.PastrySalesTotal);
    }
    [TestMethod]
    public void PastryDiscount_MinusOneBetweenThreeAndFivePastries_int()
    {
      Pastry newSale = new Pastry("3");
      newSale.PastrySales();
      newSale.PastryDiscount();
      Assert.AreEqual(5, newSale.PastrySalesTotal);
    }
    [TestMethod]
    public void PastryDiscount_MinusTwoOverSixPastries_int()
    {
      Pastry newSale = new Pastry("6");
      newSale.PastrySales();
      newSale.PastryDiscount();
      Assert.AreEqual(10, newSale.PastrySalesTotal);
    }
    [TestMethod]
    public void PastryDiscount_FullPriceForTwoPastriesOrLess_int()
    {
      Pastry newSale = new Pastry("2");
      newSale.PastrySales();
      newSale.PastryDiscount();
      Assert.AreEqual(4, newSale.PastrySalesTotal);
    }
    [TestMethod]
    public void PastryDiscount_EverySixPastriesMinusTwo_int()
    {
      Pastry newSale = new Pastry("12");
      newSale.PastrySales();
      newSale.PastryDiscount();
      Assert.AreEqual(20, newSale.PastrySalesTotal);
    }

  }
}