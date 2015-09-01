using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hello_World.Models;
using System.Web.Mvc;

namespace Hello_World.Controllers
{
    
    public class Future:Controller
    {
      
          public ActionResult Index()
          {
               // Add action logic here
               throw new NotImplementedException();
          }

          public ActionResult Details(int Id)
          {

               return View("Details");
          }

    }

}
