using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PaySpaceAssessmentApplication.Domain.Abstract;
using PaySpaceAssessmentApplication.Domain.Model;
using Moq;
using PaySpaceAssessmentApplication.Domain.Concrete;
using System.Web.Mvc;
using PaySpaceAssessmentApplication.Tests.Model;
using PaySpaceAssessmentApplication.Controllers;
using System.Web.Routing;

namespace PaySpaceAssessmentApplication.Tests.Controllers
{

    [TestClass]
    public class TaxPayerController
    {
        private PaySpaceAssessmentApplicationReposatory _paySpaceAssessmentApplicationReposatory;

        public TaxPayerController()
        {
            _paySpaceAssessmentApplicationReposatory = new PaySpaceAssessmentApplicationReposatory();
        }

        private static TaxPayerController GeTaxPayerController(IPaySpaceAssessmentApplicationReposatory taxrepository)
        {
            TaxPayerController taxcontroller = new TaxPayerController();

            return taxcontroller;
        }


        [TestMethod]
        public void Create_PostTaxpayeInRepository()
        {
            Tax_CalculationTable taxPayer = new Tax_CalculationTable();
            TaxPayer taxpayer = new Model.TaxPayer();
            taxpayer.taxID = 1;
            taxpayer.PostCode = "A100";
            taxpayer.YearlySalary = "82251";
            taxpayer.transcationDate = DateTime.Now;

            taxPayer.taxID = taxpayer.taxID;
            taxPayer.PostCode = taxpayer.PostCode;
            taxPayer.YearlySalary = taxpayer.YearlySalary;
            taxPayer.transcationDate = taxpayer.transcationDate;

            _paySpaceAssessmentApplicationReposatory.SaveCalculatedTax(taxPayer);


        }


    }
}
