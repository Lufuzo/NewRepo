using PaySpaceAssessmentApplication.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySpaceAssessmentApplication.Domain.Abstract
{
    public interface IPaySpaceAssessmentApplicationReposatory
    {
        bool SaveCalculatedTax(Tax_CalculationTable account);
        IQueryable<Tax_CalculationTable> GetAllCalculatedTaxType{ get; }

    }
}
