using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Service
{
    internal interface IOfficialRatesService
    {
        void AddNewDataInOfficialRateTable(object toSave);
        void UpdateDataInOfficialRatesTable(object toSave);
        List<OfficialRate> getAllData(string procedure);
        void GetAllOfficialRates(object sender, EventArgs e);
        
    }
}
