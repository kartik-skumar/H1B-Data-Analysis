using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H1B_Analysis_Project.Controllers
{
    public class DisplayLocationChartController : Controller
    {
        // GET: DisplayLocationChart
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GeoChart()
        {
            ReadLocationJSONController readJSON = new ReadLocationJSONController();
            var chartsData = readJSON.ListLocationData();
            return Json(chartsData, JsonRequestBehavior.AllowGet);
        }
    }
}