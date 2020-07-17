using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PastryBakery.Models;

namespace PastryBakery.Test
{
  [TestClass]
  public class ProductTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void PriceCalculatorPastry_CalculatesPriceOfPastryBasedOnQuantity_12()
    {
      Pastry newPastry = new Pastry(7);
      Assert.AreEqual("12.00", newPastry.PriceCalculatorPastry());
    }

    [TestMethod]
    public void PriceCalculatorPastry_CalculatesPriceOfPastryBasedOnQuantity_14()
    {
      Pastry newPastry = new Pastry(8);
      Assert.AreEqual("14.00", newPastry.PriceCalculatorPastry());
    }

    [TestMethod]
    public void PriceCalculatorPastry_CalculatesPriceOfPastryBasedOnQuantity_18()
    {
      Pastry newPastry = new Pastry(9);
      Assert.AreEqual("15.00", newPastry.PriceCalculatorPastry());
    }
  }
}