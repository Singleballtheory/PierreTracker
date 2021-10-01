using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierreTracker.Models;

namespace PierreTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", "test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string orderTitle = "Bread purchase";
      Order newOrder = new Order(orderTitle, "test", "test", "test");
      string result = newOrder.OrderTitle;
      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string orderDescription = "20 loaves of bread at $2 each";
      Order newOrder = new Order("test", orderDescription, "test", "test");
      string result = newOrder.OrderDescription;
      Assert.AreEqual(orderDescription, result);
    }

    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_String()
    {
      string orderDate = "October 1, 2021";
      Order newOrder = new Order("test", "test", orderDate, "test");
      string result = newOrder.OrderDate;
      Assert.AreEqual(orderDate, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_String()
    {
      string orderPrice = "$40";
      Order newOrder = new Order("test", "test", "test", orderPrice);
      string result = newOrder.OrderPrice;
      Assert.AreEqual(orderPrice, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string orderTitle1 = "Bread purchase";
      string orderTitle2 = "Pastry purchase";
      string orderDescription1 = "20 loaves of bread at $2 each";
      string orderDescription2 = "30 pastries at $1 each";
      string orderDate1 = "October 1, 2021";
      string orderDate2 = "Last Tuesday";
      string orderPrice1 = "$40";
      string orderPrice2 = "$20 and a bag of doritos";
      Order newOrder1 = new Order(orderTitle1, orderDescription1, orderDate1, orderPrice1);
      Order newOrder2 = new Order(orderTitle2, orderDescription2, orderDate2, orderPrice2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}