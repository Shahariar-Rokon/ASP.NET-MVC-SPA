using CodeV4.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeV4.Controllers
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
        public ActionResult GeneratePDF()
        {
            var model = new IntroductionModel
            {
                Name = "MD. Shahariar Rokon",
                Degree = " " + "BSc in Statistics, MSc Applied Statistics in Data Science",
                Diploma = " "+ "Diploma in Enterprise System Analysis and Design using C#",
                ContactInfo = " "+"Email:srokon47@gmail.com"+"\n"+"Phone:+8801521201351"

            };

            return new Rotativa.ViewAsPdf("PDFView", model) { FileName = "Introduction.pdf" };
        }
    }
}