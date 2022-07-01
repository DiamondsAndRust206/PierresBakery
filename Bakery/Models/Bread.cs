namespace BreadBakery.Models
{
  public class Bread
  {
    public int BreadCount {get; set;}
    public Bread(string bread)
    {
      BreadCount = int.Parse(bread);
      BreadSalesTotal = 0;
    }

    public int BreadSales()
    {
      
    }
  }
}