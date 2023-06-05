using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Service.ServiceImpl
{
    internal class OfficialRatesServiceImpl : IOfficialRatesService
    {
        SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public void AddNewDataInOfficialRateTable(object toSave)
        {
            OfficialRate officialRate = toSave as OfficialRate;

            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("OfficialRates_Insert", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("ValidityDate", officialRate.ValidityDate);
                sqlCommand.Parameters.AddWithValue("Currency", officialRate.Currency);
                sqlCommand.Parameters.AddWithValue("Rate", officialRate.Rate);
                sqlCommand.Parameters.AddWithValue("isActive", officialRate.isActive);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Data saved Successfull");
                con.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateDataInOfficialRatesTable(object toSave)
        {
            OfficialRate officialRate = toSave as OfficialRate;
            try
            {
                con.Open();

                SqlCommand sqlCommand = new SqlCommand("OfficialRates_Update", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("OfficialRatesId", officialRate.OfficialRatesId);
                sqlCommand.Parameters.AddWithValue("ValidityDate", officialRate.ValidityDate);
                sqlCommand.Parameters.AddWithValue("Currency", officialRate.Currency);
                sqlCommand.Parameters.AddWithValue("Rate", officialRate.Rate);
                sqlCommand.Parameters.AddWithValue("isActive", officialRate.isActive);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Data updated Successfull");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<OfficialRate> getAllData(string procedure)
        {
            using (var myDb = new Model1())
            {
                var officialRatesProperties = myDb.OfficialRates.Select(officialRate => new
                {
                    officialRate.OfficialRatesId,
                    officialRate.ValidityDate,
                    officialRate.Currency,
                    officialRate.Rate,
                    officialRate.isActive,
                }).ToList();

                List<OfficialRate> myOfficialRates = officialRatesProperties.Select(officialProp => new OfficialRate
                {
                    OfficialRatesId = officialProp.OfficialRatesId,
                    ValidityDate = officialProp.ValidityDate,
                    Currency = officialProp.Currency,
                    Rate = officialProp.Rate,
                    isActive = officialProp.isActive
                }).ToList();

                return myOfficialRates;
            }
        }

        public void GetAllOfficialRates(object sender, EventArgs e)
        {
            getAllData("OfficialRates_GetAll");
        }

        
    }
}
