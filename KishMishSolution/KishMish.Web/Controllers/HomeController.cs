using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KishMish.Data.BusinessAccessLayer;
using KishMish.Web.Models.Traders;

namespace KishMish.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(Session["username"] != null)
            Response.Write(Session["username"].ToString());

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Response.Write("invalid user");

            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(VMTraders traders)
        {
            if (ModelState.IsValid)
            {
                if (BATraders.BA_AuthenticateLoginDetails(traders.UserName, traders.Password))
                {
                    ViewBag.username = "logggedd innn";
                }
                else { ViewBag.username = " not logggedd innn"; }              
            }
            return View();
        }

    }
}