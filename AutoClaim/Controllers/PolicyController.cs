using AutoClaim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoClaim.Controllers
{
    public class PolicyController : Controller
    {
        private ApplicationDbContext dbContext = null;
        public PolicyController()
        {
            dbContext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        // GET: Policy
        public ActionResult Index()
        {
           
            return View();


        }
        [HttpGet]
        public ActionResult Registration( )
        {
           


            return View();
        }
        [HttpPost]
        public ActionResult Registration(Policy policy)
        {



            return View();
        }

    }
}