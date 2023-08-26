using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class AnnuityResult
    {
        public string year { get; set; }
        public string month { get; set; }
        public int days { get; set; }
        public decimal interestPerMonth { get; set; }
    }
}
