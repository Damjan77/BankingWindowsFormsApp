using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Service
{
    public interface IExchangeRatesService
    {
        void AddNewDataInExchangeRateTable(object toSave);
        void UpdateDataInExchangeRatesTable(object toSave);
        List<ExchangeRate> getAllData();
        void AddNBRMDataInDataBase();
        List<ExchangeRate> SearchExchangeRates(string CurrencyFromText, string CurrencyToText);
    }
}
