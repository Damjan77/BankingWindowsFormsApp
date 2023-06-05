using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Service.ServiceImpl
{
    internal class OperationServiceImpl : IOperationService
    {
        SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public List<Operation> GetAllData(string procedure)
        {
            using (var myDb = new Model1())
            {
                var operationsProperties = myDb.Operations.Select(operation => new
                {
                    operation.OperationId,
                    operation.OperationTypeId,
                    operation.userId,
                    operation.OperationDate,
                    operation.Amount,
                    operation.CurrencyFrom,
                    operation.CurrencyTo,
                }).ToList();

                List<Operation> myOperations = operationsProperties.Select(operationProp => new Operation
                {
                    OperationId = operationProp.OperationId,
                    OperationTypeId = operationProp.OperationTypeId,
                    userId = operationProp.userId,
                    OperationDate = operationProp.OperationDate,
                    Amount = operationProp.Amount,
                    CurrencyFrom = operationProp.CurrencyFrom,
                    CurrencyTo = operationProp.CurrencyTo,
                }).ToList();

                return myOperations;
            }
        }

        public void AddNewDataInOperationsTable(object toSave)
        {
            Operation operation = toSave as Operation;

            try
            {
                con.Open();

                SqlCommand sqlCommand = new SqlCommand("Operations_Insert", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("OperationTypeId", operation.OperationTypeId);
                sqlCommand.Parameters.AddWithValue("UserId", operation.userId);
                sqlCommand.Parameters.AddWithValue("OperationDate", operation.OperationDate);
                sqlCommand.Parameters.AddWithValue("Amount", operation.Amount);
                sqlCommand.Parameters.AddWithValue("CurrencyFrom", operation.CurrencyFrom);
                sqlCommand.Parameters.AddWithValue("CurrencyTo", operation.CurrencyTo);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Data saved Successfull");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateDataInOperationsTable(object toSave)
        {
            Operation operation = toSave as Operation;

            try
            {
                con.Open();

                SqlCommand sqlCommand = new SqlCommand("Operations_Update", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("OperationId", operation.OperationId);
                sqlCommand.Parameters.AddWithValue("OperationTypeId", operation.OperationTypeId);
                sqlCommand.Parameters.AddWithValue("UserId", operation.userId);
                sqlCommand.Parameters.AddWithValue("OperationDate", operation.OperationDate);
                sqlCommand.Parameters.AddWithValue("Amount", operation.Amount);
                sqlCommand.Parameters.AddWithValue("CurrencyFrom", operation.CurrencyFrom);
                sqlCommand.Parameters.AddWithValue("CurrencyTo", operation.CurrencyTo);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Data updated Successfull");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
