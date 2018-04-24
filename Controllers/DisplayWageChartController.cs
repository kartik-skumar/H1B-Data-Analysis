using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H1B_Analysis_Project.Controllers
{
    public class DisplayWageChartController : Controller
    {
        // GET: DisplayWageChart
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult DonutChart()
        {
            ReadWageJSONController readJSON = new ReadWageJSONController();
            var chartsData = readJSON.ListWageData();
            return Json(chartsData, JsonRequestBehavior.AllowGet);
        }
    }
}