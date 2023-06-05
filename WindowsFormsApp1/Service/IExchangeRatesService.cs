using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Service
{
    internal interface IExchangeRatesService
    {
        void AddNewDataInExchangeRateTable(object toSave);
        void UpdateDataInExchangeRatesTable(object toSave);
        List<ExchangeRate> getAllData();
    }
}
