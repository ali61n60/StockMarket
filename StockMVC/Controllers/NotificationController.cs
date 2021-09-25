using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMVC.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetNotificationContacts()
        {
            //var notificationRegisterTime = Session["LastUpdated"] != null ? Convert.ToDateTime(Session["LastUpdated"]) : DateTime.Now;
            //NotificationComponent NC = new NotificationComponent();
            //var list = NC.GetContacts(notificationRegisterTime);
            ////update session here for get only new added contacts (notification)
            //Session["LastUpdate"] = DateTime.Now;
            //return new JsonResult { Data = list, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            return null;
        }


    }
}
