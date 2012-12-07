using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sumc.Web.Models;

namespace Sumc.Web.Controllers
{
    public class HomeController : Controller
    {
        private SumcEntities dataModel = new SumcEntities(); 

        //
        // GET: /Home/

        public ActionResult Index() {
            if (dataModel.sc_Users.Any()) {
                ViewBag.AllUsers = dataModel.sc_Users.ToList();
            }
            return View();
        }

    }
}
