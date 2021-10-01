using System.Collections.Generic;

namespace PierreTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public string OrderDate { get; set; }
    public int OrderPrice { get; set; }
    private static List<Order> _instances = new List<Order> {};
  }
}