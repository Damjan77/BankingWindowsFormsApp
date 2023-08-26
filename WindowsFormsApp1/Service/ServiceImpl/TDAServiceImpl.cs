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
        public List<MonthlyResult> getAllTDAData(decimal amount, int period, decimal interestRate) //TODO List<MonthlyResult> -> MonthlyResult
        {
            using (var dbContext = new Model1()) 
            {
                var results = dbContext.Database.SqlQuery<MonthlyResult>("EXEC CalculateTermDepositAmount @Amount, @Period, @InterestRate",
                    new SqlParameter("Amount", amount),
                    new SqlParameter("Period", period),
                    new SqlParameter("InterestRate", interestRate)
                ).ToList();

                return results;
            }
        }
 
        public List<AnnuityResult> getAllAnnuityData(decimal Amount, int num_months, decimal Interest)
        {
            using (var dbContext = new Model1()) 
            {
                var results = dbContext.Database.SqlQuery<AnnuityResult>("EXEC SavingsDeposit @Amount, @Interest, @num_months",
                    new SqlParameter("Amount", Amount),
                    new SqlParameter("Interest", Interest),
                    new SqlParameter("num_months", num_months)
                ).ToList();

                return results;
            }
        }
    }
}
