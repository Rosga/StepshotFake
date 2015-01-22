using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stepshot.Controllers
{
    public class ConfluenceController : Controller
    {
        // GET: Confluence
        [Route("confluesnce")]
        public ActionResult Index()
        {
            ViewBag.Type = "confluence";
            return View();
        }
    }
}