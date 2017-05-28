using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class SpeakerController : Controller
    {
        // GET: Speaker
        public ActionResult Index()
        {
            return View();
        }
    }
}