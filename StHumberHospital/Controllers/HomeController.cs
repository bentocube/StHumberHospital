using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace StHumberHospital.Controllers
{
    public class HomeController : Controller
    {   //This controller handles input and returns the hindex view
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        
       
    }

  
}