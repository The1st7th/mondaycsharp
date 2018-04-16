using System;
using Microsoft.AspNetCore.Mvc;
using vacation.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/form")]
        public ActionResult Form()
        {
          return View();
        }

        [Route("/order")]
        public ActionResult Visit()
        {
          Local order = new Local();
          order.setLocalFood(Request.Query["location"], Request.Query["food"]);
          Console.WriteLine(order.localFood["vienna"]);
          return View("Visit", order);
        }
        [Route("/journal")]
        public ActionResult Journal()
        {
          return View();
        }
    }
}
