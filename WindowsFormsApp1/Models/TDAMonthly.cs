using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class TDAMonthly
    {
        public string Year { get; set; }
        public string Month { get; set; }
        public int Days { get; set; }
        public decimal InterestPerMonth { get; set; }
        public decimal FullDeposit { get; set; }
    }
}
