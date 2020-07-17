using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }

    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    public int PriceCalculatorBread()
    {
      return (Quantity * 5);
    }
  }
  public class Pastry
  {
    public int Quantity {get; set; }

    public Pastry(int quantity)
    {
      Quantity = quantity;
    }
    public int PriceCalculatorPastry()
    {
      return (Quantity);
    }
  }
}