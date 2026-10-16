using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WINFORMS_FOOD_ORDER__POS_.Models.Entities
{
    public class Products : CashierAccounts
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }
}
