using H1B_Analysis_Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace H1B_Analysis_Project.Controllers
{
    public class ReadWageGroupJSONController : Controller
    {
        // GET: ReadFullTimeJSON
        public ActionResult Index()
        {
            var wageGroupList = ListWageGroupData();
            return View(wageGroupList);
        }

        // Create a list of JSON objects 
        public IEnumerable ListWageGroupData()
        {
            string wageGroupPath = ConfigurationManager.AppSettings["WageGroupLoc"];
            //get the Json filepath              
            string file = HostingEnvironment.MapPath(@"~" + wageGroupPath);
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            var wagegrouplist = JsonConvert.DeserializeObject<List<WageGroup>>(Json); //ser.Deserialize<List<Company>>(Json);        
            return wagegrouplist;
        }
    }
}