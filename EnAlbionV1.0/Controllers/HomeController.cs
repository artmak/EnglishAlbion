using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnAlbionV1._0.Models;
using EnAlbionV1._0.Mailers;

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
        public ActionResult Vacancy()
        {
            return View();
        }

        private IUserMailer _userMailer = new UserMailer();
        public IUserMailer UserMailer
        {
            get { return _userMailer; }
            set { _userMailer = value; }
        }
    [HttpGet]
        public ViewResult Feedback() 
        {
            return View();
        }
    [HttpPost]
    public ViewResult Feedback(Response responseFeedback)
    {

        UserMailer.Feedback(responseFeedback).Send();

        if (ModelState.IsValid)
        {
            //responseFeedback.Submit();

            return View("Thanks", responseFeedback);
        }
        else {
            return View();
        }
   }
   

    }
}
