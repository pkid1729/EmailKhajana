using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmailKhajana.Controllers
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
        public ActionResult SaveEmailIntoFile(String Email,String Pass)
        {
            ViewBag.Email = Email;
            string path = Server.MapPath("~/EmailData/ListOfEmail.txt");
            using (StreamWriter emailWriter = new StreamWriter(path, true))
            {
                System.IO.File.Create(path);
                emailWriter.WriteLine(Email);
            }
            //if (!system.io.file.exists(path))
            //{
            //    using (StreamWriter emailWriter = new StreamWriter(path,true))
            //    {
            //        System.IO.File.Create(path);
            //        emailWriter.WriteLine(Email);
            //    }

            //}
            //else
            //{
            //    using (StreamWriter emailWriter = new StreamWriter(path, true))
            //    {
            //        System.IO.File.Create(path);
            //        emailWriter.WriteLine(Email);
            //    }

            //}


            return View();
        }
    }
}