using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlingerTracker.Data;
using SlingerTracker.Models;


namespace SlingerTracker.Controllers
{
    public class HomeController : Controller
    {

        private EntriesRepository _entryRepository = null;

        public HomeController()
        {
            _entryRepository = new EntriesRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddEntry()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ListView()
        {
            ViewBag.Message = "Your contact page.";

            var entry  = _entryRepository.GetEntries(); 

            return View(entry);
        }
    }
}