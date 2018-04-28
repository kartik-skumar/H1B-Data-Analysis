using System;
using System.Collections.Generic;
using System.Configuration;
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
        // Fetch JSON result from the company list 
        public JsonResult StackedColumnChart()
        {
            ReadCompanyJSONController readJSON = new ReadCompanyJSONController();            
            var chartsData = readJSON.ListCompanyData();
            return Json(chartsData, JsonRequestBehavior.AllowGet);
        }
    }
}