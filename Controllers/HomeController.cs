using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceProject.Models;

namespace EcommerceProject.Controllers
{
    public class HomeController : Controller
    {
        AdminContext db = new AdminContext();
        public ActionResult Home(string searching)
        {
            return View(db.CategoryTable.Where(x => x.Name.Contains(searching) || searching == null).ToList());
        }
       
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Service()
        {
            return View();
        }
    }
}