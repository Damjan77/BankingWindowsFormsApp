using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.NBRMServiceReference;

namespace WindowsFormsApp1.Service.ServiceImpl
{
    internal class ExchangeRatesServiceImpl : IExchangeRatesService
    {
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
                using (var myDb = new Model1()) 
                {
                    ExchangeRate newExchangeRate = new ExchangeRate
                    {
                        ValidityDate = exchangeRate.ValidityDate,
                        CurrencyFrom = exchangeRate.CurrencyFrom,
                        CurrencyTo = exchangeRate.CurrencyTo,
                        Rate = exchangeRate.Rate,
                        IsActive = exchangeRate.IsActive
                    };

                    if (newExchangeRate.IsActive)
                    {
                        var duplicateRates = myDb.ExchangeRates.Where(rate => rate.CurrencyFrom == newExchangeRate.CurrencyFrom && rate.CurrencyTo == newExchangeRate.CurrencyTo).ToList();
                        duplicateRates.ForEach(rate => rate.IsActive = false);
                    }

                    // Add
                    myDb.ExchangeRates.Add(newExchangeRate);

                    // Save changes
                    myDb.SaveChanges();
                }

                MessageBox.Show("Data saved successfully");
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                MessageBox.Show("Data saved unsuccessfully " + ex.Message);
            }
        }

        public void UpdateDataInExchangeRatesTable(object toSave)
        {
            ExchangeRate exchangeRate = toSave as ExchangeRate;

            try
            {
                using (var myDb = new Model1()) 
                {
                    ExchangeRate existingExchangeRate = myDb.ExchangeRates.Find(exchangeRate.exchangeRatesId);

                    if (existingExchangeRate != null)
                    {
                        // Update 
                        existingExchangeRate.ValidityDate = exchangeRate.ValidityDate;
                        existingExchangeRate.CurrencyFrom = exchangeRate.CurrencyFrom;
                        existingExchangeRate.CurrencyTo = exchangeRate.CurrencyTo;
                        existingExchangeRate.Rate = exchangeRate.Rate;
                        existingExchangeRate.IsActive = exchangeRate.IsActive;

                        if(existingExchangeRate.IsActive)
                        {
                            var duplicateRates = myDb.ExchangeRates.Where(rate => rate.CurrencyFrom == existingExchangeRate.CurrencyFrom && rate.CurrencyTo == existingExchangeRate.CurrencyTo).ToList();
                            if (duplicateRates.Count > 1)
                            {
                                duplicateRates.ForEach(rate => rate.IsActive = false);
                            }
                        }
                        
                        // Save changes
                        myDb.SaveChanges();

                        MessageBox.Show("Data updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Exchange rate not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data updated unsuccessfully " + ex.Message);
            }

        }

        public void AddNBRMDataInDataBase()
        {
            var service = new KursSoapClient();
            string xmlResponse = service.GetExchangeRates(DateTime.Now.ToString("dd.MM.yyyy"), DateTime.Now.AddDays(1).ToString("dd.MM.yyyy")); //Test global exception

            using (var myDb = new Model1())
            {
                using (var reader = new System.IO.StringReader(xmlResponse))
                {
                    var dataSet = new System.Data.DataSet();
                    dataSet.ReadXml(reader);

                    myDb.ExchangeRates.ToList().ForEach(rate => rate.IsActive = false);

                    foreach (System.Data.DataRow row in dataSet.Tables[0].Rows)
                    {
                        DateTime validityDate = Convert.ToDateTime(row["Datum"]);
                        string currencyFrom = row["Oznaka"].ToString();
                        string currencyTo = row["Oznaka"].ToString();
                        decimal kupovenRate = Convert.ToDecimal(row["Kupoven"]);
                        decimal prodazenRate = Convert.ToDecimal(row["Prodazen"]);
                        bool isActive = true;
                        string environmentCurrency = Environment.GetEnvironmentVariable("CurrencyMKD");

                        var exchangeRate = new ExchangeRate //EUR -> MKD
                        {
                            ValidityDate = validityDate,
                            CurrencyFrom = currencyFrom,
                            CurrencyTo = environmentCurrency,
                            Rate = prodazenRate,
                            IsActive = isActive
                        };

                        var exchangeRate2 = new ExchangeRate //MKD -> EUR
                        {
                            ValidityDate = validityDate,
                            CurrencyFrom = environmentCurrency,
                            CurrencyTo = currencyTo,
                            Rate = kupovenRate,
                            IsActive = isActive
                        };

                        myDb.ExchangeRates.Add(exchangeRate);
                        myDb.ExchangeRates.Add(exchangeRate2);
                    }

                    myDb.SaveChanges();
                }
            }
            MessageBox.Show("Latest ExchangeRates downloaded!");
        }
    }
    
}
