using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Service
{
    internal interface ITDAService
    {
        List<MonthlyResult> getAllData(decimal amount, int period, decimal interestRate);
    }
}
