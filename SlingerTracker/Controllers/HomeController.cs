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
        // ?? creating an instance of the Entries repository ??
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

            // calling the GetEntries method from the EntriesRepository class
            var entry  = _entryRepository.GetEntries(); 

            // returning the ListView with entry as parameter
            return View(entry);
        }
    }
}