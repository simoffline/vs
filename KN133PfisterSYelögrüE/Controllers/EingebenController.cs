using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KN133PfisterSYelögrüE.Controllers
{
    public class EingebenController : Controller
    {
        // GET: Eingeben
        public ActionResult Eingeben()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Eingeben(string btn)
        {
            
            return View((object)btn);
        }
    }
}