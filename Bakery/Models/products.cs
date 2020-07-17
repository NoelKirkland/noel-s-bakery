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

    public string PriceCalculatorBread()
    {
      if (Quantity % 3 == 0)
      {
        decimal priceDec =  ((Quantity * 5)*(2/3m));
        string price = priceDec.ToString("N2");
        return price;
      }
      else if (Quantity % 3 == 1)
      {
        decimal priceDec =  (((Quantity - 1) * 5)*(2/3m) + 5);
        string price = priceDec.ToString("N2");
        return price;
      }
      else if (Quantity % 3 == 2)
      {
        decimal priceDec =  (((Quantity - 2) * 5)*(2/3m) + 10);
        string price = priceDec.ToString("N2");
        return price;
      }
      else
      {
        return "I'm sorry, there was a problem with your order";
      }
    }

  }
  public class Pastry
  {
    public int Quantity {get; set; }

    public Pastry(int quantity)
    {
      Quantity = quantity;
    }
    public string PriceCalculatorPastry()
    {
      if (Quantity % 3 == 0)
      {
        int priceInt = (Quantity * 2);
        string price = priceInt.ToString();
        return price;
      }
      else
      {
        return "I'm sorry, there was a problem with your order";
      }
    }
  }
}