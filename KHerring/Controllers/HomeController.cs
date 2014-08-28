using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoogleCalendarModel;
using KHerring.Models;

namespace KHerring.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private readonly ICalendarRepository _calendarRepo;
        public HomeController()
        {
            _calendarRepo = new GoogleCalendarPublicRepository("rpxxxiv@gmail.com");
        }
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult HomePage()
        {
            return PartialView();
        }

        public ActionResult CheckItOut()
        {
            return PartialView();
        }

        public ActionResult GetNavigationLinks()
        {
            NavigationLinks nl = new NavigationLinks();
            
            return PartialView(nl.GetLinks());
        }
        public ActionResult LoadCalendar()
        {
            
            return PartialView();
        }

        
        public JsonResult GetEvents()
        {
            var events = _calendarRepo.GetAll();
            JsonResult jr = Json(events,JsonRequestBehavior.AllowGet);
            return jr;
        }
    }
}
