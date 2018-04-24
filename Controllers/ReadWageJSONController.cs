using H1B_Analysis_Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H1B_Analysis_Project.Controllers
{
    public class ReadWageJSONController : Controller
    {
        // GET: ReadWageJSON
        public ActionResult Index()
        {
            var wageList = ListWageData();
            return View(wageList);
        }

        public IEnumerable ListWageData()
        {
            string wagePath = ConfigurationManager.AppSettings["WageLoc"];
            //get the Json filepath              
            string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, wagePath);
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            var wagelist = JsonConvert.DeserializeObject<List<Wage>>(Json); //ser.Deserialize<List<Company>>(Json);        
            return wagelist;
        }
    }
}