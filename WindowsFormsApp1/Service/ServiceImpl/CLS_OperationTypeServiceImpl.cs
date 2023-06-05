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
        SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"); 
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
                con.Open();

                SqlCommand sqlCommand = new SqlCommand("CLS_OperationType_Insert", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("Code", cls_OperationType.Code);
                sqlCommand.Parameters.AddWithValue("Name", cls_OperationType.Name);
                sqlCommand.Parameters.AddWithValue("IsActive", cls_OperationType.IsActive);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Data saved Successfull");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateDataInExchangeRatesTable(object toSave)
        {
            CLS_OperationType cls_OperationType = toSave as CLS_OperationType;

            try
            {
                con.Open();

                SqlCommand sqlCommand = new SqlCommand("CLS_OperationType_Update", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("OperationTypeId", cls_OperationType.OperationTypeId);
                sqlCommand.Parameters.AddWithValue("Code", cls_OperationType.Code);
                sqlCommand.Parameters.AddWithValue("Name", cls_OperationType.Name);
                sqlCommand.Parameters.AddWithValue("IsActive", cls_OperationType.IsActive);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Data saved Successfull");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
    }
}
