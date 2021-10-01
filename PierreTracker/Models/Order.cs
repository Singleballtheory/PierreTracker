using System.Collections.Generic;

namespace PierreTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public string OrderDate { get; set; }
    public string OrderPrice { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string orderTitle, string orderDescription, string orderDate, string orderPrice)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
      OrderDate = orderDate;
      OrderPrice = orderPrice;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}