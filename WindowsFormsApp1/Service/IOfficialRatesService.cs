using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Service
{
    public interface IOfficialRatesService
    {
        void AddNewDataInOfficialRateTable(object toSave);
        void UpdateDataInOfficialRatesTable(object toSave);
        List<OfficialRate> getAllData();
        void AddNBRMDataInDataBase();
    }
}
