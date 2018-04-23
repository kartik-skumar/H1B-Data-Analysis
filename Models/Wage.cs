using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H1B_Analysis_Project.Models
{
    public class Wage
    {
        public string SOCName { get; set; }
        public double WageIn2015 { get; set; }
        public double WageIn2016 { get; set; }
        public double TotalAverageWage { get; set; }
    }
}