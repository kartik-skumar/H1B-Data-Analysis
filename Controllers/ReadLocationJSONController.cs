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
    public class ReadLocationJSONController : Controller
    {
        // GET: ReadLocationJSON
        public ActionResult Index()
        {
            var locationList = ListLocationData();
            return View(locationList);
        }
        // Create a list of JSON objects 
        public IEnumerable ListLocationData()
        {
            string locationPath = ConfigurationManager.AppSettings["LocationLoc"];
            //get the Json filepath              
            string file = HostingEnvironment.MapPath(@"~" + locationPath);
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            var locationlist = JsonConvert.DeserializeObject<List<State>>(Json); //ser.Deserialize<List<Company>>(Json);        
            return locationlist;
        }
    }
}