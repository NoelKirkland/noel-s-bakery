using System;
using BreadBakery.Models;
using PastryBakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void grandTotal(string string1, string string2)
    {
      decimal number1 = Decimal.Parse(string1);
      decimal number2 = Decimal.Parse(string2);
      decimal total = (number1 + number2);
      Console.WriteLine("|  Your grand total will be $" + total + "  |");
    }

    public static void Main()
    {
      Console.WriteLine(" ");
      Console.WriteLine(" ");
      Console.WriteLine(" ");
      Console.WriteLine(" _____________Welcome to Noel's Bakery_____________");
      Console.WriteLine("|                                                  |");
      Console.WriteLine("|  We specialize in bread and pastries             |");
      Console.WriteLine("|                                                  |");
      Console.WriteLine("|  Please place your order below!                  |");
      Console.WriteLine("|__________________________________________________|");
      Console.WriteLine(" ");
      Console.WriteLine(" ____________________Bread Menu____________________");
      Console.WriteLine("|                                                  |");
      Console.WriteLine("|  Bread is $5.00 per loaf or buy-two-get-one-free |");
      Console.WriteLine("|                                                  |");
      Console.WriteLine("|  How many loafs of bread would you like?         |");
      Console.WriteLine("|__________________________________________________|");
      Console.WriteLine(" ");
      string breadQuantityString = Console.ReadLine();
      int breadQuantity = int.Parse(breadQuantityString);
      Bread newBread = new Bread(breadQuantity);
      Console.WriteLine(" ");
      Console.WriteLine(" ___________________Pastry Menu____________________");
      Console.WriteLine("|                                                  |");
      Console.WriteLine("|  Pastries are $2.00 each or three for $5.00      |");
      Console.WriteLine("|                                                  |");Console.WriteLine("|  How many pastries would you like?               |");
      Console.WriteLine("|__________________________________________________|");
      Console.WriteLine(" ");
      string pastryQuantityString = Console.ReadLine();
      int pastryQuantity = int.Parse(pastryQuantityString);
      Pastry newPastry = new Pastry(pastryQuantity);
      Console.WriteLine(" ");
      Console.WriteLine(" ______________receipt______________");
      Console.WriteLine("|                                   |");
      Console.WriteLine("|  For " + newBread.Quantity + " loafs of bread:            |");
      Console.WriteLine("|  your total would be $" + newBread.PriceCalculatorBread() + "       |");
      Console.WriteLine("|                                   |");
      Console.WriteLine("|  For 6 pastries:                  |");
      Console.WriteLine("|  your total would be $" + newPastry.PriceCalculatorPastry() + "       |");
      Console.WriteLine("|                                   |");
      grandTotal(newPastry.PriceCalculatorPastry(), newBread.PriceCalculatorBread());
      Console.WriteLine("|                                   |");
      Console.WriteLine("|            Thank you!             |");
      Console.WriteLine("|___________________________________|");
            Console.WriteLine(" ");
    }
  }
}