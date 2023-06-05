using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Service.ServiceImpl
{
    internal class ExchangeRatesServiceImpl : IExchangeRatesService
    {
        SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public List<ExchangeRate> getAllData()
        {
            using (var myDb = new Model1())
            {
                var exchangeRatesProperties = myDb.ExchangeRates.Select(exchangeRate => new
                {
                    exchangeRate.exchangeRatesId,
                    exchangeRate.ValidityDate,
                    exchangeRate.CurrencyFrom,
                    exchangeRate.CurrencyTo,
                    exchangeRate.Rate,
                    exchangeRate.IsActive,
                }).ToList();

                List<ExchangeRate> myExchangelRates = exchangeRatesProperties.Select(exchangeProp => new ExchangeRate
                {
                    exchangeRatesId = exchangeProp.exchangeRatesId,
                    ValidityDate = exchangeProp.ValidityDate,
                    CurrencyFrom = exchangeProp.CurrencyFrom,
                    CurrencyTo = exchangeProp.CurrencyTo,
                    Rate = exchangeProp.Rate,
                    IsActive = exchangeProp.IsActive
                }).ToList();

                return myExchangelRates;
            }
        }

        

        public void AddNewDataInExchangeRateTable(object toSave)
        {
            ExchangeRate exchangeRate = toSave as ExchangeRate;

            try
            {
                con.Open();

                SqlCommand sqlCommand = new SqlCommand("ExchangeRates_Insert", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("ValidityDate", exchangeRate.ValidityDate);
                sqlCommand.Parameters.AddWithValue("CurrencyFrom", exchangeRate.CurrencyFrom);
                sqlCommand.Parameters.AddWithValue("CurrencyTo", exchangeRate.CurrencyTo);
                sqlCommand.Parameters.AddWithValue("Rate", exchangeRate.Rate);
                sqlCommand.Parameters.AddWithValue("IsActive", exchangeRate.IsActive);
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
            ExchangeRate exchangeRate = toSave as ExchangeRate;

            try
            {
                con.Open();

                SqlCommand sqlCommand = new SqlCommand("ExchangeRates_Update", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("ExchangeRatesId", exchangeRate.exchangeRatesId);
                sqlCommand.Parameters.AddWithValue("ValidityDate", exchangeRate.ValidityDate);
                sqlCommand.Parameters.AddWithValue("CurrencyFrom", exchangeRate.CurrencyFrom);
                sqlCommand.Parameters.AddWithValue("CurrencyTo", exchangeRate.CurrencyTo);
                sqlCommand.Parameters.AddWithValue("Rate", exchangeRate.Rate);
                sqlCommand.Parameters.AddWithValue("IsActive", exchangeRate.IsActive);
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
