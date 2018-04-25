using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H1B_Analysis_Project.Models
{
    public class WageGroup
    {
        public string IncomeGroup { get; set; }
        public int Certified { get; set; }
        public int Withdrawn { get; set; }
        public int CertifiedWithdrawn { get; set; }
        public int Denied { get; set; }
    }
}