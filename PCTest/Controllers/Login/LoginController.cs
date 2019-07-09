using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PCTest.Controllers.Login
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
           return RedirectToAction("ResultView", "Student");
        }
    }
}