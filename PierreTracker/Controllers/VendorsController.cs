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
    }
}