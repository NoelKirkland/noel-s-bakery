using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.TestTools
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
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
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

// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()