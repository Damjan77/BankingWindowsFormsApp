using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Service.ServiceImpl
{
    internal class TDAServiceImpl : ITDAService
    {
        public List<MonthlyResult> getAllData(decimal amount, int period, decimal interestRate)
        {
            using (var dbContext = new Model1()) // Replace with your actual DbContext instantiation
            {
                var results = dbContext.Database.SqlQuery<MonthlyResult>("EXEC CalculateTermDepositAmount @Amount, @Period, @InterestRate",
                    new SqlParameter("Amount", amount),
                    new SqlParameter("Period", period),
                    new SqlParameter("InterestRate", interestRate)
                ).ToList();

                return results;
            }
        }
    }
}
