using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task1feb.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.msg = "Customer Home Page";
            return View();
        }
        public ActionResult CustomerList() {
            List<string> list = new List<string>()
            {
                "Sam","Robin","Ramson"
            };
            ViewBag.nameList=list;
            return View();
        }
    }
}