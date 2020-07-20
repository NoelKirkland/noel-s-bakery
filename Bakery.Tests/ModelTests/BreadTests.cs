using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadBakery.Models;

namespace BreadBakery.Test
{
  [TestClass]
  public class ProductTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PriceCalculatorBread_CalculatesPriceOfBreadBasedOnQuantityOf10_35()
    {
      Bread newBread = new Bread(10);
      Assert.AreEqual("35.00", newBread.PriceCalculatorBread());
    }

    [TestMethod]
    public void PriceCalculatorBread_CalculatesPriceOfBreadBasedOnQuantityOf11_40()
    {
      Bread newBread = new Bread(11);
      Assert.AreEqual("40.00", newBread.PriceCalculatorBread());
    }

    [TestMethod]
    public void PriceCalculatorBread_CalculatesPriceOfBreadBasedOnQuantityOf12_40()
    {
      Bread newBread = new Bread(12);
      Assert.AreEqual("40.00", newBread.PriceCalculatorBread());
    }
  }
}