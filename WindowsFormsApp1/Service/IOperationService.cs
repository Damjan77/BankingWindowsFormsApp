using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Service
{
    public interface IOperationService
    {
        void AddNewDataInOperationsTable(object toSave);
        void UpdateDataInOperationsTable(object toSave);
        List<Operation> GetAllData(string procedure);
        decimal transferMoney(decimal amount, decimal rate);
        decimal SearchRateFromExchangeRates(string currencyFrom, string currencyTo);
    }
}
