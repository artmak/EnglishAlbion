using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnAlbionV1._0.Models;

namespace EnAlbionV1._0.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About() 
        {
            return View();
        }
        public ActionResult Contacts()
        {
            return View();
        }
        
    [HttpGet]
        public ViewResult Feedback() 
        {
            return View();
        }
    [HttpPost]
    public ViewResult Feedback(Response responseFeedback)
    {
        if (ModelState.IsValid)
        {
            responseFeedback.Submit();
            return View("Thanks", responseFeedback);
        }
        else {
            return View();
        }
   }
   

    }
}
