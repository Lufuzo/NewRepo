using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaySpaceAssessmentApplication.Models
{
    public class TaxCalculationViewModel
    {
        [Key]
        public int taxID { get; set; }
        [Required]
        [Display(Name = "Post Code")]
        public string PostCode { get; set; }
        public string TaxTotal { get; set; }
        public DateTime transcationDate { get; set; }
        [Required]
        [Display(Name = "Yearly  Salary")]
        public string YearlySalary { get; set; }
    }
}