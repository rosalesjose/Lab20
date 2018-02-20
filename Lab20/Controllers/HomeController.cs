using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

namespace Lab20.Controllers
{
    public class HomeController : Controller
    {
        #region ViewPages
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

        public ActionResult Register()
        {
            return View("UserRegistration");
        }
        #endregion

        public ActionResult GetUserInfo(string FirstName, string LastName, string Phone, string Password)
        {
            if (FirstName == "" || LastName == "")
            {
                TempData["msg"] = "<script>alert('Enter the name correctly!');</script>";
                return View("UserRegistration");
            }
            else if (Phone == "")
            {
                TempData["msg"] = "<script>alert('Enter the phone number correctly!');</script>";
                return View("UserRegistration");
            }
            else if (Password == "")
            {
                TempData["msg"] = "<script>alert('Enter the password correctly!');</script>";
                return View("UserRegistration");
            }

            ViewBag.Fname = FirstName;

            return View("Summary");
        }
    }
}