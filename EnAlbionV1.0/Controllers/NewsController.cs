using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnAlbionV1._0.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Actions() 
        {
            return View();
        }
        public ActionResult Discounts()
        {
            return View();
        }

    }
}
