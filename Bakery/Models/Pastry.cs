namespace PastryBakery.Models
{
  public class Pastry
  {
    public int PastryCount {get; set;}
    public int PastrySalesTotal {get; set;}

    public Pastry(string pastries)
    {
      PastryCount = int.Parse(pastries);
      PastrySalesTotal = 0;
    }

    public int PastrySales()
    {

    }

  }
}