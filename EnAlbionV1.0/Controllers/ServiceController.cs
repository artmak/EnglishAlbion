using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnAlbionV1._0.Controllers
{
    public class ServiceController : Controller
    {
        //
        // GET: /Service/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OurMethods() 
        {
            return View();
        }
        public ActionResult OurClasses()
        {
            return View();
        }
        public ActionResult SummerIntensive()
        {
            return View();
        }
        public ActionResult Training()
        {
            return View();
        }
        public ActionResult IntTraining() 
        {
            ViewBag.VNO = "Внешнее независиме оценивание";
            ViewBag.TOEFL = "Test of English as a Foreign Language";
            return View();
        }

    }
}
