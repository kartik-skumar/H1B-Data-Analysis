using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H1B_Analysis_Project.Controllers
{
    public class DisplayChartsController : Controller
    {
        // GET: DisplayCharts
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult BarChart()
        {
            ReadJSONController readJSON = new ReadJSONController();
            var chartsData = readJSON.ListData();
            return Json(chartsData, JsonRequestBehavior.AllowGet);
        }
    }
}