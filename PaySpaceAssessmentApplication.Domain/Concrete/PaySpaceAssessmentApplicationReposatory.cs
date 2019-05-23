using PaySpaceAssessmentApplication.Domain.Abstract;
using PaySpaceAssessmentApplication.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySpaceAssessmentApplication.Domain.Concrete
{
    public class PaySpaceAssessmentApplicationReposatory : IPaySpaceAssessmentApplicationReposatory
    {
        private PaySpaceTaxCalculationEntities1 _dbContext;

        public PaySpaceAssessmentApplicationReposatory()
        {

            _dbContext = new PaySpaceTaxCalculationEntities1();
        }
        public bool SaveCalculatedTax(Tax_CalculationTable tax_CalculationTable)
        {
            try
            {
                if (tax_CalculationTable.taxID == 0)
                {
                    _dbContext.Tax_CalculationTable.Add(tax_CalculationTable);
                }
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public IQueryable<Tax_CalculationTable> GetAllCalculatedTaxType
        {
            get { return _dbContext.Tax_CalculationTable; }
        }




    }
}
