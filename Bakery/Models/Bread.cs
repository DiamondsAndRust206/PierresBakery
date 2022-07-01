namespace BreadBakery.Models
{
  public class Bread
  {
    public int BreadCount {get; set;}
    public int BreadSalesTotal {get; set;}

    public Bread(string bread)
    {
      BreadCount = int.Parse(bread);
      BreadSalesTotal = 0;
    }

    public int BreadSales()
    {
      for (int i = 0; i < BreadCount; i++)
      {
        BreadSalesTotal += 5;
      }
      return BreadSalesTotal;
    }

    public int BreadDiscount()
    {
      if (BreadCount % 3 == 0 && BreadCount >= 3)
      {
        BreadSalesTotal -= 5;
      }
      return BreadSalesTotal;
    }

  }
}