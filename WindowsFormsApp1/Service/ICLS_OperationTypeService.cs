using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Service
{
    public interface ICLS_OperationTypeService
    {
        void AddNewDataInExchangeRateTable(object toSave);
        void UpdateDataInExchangeRatesTable(object toSave);
        List<CLS_OperationType> getAllData(string procedure);
        string GetOperationTypeById(int? id);
        int? getOperationTypeId(string code);
    }
}
