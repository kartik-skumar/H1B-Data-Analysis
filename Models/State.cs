using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H1B_Analysis_Project.Models
{
    public class State
    {
        public string StateName { get; set; }
        public double NumberOfCertifiedCases { get; set; }        
        public double AverageWage { get; set; }
        public double TotalJobs { get; set; }
    }
}