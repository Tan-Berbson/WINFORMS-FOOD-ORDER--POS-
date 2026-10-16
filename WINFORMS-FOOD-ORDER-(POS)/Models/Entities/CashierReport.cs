using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WINFORMS_FOOD_ORDER__POS_.Models.Entities
{
    public class CashierReport : CashierAccounts
    {
        public string EvaluationRemarks { get; set; }
        public double TotalSells { get; set; }
    }
}
