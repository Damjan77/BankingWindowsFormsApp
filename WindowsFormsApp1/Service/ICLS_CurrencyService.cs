using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1.Service
{
    public interface ICLS_CurrencyService
    {
        void AddNewDataInExchangeRateTable(object toSave);
        void UpdateDataInExchangeRatesTable(object toSave);
        List<CLS_Currency> getAllData();
    }
}
