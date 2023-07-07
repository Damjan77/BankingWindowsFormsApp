using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace WindowsFormsApp1.Service.ServiceImpl
{
    internal class CLS_OperationTypeServiceImpl : ICLS_OperationTypeService
    {
        public List<CLS_OperationType> getAllData(string procedure)
        {
            using (var myDb = new Model1())
            {
                var cls_OperationTypeProperties = myDb.CLS_OperationType.Select(operationType => new
                {
                    operationType.OperationTypeId,
                    operationType.Code,
                    operationType.Name,
                    operationType.IsActive,
                }).ToList();

                List<CLS_OperationType> myCLSOperationType = cls_OperationTypeProperties.Select(operationTypeProp => new CLS_OperationType
                {
                    OperationTypeId = operationTypeProp.OperationTypeId,
                    Code = operationTypeProp.Code,
                    Name = operationTypeProp.Name,
                    IsActive = operationTypeProp.IsActive
                }).ToList();

                return myCLSOperationType;
            }
        }

        public void AddNewDataInExchangeRateTable(object toSave)
        {
            CLS_OperationType cls_OperationType = toSave as CLS_OperationType;

            try
            {
                using (var myDb = new Model1())
                {
                    CLS_OperationType newOperationType = new CLS_OperationType
                    {
                        Code = cls_OperationType.Code,
                        Name = cls_OperationType.Name,
                        IsActive = cls_OperationType.IsActive
                    };

                    // Add 
                    myDb.CLS_OperationType.Add(newOperationType);

                    // Save changes
                    myDb.SaveChanges();
                }

                MessageBox.Show("Data saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data saved unsuccessfully " + ex.Message);
            }
        }

        public void UpdateDataInExchangeRatesTable(object toSave)
        {
            CLS_OperationType cls_OperationType = toSave as CLS_OperationType;

            try
            {
                using (var myDb = new Model1())
                {
                    CLS_OperationType existingOperationType = myDb.CLS_OperationType.Find(cls_OperationType.OperationTypeId);

                    if (existingOperationType != null)
                    {
                        // Update
                        existingOperationType.Code = cls_OperationType.Code;
                        existingOperationType.Name = cls_OperationType.Name;
                        existingOperationType.IsActive = cls_OperationType.IsActive;

                        // Save changes
                        myDb.SaveChanges();

                        MessageBox.Show("Data updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Operation type not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data updated unsuccessfully " + ex.Message);
            }
        }

        public string GetOperationTypeById(int? id)
        {
            using (var db = new Model1())
            {
                string sql = "EXEC CLS_OperationType_GetById @Id";

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                return db.Database.SqlQuery<CLS_OperationType>(sql, parameters).First().Code;
            }
        }

        public int? getOperationTypeId(string code)
        {
            using (var myDb = new Model1())
            {
                CLS_OperationType operationType = myDb.CLS_OperationType.FirstOrDefault(opType => opType.Code == code);
                return operationType.OperationTypeId;
            }
             
        }
    }
}
