using System;
using BreadBakery.Models;
using PastryBakery.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("");
    Console.WriteLine("           ~ <|---------- WELCOME TO PIERRE'S BAKERY ----------|> ~");
    Console.WriteLine("");
    Console.WriteLine("- BREAD PRICES : $5 for each loaf, or every third loaf of bread is free!!!");
    Console.WriteLine("- PASTRY PRICES : $2 for each || If you get between three and five pastries you get a $1 off || Every half dozen is $2 off!!!");
    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< * >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    Console.WriteLine("");

    Console.WriteLine("How many loaves of bread would you like?");
    string breadInput = Console.ReadLine();
    Bread newBread = new Bread(breadInput);
    newBread.BreadSales();
    newBread.BreadDiscount();
    Console.WriteLine($"You ordered {breadInput} loaves of bread");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+");

    Console.WriteLine(""); 
    Console.WriteLine("How many pastries would you like?");
    string pastryInput = Console.ReadLine();
    Pastry newPastry = new Pastry(pastryInput);
    newPastry.PastrySales();
    newPastry.PastryDiscount();
    Console.WriteLine($"You ordered {pastryInput} pastries");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+");

    Console.WriteLine("");
    int totalPrice = newBread.BreadSalesTotal + newPastry.PastrySalesTotal;
    Console.WriteLine("Your Total Is: " + "$" + totalPrice);
    Console.WriteLine("Would you like to complete your purchase? (Yes/No)");
    string purchase = Console.ReadLine();
    if (purchase.ToLower() == "yes")
    {
      Console.WriteLine("");
      Console.WriteLine("Your order is complete. Thank you for your business!!");
      Console.WriteLine("--Press enter to return to main menu--");
      string toTop = Console.ReadLine();
      Main();
    }
    else if (purchase.ToLower() == "no")
    {
      Console.WriteLine("");
      Console.WriteLine("Your order is canceled. You will not be charged.");
      Console.WriteLine("--Press enter to return to main menu--");
      string toTop = Console.ReadLine();
      Main();
    }
    else
    {
      Console.WriteLine("");
      Console.WriteLine("**Incorrect input**");
      Console.WriteLine("--Press enter to start your order over--");
      string toTop = Console.ReadLine();
      Main();
    }
  
  }
}