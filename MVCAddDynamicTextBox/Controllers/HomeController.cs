using MVCAddDynamicTextBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAddDynamicTextBox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(Custodel model)
        {
            // save to the database
            return View();

        }

        public ActionResult DynamicTextbox()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DynamicTextbox(string[] txtBoxes)
        {
            string txtBoxValues = "";
            foreach (string textboxValue in txtBoxes)
            {
                txtBoxValues += textboxValue + "\\n";
            }
            ViewBag.DemoMessage = txtBoxValues;

            return View();
        }
    }
}