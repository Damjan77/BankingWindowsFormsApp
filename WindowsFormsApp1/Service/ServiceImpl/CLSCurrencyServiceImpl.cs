using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Service.ServiceImpl
{
    internal class CLSCurrencyServiceImpl : ICLS_CurrencyService
    {
        SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public List<CLS_Currency> getAllData()
        {
            using (var myDb = new Model1())
            {
                var cls_CurrencyProperties = myDb.CLS_Currency.Select(currency => new
                {
                    currency.CurrencyId,
                    currency.Code,
                    currency.Name,
                    currency.IsActive,
                }).ToList();

                List<CLS_Currency> myCLSCurrency = cls_CurrencyProperties.Select(currencyProp => new CLS_Currency
                {
                    CurrencyId = currencyProp.CurrencyId,
                    Code = currencyProp.Code,
                    Name = currencyProp.Name,
                    IsActive = currencyProp.IsActive
                }).ToList();

                return myCLSCurrency;
            }
        }

        public void AddNewDataInExchangeRateTable(object toSave)
        {
            CLS_Currency cls_Currency = toSave as CLS_Currency;

            try
            {
                con.Open();

                SqlCommand sqlCommand = new SqlCommand("CLS_Currency_INSERT", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("Code", cls_Currency.Code);
                sqlCommand.Parameters.AddWithValue("Name", cls_Currency.Name);
                sqlCommand.Parameters.AddWithValue("IsActive", cls_Currency.IsActive);
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
            CLS_Currency cls_Currency = toSave as CLS_Currency;

            try
            {
                con.Open();

                SqlCommand sqlCommand = new SqlCommand("CLS_Currency_Update", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("CurrencyId", cls_Currency.CurrencyId);
                sqlCommand.Parameters.AddWithValue("Code", cls_Currency.Code);
                sqlCommand.Parameters.AddWithValue("Name", cls_Currency.Name);
                sqlCommand.Parameters.AddWithValue("IsActive", cls_Currency.IsActive);
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
