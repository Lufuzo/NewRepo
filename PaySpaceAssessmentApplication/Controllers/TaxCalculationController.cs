using PaySpaceAssessmentApplication.Domain.Concrete;
using PaySpaceAssessmentApplication.Domain.Model;
using PaySpaceAssessmentApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaySpaceAssessmentApplication.Controllers
{
    public class TaxCalculationController : Controller
    {


        private PaySpaceAssessmentApplicationReposatory _paySpaceAssessmentApplicationReposatory;

        public TaxCalculationController()
        {
            _paySpaceAssessmentApplicationReposatory = new PaySpaceAssessmentApplicationReposatory();
        }

        // GET: TaxCalculation
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public ActionResult CalculateTax(string postalCode, string annaulSalary)
        {

            TaxCalculationViewModel taxCalculationViewModel = new TaxCalculationViewModel();
          
            double Salary = double.Parse(annaulSalary);
            double taxedAmount = 0.0;
  
            if (postalCode == "7741")
            {
                if ((Salary > 0) && (Salary <= 8350))
                {

                    double taxRate1 =  0.1;
                    taxedAmount = Salary * taxRate1;

                    taxCalculationViewModel.taxID = 0;
                    taxCalculationViewModel.YearlySalary = annaulSalary;
                    taxCalculationViewModel.TaxTotal = taxedAmount.ToString();
                    taxCalculationViewModel.PostCode = postalCode;
                    taxCalculationViewModel.transcationDate = DateTime.Now;

                    Tax_CalculationTable tax = new Tax_CalculationTable();
                    tax.taxID = taxCalculationViewModel.taxID;
                    tax.YearlySalary = taxCalculationViewModel.YearlySalary;
                    tax.TaxTotal = taxCalculationViewModel.TaxTotal;
                    tax.PostCode = taxCalculationViewModel.PostCode;
                    tax.transcationDate = DateTime.Now;
                    //Call the bool to create text amount
                    _paySpaceAssessmentApplicationReposatory.SaveCalculatedTax(tax);
                   
                }
                else {
                    if ((Salary > 8351) && (Salary <= 33950))
                    {
                        double taxRate1 = 0.15;
                        taxedAmount = Salary * taxRate1;

                        taxCalculationViewModel.taxID = 0;
                        taxCalculationViewModel.YearlySalary = annaulSalary;
                        taxCalculationViewModel.TaxTotal = taxedAmount.ToString();
                        taxCalculationViewModel.PostCode = postalCode;
                        taxCalculationViewModel.transcationDate = DateTime.Now;

                        Tax_CalculationTable tax = new Tax_CalculationTable();
                        tax.taxID = taxCalculationViewModel.taxID;
                        tax.YearlySalary = taxCalculationViewModel.YearlySalary;
                        tax.PostCode = taxCalculationViewModel.PostCode;
                        tax.TaxTotal = taxCalculationViewModel.TaxTotal;
                        tax.transcationDate = DateTime.Now;

                        //Call the bool to create text amount
                        _paySpaceAssessmentApplicationReposatory.SaveCalculatedTax(tax);

                    }
                    else
                        if ((Salary > 33951) && (Salary <= 82250))
                       {
                        double taxRate1 = 0.25;
                        taxedAmount = Salary * taxRate1;

                        taxCalculationViewModel.taxID = 0;
                        taxCalculationViewModel.YearlySalary = annaulSalary;
                        taxCalculationViewModel.TaxTotal = taxedAmount.ToString();
                        taxCalculationViewModel.PostCode = postalCode;
                        taxCalculationViewModel.transcationDate = DateTime.Now;

                        Tax_CalculationTable tax = new Tax_CalculationTable();
                        tax.taxID = taxCalculationViewModel.taxID;
                        tax.YearlySalary = taxCalculationViewModel.YearlySalary;
                        tax.TaxTotal = taxCalculationViewModel.TaxTotal;
                        tax.PostCode = taxCalculationViewModel.PostCode;
                        tax.transcationDate = DateTime.Now;
                        //Call the bool to create text amount
                        _paySpaceAssessmentApplicationReposatory.SaveCalculatedTax(tax);

                    }
                    else
                        if ((Salary > 82251) && (Salary <= 171550))
                        {
                        double taxRate1 = 0.28;
                        taxedAmount = Salary * taxRate1;

                        taxCalculationViewModel.taxID = 0;
                        taxCalculationViewModel.YearlySalary = annaulSalary;
                        taxCalculationViewModel.TaxTotal = taxedAmount.ToString();
                        taxCalculationViewModel.PostCode = postalCode;
                        taxCalculationViewModel.transcationDate = DateTime.Now;

                        Tax_CalculationTable tax = new Tax_CalculationTable();

                        tax.taxID = taxCalculationViewModel.taxID;
                        tax.YearlySalary = taxCalculationViewModel.YearlySalary;
                        tax.TaxTotal = taxCalculationViewModel.TaxTotal;
                        tax.PostCode = taxCalculationViewModel.PostCode;
                        tax.transcationDate = DateTime.Now;
                        //Call the bool to create text amount
                        _paySpaceAssessmentApplicationReposatory.SaveCalculatedTax(tax);

                    }
                    else
                        if ((Salary > 171551) && (Salary <= 372950))
                        {
                        double taxRate1 = 0.33;
                        taxedAmount = Salary * taxRate1;

                        taxCalculationViewModel.taxID = 0;
                        taxCalculationViewModel.YearlySalary = annaulSalary;
                        taxCalculationViewModel.TaxTotal = taxedAmount.ToString();
                        taxCalculationViewModel.PostCode = postalCode;
                        taxCalculationViewModel.transcationDate = DateTime.Now;

                        Tax_CalculationTable tax = new Tax_CalculationTable();

                        tax.taxID = taxCalculationViewModel.taxID;
                        tax.YearlySalary = taxCalculationViewModel.YearlySalary;
                        tax.TaxTotal = taxCalculationViewModel.TaxTotal;
                        tax.PostCode = taxCalculationViewModel.PostCode;
                        tax.transcationDate = DateTime.Now;
                        //Call the bool to create text amount
                        _paySpaceAssessmentApplicationReposatory.SaveCalculatedTax(tax);

                    }
                    else
                       if ((Salary > 171551) && (Salary <= 372950))
                        {
                            double taxRate1 = 0.35;
                            taxedAmount = Salary * taxRate1;

                            taxCalculationViewModel.taxID = 0;
                            taxCalculationViewModel.YearlySalary = annaulSalary;
                            taxCalculationViewModel.TaxTotal = taxedAmount.ToString();
                            taxCalculationViewModel.PostCode = postalCode;
                            taxCalculationViewModel.transcationDate = DateTime.Now;

                            Tax_CalculationTable tax = new Tax_CalculationTable();
                            tax.taxID = taxCalculationViewModel.taxID;
                            tax.YearlySalary = taxCalculationViewModel.YearlySalary;
                            tax.TaxTotal = taxCalculationViewModel.TaxTotal;
                            tax.PostCode = taxCalculationViewModel.PostCode;
                            tax.transcationDate = DateTime.Now;
                            //Call the bool to create text amount
                            _paySpaceAssessmentApplicationReposatory.SaveCalculatedTax(tax);

                    }
                    else
                        if (Salary > 372951)
                        {
                        double taxRate1 = 0.35;
                        taxedAmount = Salary * taxRate1;

                        taxCalculationViewModel.taxID = 0;
                        taxCalculationViewModel.YearlySalary = annaulSalary;
                        taxCalculationViewModel.TaxTotal = taxedAmount.ToString();
                        taxCalculationViewModel.PostCode = postalCode;
                        taxCalculationViewModel.transcationDate = DateTime.Now;

                        Tax_CalculationTable tax = new Tax_CalculationTable();
                        tax.taxID = taxCalculationViewModel.taxID;
                        tax.YearlySalary = taxCalculationViewModel.YearlySalary;
                        tax.TaxTotal = taxCalculationViewModel.TaxTotal;
                        tax.PostCode = taxCalculationViewModel.PostCode;
                        tax.transcationDate = DateTime.Now;
                        //Call the bool to create text amount
                        _paySpaceAssessmentApplicationReposatory.SaveCalculatedTax(tax);

                    }
                 }
            }
            if (postalCode == "A100")
            {
                if (Salary == 10000)
                {
                    double taxRate2 = 17.3 * 100;
                    double totalTaxed = Salary * taxRate2;


                    taxCalculationViewModel.taxID = 0;
                    taxCalculationViewModel.YearlySalary = annaulSalary;
                    taxCalculationViewModel.TaxTotal = totalTaxed.ToString();
                    taxCalculationViewModel.PostCode = postalCode;
                    taxCalculationViewModel.transcationDate = DateTime.Now;

                    Tax_CalculationTable tax = new Tax_CalculationTable();
                    tax.taxID = taxCalculationViewModel.taxID;
                    tax.YearlySalary = taxCalculationViewModel.YearlySalary;
                    tax.TaxTotal = taxCalculationViewModel.TaxTotal;
                    tax.PostCode = taxCalculationViewModel.PostCode;
                    tax.transcationDate = DateTime.Now;
                    //Call the bool to create text amount
                    _paySpaceAssessmentApplicationReposatory.SaveCalculatedTax(tax);


                }
                else
                {
                    if(Salary < 171550)
                    {
                        double taxR = 0.05;
                        double totalTax = Salary * taxR;

                        taxCalculationViewModel.taxID = 0;
                        taxCalculationViewModel.YearlySalary = annaulSalary;
                        taxCalculationViewModel.TaxTotal = taxedAmount.ToString();
                        taxCalculationViewModel.PostCode = postalCode;
                        taxCalculationViewModel.transcationDate = DateTime.Now;

                        Tax_CalculationTable tax = new Tax_CalculationTable();
                        tax.taxID = taxCalculationViewModel.taxID;
                        tax.YearlySalary = taxCalculationViewModel.YearlySalary;
                        tax.TaxTotal = taxCalculationViewModel.TaxTotal;
                        tax.PostCode = taxCalculationViewModel.PostCode;
                        tax.transcationDate = DateTime.Now;
                        //Call the bool to create text amount
                        _paySpaceAssessmentApplicationReposatory.SaveCalculatedTax(tax);

                    }
                }
                
            }
            if (postalCode == "7000")
            {

                double FatRa = 17.5;
                double totalTaxVal = Salary * FatRa;

                taxCalculationViewModel.taxID = 0;
                taxCalculationViewModel.YearlySalary = annaulSalary;
                taxCalculationViewModel.TaxTotal = totalTaxVal.ToString();
                taxCalculationViewModel.PostCode = postalCode;
                taxCalculationViewModel.transcationDate = DateTime.Now;

                Tax_CalculationTable tax = new Tax_CalculationTable();

                tax.taxID = taxCalculationViewModel.taxID;
                tax.YearlySalary = taxCalculationViewModel.YearlySalary;
                tax.TaxTotal = taxCalculationViewModel.TaxTotal;
                tax.PostCode = taxCalculationViewModel.PostCode;
                tax.transcationDate = DateTime.Now;
                //Call the bool to create text amount
                _paySpaceAssessmentApplicationReposatory.SaveCalculatedTax(tax);

            }
            if (postalCode == "1000")
            {
                double proR = 17.5;
                double totalTaxValue = Salary * proR;

                taxCalculationViewModel.taxID = 0;
                taxCalculationViewModel.YearlySalary = annaulSalary;
                taxCalculationViewModel.TaxTotal = totalTaxValue.ToString();
                taxCalculationViewModel.PostCode = postalCode;
                taxCalculationViewModel.transcationDate = DateTime.Now;

                Tax_CalculationTable tax = new Tax_CalculationTable();
                tax.taxID = taxCalculationViewModel.taxID;
                tax.YearlySalary = taxCalculationViewModel.YearlySalary;
                tax.TaxTotal = taxCalculationViewModel.TaxTotal;
                tax.PostCode = taxCalculationViewModel.PostCode;
                tax.transcationDate = DateTime.Now;

                //Call the bool to create text amount
                _paySpaceAssessmentApplicationReposatory.SaveCalculatedTax(tax);

             }
            return RedirectToAction("TaxPayersList");
        }

        public ActionResult TaxPayersList([Bind(Include = "PostCode,TaxTotal,TaxTotal,TaxTotal,TaxTotal")]TaxCalculationViewModel taxCalculationViewModel)
        {
            _paySpaceAssessmentApplicationReposatory.GetAllCalculatedTaxType.Select(s => new TaxCalculationViewModel
            {

                taxID = s.taxID,
                PostCode = s.PostCode,
                TaxTotal = s.TaxTotal,
                YearlySalary = s.YearlySalary,
                transcationDate = DateTime.Now
              });
            var model = PopulateTaxCalculationViewModel();
            return View("TaxPayersList", model);
        }

        public IQueryable<TaxCalculationViewModel> PopulateTaxCalculationViewModel()
        {
            var model = _paySpaceAssessmentApplicationReposatory.GetAllCalculatedTaxType.Select(s => new TaxCalculationViewModel
            {
               taxID = s.taxID,
               PostCode = s.PostCode,
               TaxTotal = s.TaxTotal,
               YearlySalary = s.YearlySalary,
               transcationDate = DateTime.Now
           });
             return model;
        }
    }
}