using H1B_Analysis_Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace H1B_Analysis_Project.Controllers
{
    public class ReadJSONController : Controller
    {
        // GET: ReadJSON
        public ActionResult Index()
        {            
            var companyList = ListData();
            return View(companyList);
        }

        public IEnumerable ListData()
        {           
            //get the Json filepath  
            string file = @"C:\Users\Kartik\Documents\Data Programming\Project\H1B Analysis Project\H1B Analysis Project\company.json";
            
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            var companylist = JsonConvert.DeserializeObject<List<Company>>(Json); //ser.Deserialize<List<Company>>(Json);        
            return companylist;
        }
    }
}