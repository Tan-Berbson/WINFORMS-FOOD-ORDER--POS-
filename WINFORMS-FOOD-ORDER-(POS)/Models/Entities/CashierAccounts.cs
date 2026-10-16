using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WINFORMS_FOOD_ORDER__POS_.Models.Entities
{
    public abstract class CashierAccounts : AdminAccounts
    {
        public int CashierId { get; set; }
        public string CashierUserName { get; set; }
        public string CashierPassword { get; set; }
    }
}
