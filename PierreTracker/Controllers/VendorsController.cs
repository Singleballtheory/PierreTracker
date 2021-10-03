using Microsoft.AspNetCore.Mvc;
using PierreTracker.Models;
using System.Collections.Generic;

namespace PierreTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor myVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{Id}")]
    public ActionResult Show(int Id)
    {
      Vendor vendor = Vendor.Find(Id);
      return View(vendor);
    }

  }
}