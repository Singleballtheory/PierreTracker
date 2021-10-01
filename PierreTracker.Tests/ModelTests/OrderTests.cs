using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierreTracker.Models;

namespace PierreTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}