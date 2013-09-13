using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnAlbionV1._0.Controllers
{
    public class SchoolController : Controller
    {
        //
        // GET: /School/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult English()
        {
            return View();
        }

        public ActionResult English_business_rates()
        {
            return View();
        }
        public ActionResult German()
        {
            return View();
        }
        public ActionResult Chinese() 
        {
            return View();
        }
        public ActionResult French() 
        {
            return View();
        }
    }
}
