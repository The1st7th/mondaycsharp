using System;
using Microsoft.AspNetCore.Mvc;
using Triangles.Models;

namespace Triangles.Controllers
{
    public class HomeController : Controller
    {
      [Route("/form")]
      public ActionResult TriangleShape()
      {
        return View();
      }

      [Route("/calculate")]
      public ActionResult Origin()
      {
        Triangle myTriangle = new Triangle();
        myTriangle.setTriangle(int.Parse(Request.Query["sideA"]), int.Parse(Request.Query["sideB"]),int.Parse(Request.Query["sideC"]));
        
        myTriangle.setmessage();
        return View("TriangleShape", myTriangle);
      }

    }
}
