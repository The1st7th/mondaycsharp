using System;
using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {
      [Route("/form")]
      public ActionResult Parcel()
      {
        return View();
      }

      [Route("/calculate")]
      public ActionResult Origin()
      {
        anotherparcel myParcel = new anotherparcel();
        Console.WriteLine("this is " + Request.Query["widthInput"]);
        myParcel.setParcel(int.Parse(Request.Query["widthInput"]), int.Parse(Request.Query["heightInput"]),int.Parse(Request.Query["weightInput"]));
        return View("Parcel", myParcel);
      }

    }
}
