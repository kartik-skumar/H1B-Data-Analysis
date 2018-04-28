using H1B_Analysis_Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace H1B_Analysis_Project.Controllers
{
    public class ReadCompanyJSONController : Controller
    {
        // GET: ReadJSON
        public ActionResult Index()
        {                        
            var companyList = ListCompanyData();
            return View(companyList);
        }
        // Create a list of JSON objects 
        public IEnumerable ListCompanyData()
        {
            string companyPath = ConfigurationManager.AppSettings["CompanyLoc"];
            //get the Json filepath   
            string file = HostingEnvironment.MapPath(@"~" + companyPath);
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);            
            var companylist = JsonConvert.DeserializeObject<List<Company>>(Json); //ser.Deserialize<List<Company>>(Json);        
            return companylist;
        }
    }
}