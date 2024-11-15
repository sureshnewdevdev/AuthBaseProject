using AuthenticationApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            SessionModel sessionModel = new SessionModel();
            Session.Add("UserName", User.Identity.Name);

            if (User.IsInRole("Admin"))
            {

                sessionModel.Role = "Admin";
                sessionModel.Addess = "dsfdfsdfds";
                sessionModel.Name = User.Identity.Name;

                Session.Add("SessionModel", sessionModel);
         

                Session.Add("Role", "Admin");
                ViewBag.Role = "Admin";
                // Logic for admin users
            }
            else
            {
                Session.Add("Role", "Customer");
                ViewBag.Role = "Customer";
            }
            return View();
        }

        public ActionResult About()
        {

            var sessionModel = Session["SessionModel"] as SessionModel;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}