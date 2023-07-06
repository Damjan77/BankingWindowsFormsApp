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

        public List<CLS_Currency> getAllActiveData()
        {
            using (var myDb = new Model1())
            {
                var cls_CurrencyProperties = myDb.CLS_Currency.Where(currency => currency.IsActive).Select(currency => new
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
                using (var myDb = new Model1())
                {
                    CLS_Currency newCurrency = new CLS_Currency
                    {
                        Code = cls_Currency.Code,
                        Name = cls_Currency.Name,
                        IsActive = cls_Currency.IsActive
                    };

                    // Add the new CLS_Currency entity to the DbContext
                    myDb.CLS_Currency.Add(newCurrency);

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

        public void UpdateDataInExchangeRatesTable(object toSave)
        {
            CLS_Currency cls_Currency = toSave as CLS_Currency;

            try
            {
                using (var myDb = new Model1())
                {
                    CLS_Currency existingCurrency = myDb.CLS_Currency.Find(cls_Currency.CurrencyId);

                    if (existingCurrency != null)
                    {
                        // Update
                        existingCurrency.Code = cls_Currency.Code;
                        existingCurrency.Name = cls_Currency.Name;
                        existingCurrency.IsActive = cls_Currency.IsActive;

                        // Save changes
                        myDb.SaveChanges();

                        MessageBox.Show("Data updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Currency not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data saved unsuccessfully " + ex.Message);
            }
        }

    }
}
