using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H1B_Analysis_Project.Controllers
{
    public class DisplayWageGroupChartController : Controller
    {
        // GET: DisplayFullTimeChart
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ColumnChart()
        {
            ReadWageGroupJSONController readJSON = new ReadWageGroupJSONController();
            var chartsData = readJSON.ListWageGroupData();
            return Json(chartsData, JsonRequestBehavior.AllowGet);
        }
    }
}