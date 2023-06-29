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
                    operation.t_money
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
                    t_money = operationProp.t_money
                }).ToList();

                return myOperations;
            }
        }

        public void AddNewDataInOperationsTable(object toSave)
        {
            Operation operation = toSave as Operation;

            try
            {
                using (var myDb = new Model1())
                {
                    Operation newOperation = new Operation
                    {
                        OperationTypeId = operation.OperationTypeId,
                        userId = operation.userId,
                        OperationDate = operation.OperationDate,
                        Amount = operation.Amount,
                        CurrencyFrom = operation.CurrencyFrom,
                        CurrencyTo = operation.CurrencyTo,
                        t_money = operation.t_money
                    };

                    // Add the new Operation
                    myDb.Operations.Add(newOperation);

                    // Save changes to the database
                    myDb.SaveChanges();
                }

                MessageBox.Show("Data saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data saved unsuccessfully " + ex.Message);
            }
        }

        public void UpdateDataInOperationsTable(object toSave)
        {
            Operation operation = toSave as Operation;

            try
            {
                using (var myDb = new Model1())
                {
                    Operation existingOperation = myDb.Operations.Find(operation.OperationId);

                    if (existingOperation != null)
                    {
                        // Update
                        existingOperation.OperationTypeId = operation.OperationTypeId;
                        existingOperation.userId = operation.userId;
                        existingOperation.OperationDate = operation.OperationDate;
                        existingOperation.Amount = operation.Amount;
                        existingOperation.CurrencyFrom = operation.CurrencyFrom;
                        existingOperation.CurrencyTo = operation.CurrencyTo;

                        // Save changes
                        myDb.SaveChanges();

                        MessageBox.Show("Data updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Operation not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data updated unsuccessfully " + ex.Message);
            }
        }

        public decimal transferMoney(decimal amount, decimal rate)
        {
            return amount * rate;
        }

        public decimal SearchRateFromExchangeRates(string currencyFrom, string currencyTo)
        {
            using (var myDb = new Model1())
            {
                var query = myDb.ExchangeRates
                    .FirstOrDefault(exchangeRate => exchangeRate.CurrencyFrom == currencyFrom &&
                                            exchangeRate.CurrencyTo == currencyTo &&
                                            exchangeRate.IsActive);

                //Handle Null exception
                if (query == null) return 0.0m;

                return query.Rate;
            }
        }

        //public decimal SearchRateFromExchangeRates(string currencyFrom, string currencyTo) //MKD -> EUR
        //{
        //    using (var myDb = new Model1())
        //    {
        //        var query = myDb.ExchangeRates
        //            .FirstOrDefault(exchangeRate => exchangeRate.CurrencyFrom == currencyFrom &&
        //                                    exchangeRate.CurrencyTo == currencyTo &&
        //                                    exchangeRate.IsActive);

        //        //Handle Null exception
        //        if (query == null) //Ne e pronajden zapis
        //        {
        //            query = myDb.ExchangeRates
        //                .FirstOrDefault(exchangeRate => exchangeRate.CurrencyFrom == currencyTo &&
        //                                    exchangeRate.CurrencyTo == currencyFrom &&
        //                                    exchangeRate.IsActive); //Da bara zapis obratno od dadenoto : dadeno:MKD -> EUR najdi:EUR->MKD
        //            if (query != null)
        //            {
        //                return 1/query.Rate; //Vrati go prodazniot Rate
        //            }
        //            else
        //            {
        //                return 0.0m;
        //            }
        //        }
        //        else //Pronajden e ExchangeRate so soodvetni CurrencyFrom -> CurrencyTo
        //        {
        //            return query.Rate; //Vrati go kupovniot Rate
        //        }
        //    }
        //}


    }
}
