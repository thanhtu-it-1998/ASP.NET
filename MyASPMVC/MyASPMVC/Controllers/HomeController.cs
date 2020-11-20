using MyASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyASPMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string id)
        {
            MyModel myModel = new MyModel();
            myModel.Name = "THƯ VIỆN LẬP  TRÌNH";
            myModel.Phone = "0456976655";

            ViewBag.Message = "Your application description page. " + id;
            ViewBag.ThuocTinh= "Xxx. " + id;
            ViewBag.OB= myModel;

            return View(myModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}