using System;

namespace PastryBakery.Models
{
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
        decimal priceDec =  ((Quantity * 2)*(5/6m));
        string price = priceDec.ToString("N2");
        return price;
      }
      else if (Quantity % 3 == 1)
      {
        decimal priceDec =  (((Quantity - 1) * 2)*(5/6m) + 2);
        string price = priceDec.ToString("N2");
        return price;
      }
      else if (Quantity % 3 == 2)
      {
        decimal priceDec =  (((Quantity - 2) * 2)*(5/6m) + 4);
        string price = priceDec.ToString("N2");
        return price;
      }
      else
      {
        return "I'm sorry, there was a problem with your order";
      }
    }
  }
}