using System;
using BreadBakery.Models;
using PastryBakery.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("----------Welcome To Pierre's Bakery!----------");
    Console.WriteLine("Our Bread Prices are: $5 for each loaf, or every third loaf of bread is free!!!");
    Console.WriteLine("Our Pastry Prices are: $2 for each || If you get between three and five pastries you get a $1 off || Every half dozen is $2 off!!!");
    Console.WriteLine("-------------------------------------------------------------------------------");

    Console.WriteLine("How many loaves of bread would you like?");
    string breadInput = Console.ReadLine();
    Bread newBread = new Bread(breadInput);
    newBread.BreadSales();
    newBread.BreadDiscount();
    Console.WriteLine($"You ordered {breadInput} loaves of bread");
    int totalPrice = newBread.BreadSalesTotal;
    Console.WriteLine(totalPrice);

  }
}