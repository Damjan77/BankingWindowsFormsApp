using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class AnnuityResult
    {
        public int MonthlyNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal InitialDeposit { get; set; }
        public decimal InterestEarned { get; set; }

    }
}
