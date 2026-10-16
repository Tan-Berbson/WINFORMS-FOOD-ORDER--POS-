using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WINFORMS_FOOD_ORDER__POS_.Models.Entities
{
    public abstract class AdminAccounts
    {
        public int AdminId { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }
    }
}
