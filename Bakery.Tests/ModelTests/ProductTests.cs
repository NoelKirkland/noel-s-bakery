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
    public void PriceCalculator_CalculatesPriceOfBreadBasedOnQuantity_60()
    {
      Bread newBread = new Bread(12);
      Assert.AreEqual(60, newBread.PriceCalculator());
    }
  }
}

// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()