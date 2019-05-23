using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySpaceAssessmentApplication.Tests.Model
{
    public  class TaxPayer
    {
        public int taxID { get; set; }
        public string PostCode { get; set; }
        public string YearlySalary { get; set; }
        public string TaxTotal { get; set; }
        public Nullable<System.DateTime> transcationDate { get; set; }
    }
}
