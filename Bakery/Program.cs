using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void grandTotal(string string1, string string2)
    {
      decimal number1 = Decimal.Parse(string1);
      decimal number2 = Decimal.Parse(string2);

      decimal total = (number1 + number2);

      Console.WriteLine("Your grand total will be $" + total);
    }

    public static void Main()
    {
      Console.WriteLine("Welcome to Noel's Bakery where we specialize in bread and pastries. Please place your order.");
      Console.WriteLine("Bread is $5.00 per loaf but if you get two loafs your third one is free.");
      Console.WriteLine("How many loafs of bread would you like?");
      string breadQuantityString = Console.ReadLine();
      int breadQuantity = int.Parse(breadQuantityString);
      Bread newBread = new Bread(breadQuantity);

      Console.WriteLine("Pastries are $2.00 each or three for $5.00");
      Console.WriteLine("How many pastries would you like?");
      string pastryQuantityString = Console.ReadLine();
      int pastryQuantity = int.Parse(pastryQuantityString);
      Pastry newPastry = new Pastry(pastryQuantity);
      Console.WriteLine("For " + newBread.Quantity + " loafs of bread your total would be $" + newBread.PriceCalculatorBread());
      Console.WriteLine("For " + newPastry.Quantity + " pastries your total would be $" + newPastry.PriceCalculatorPastry());
      grandTotal(newPastry.PriceCalculatorPastry(), newBread.PriceCalculatorBread());
      
    }
  }
}