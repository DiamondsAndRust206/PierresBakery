namespace PastryBakery.Models
{
  public class Pastry
  {
    public int PastryCount {get; set;}

    public Pastry(string pastries)
    {
      PastryCount = int.Parse(pastries);
    }


  }
}