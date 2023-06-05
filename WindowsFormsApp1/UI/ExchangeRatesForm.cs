﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;

namespace WindowsFormsApp1.UI
{
    public partial class ExchangeRatesForm : Form
    {
        SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        IExchangeRatesService exchangeRates;
        ICLS_CurrencyService cls_CurrencyService;

        public ExchangeRatesForm()
        {
            InitializeComponent();
            exchangeRates = new ExchangeRatesServiceImpl();
            cls_CurrencyService = new CLSCurrencyServiceImpl();
        }

        private void ExchangeRatesForm_Load(object sender, EventArgs e)
        {
            CurrencyFromComboBox.DataSource = cls_CurrencyService.getAllData();
            CurrencyFromComboBox.ValueMember = "Code";
            CurrencyFromComboBox.DisplayMember = "Code";
            CurrencyFromComboBox.SelectedItem = null;

            CurrencyToComboBox.DataSource = cls_CurrencyService.getAllData();
            CurrencyToComboBox.ValueMember = "Code";
            CurrencyFromComboBox.DisplayMember = "Code";
            CurrencyToComboBox.SelectedItem = null;

            getAllData();

        }

        private void getAllData()
        {
            ExchangeRatesDataGridView.DataSource = exchangeRates.getAllData();
        }

        //private void GetAllExchangeRates(object sender, EventArgs e)
        //{
        //    getAllData("ExchangeRates_GetAll", ExchangeRatesDataGridView);
        //}

        //private void getAllData(string procedure, DataGridView dataGridView)
        //{
        //    using(var myDb = new Model1())
        //    {
        //        var myExchangeRates = myDb.ExchangeRates.ToList();
        //        dataGridView.DataSource = myExchangeRates;
        //    }
        //}

        private void clearAllData()
        {
            ExchangeRatesdateTimePicker.Value = DateTime.Now;
            CurrencyFromComboBox.SelectedText = null;
            CurrencyToComboBox.SelectedText = null;
            RateTextBox2.Text = "";
            ActivateUserCheckBox3.Checked = false;
        }

        public void DRYExchengeRate(object sender, EventArgs e, bool isExist)
        {
            ExchangeRate exchangeRate = new ExchangeRate();

            if (isExist)
            {
                var selected = ExchangeRatesDataGridView.SelectedRows[0];

                exchangeRate.exchangeRatesId = Convert.ToInt32(selected.Cells["ExchangeRatesId"].Value);
                exchangeRate.ValidityDate = ExchangeRatesdateTimePicker.Value;
                exchangeRate.CurrencyFrom = CurrencyFromComboBox.Text.ToString();
                exchangeRate.CurrencyTo = CurrencyToComboBox.Text.ToString();
                exchangeRate.Rate = Decimal.Parse(RateTextBox2.Text.ToString());
                exchangeRate.IsActive = ActivateUserCheckBox3.Checked;
                
                exchangeRates.UpdateDataInExchangeRatesTable(exchangeRate);//PROVERI ZA NAME'
                getAllData();
                //UpdateDataInExchangeRatesTable(exchangeRate);
            }
            else
            {
                exchangeRate.ValidityDate = ExchangeRatesdateTimePicker.Value;
                exchangeRate.CurrencyFrom = CurrencyFromComboBox.Text.ToString();
                exchangeRate.CurrencyTo = CurrencyToComboBox.Text.ToString();
                exchangeRate.Rate = Decimal.Parse(RateTextBox2.Text.ToString());
                exchangeRate.IsActive = ActivateUserCheckBox3.Checked;

                exchangeRates.AddNewDataInExchangeRateTable(exchangeRate);//PROVERI ZA NAME'
                getAllData();
                //AddNewDataInExchangeRateTable(exchangeRate);
            }
            clearAllData();
            //GetAllExchangeRates(sender, e);
        }
        //private void UpdateDataInExchangeRatesTable(object toSave) //Update ExchangeRates
        //{
        //    ExchangeRate exchangeRate = toSave as ExchangeRate;

        //    try
        //    {
        //        con.Open();

        //        SqlCommand sqlCommand = new SqlCommand("ExchangeRates_Update", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("ExchangeRatesId", exchangeRate.exchangeRatesId);
        //        sqlCommand.Parameters.AddWithValue("ValidityDate", exchangeRate.ValidityDate);
        //        sqlCommand.Parameters.AddWithValue("CurrencyFrom", exchangeRate.CurrencyFrom);
        //        sqlCommand.Parameters.AddWithValue("CurrencyTo", exchangeRate.CurrencyTo);
        //        sqlCommand.Parameters.AddWithValue("Rate", exchangeRate.Rate);
        //        sqlCommand.Parameters.AddWithValue("IsActive", exchangeRate.IsActive);
        //        sqlCommand.ExecuteNonQuery();

        //        MessageBox.Show("Data updated Successfull");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //private void AddNewDataInExchangeRateTable(object toSave) //Add ExchangeRate
        //{
        //    ExchangeRate exchangeRate = toSave as ExchangeRate;

        //    try
        //    {
        //        con.Open();

        //        SqlCommand sqlCommand = new SqlCommand("ExchangeRates_Insert", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("ValidityDate", exchangeRate.ValidityDate);
        //        sqlCommand.Parameters.AddWithValue("CurrencyFrom", exchangeRate.CurrencyFrom);
        //        sqlCommand.Parameters.AddWithValue("CurrencyTo", exchangeRate.CurrencyTo);
        //        sqlCommand.Parameters.AddWithValue("Rate", exchangeRate.Rate);
        //        sqlCommand.Parameters.AddWithValue("IsActive", exchangeRate.IsActive);
        //        sqlCommand.ExecuteNonQuery();

        //        MessageBox.Show("Data saved Successfull");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        private void AddNewExchangeRateButton_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                DRYExchengeRate(sender, e, false);
            }
        }

        private void SaveExchangeRatesButton_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                DRYExchengeRate(sender, e, true);
            }
        }

        private void ExchangeRatesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExchangeRatesdateTimePicker.Text = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            CurrencyFromComboBox.Text = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            CurrencyToComboBox.Text = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            RateTextBox2.Text = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            ActivateUserCheckBox3.Checked = (bool)ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[5].Value;
        }

        private bool isDataValid()
        {
            //currencyFrom Logic
            bool currencyFromFlag = true;

            if (CurrencyFromComboBox.SelectedItem == null)
            {
                ExchangeRatesCurrencyFromErrorProvider.SetError(CurrencyFromComboBox, "Please select currency!");
                currencyFromFlag = false;
            }
            if (currencyFromFlag)
            {
                ExchangeRatesCurrencyFromErrorProvider.SetError(CurrencyFromComboBox, string.Empty);
                ExchangeRatesCurrencyFromErrorProvider.Clear();
            }

            //currencyTo Logic
            bool currencyToFlag = true;

            if (CurrencyToComboBox.SelectedItem == null)
            {
                ExchangeRatesCurrencyToErrorProvider.SetError(CurrencyToComboBox, "Please select currency!");
                currencyToFlag = false;
            }
            if (currencyToFlag)
            {
                ExchangeRatesCurrencyToErrorProvider.SetError(CurrencyToComboBox, string.Empty);
                ExchangeRatesCurrencyToErrorProvider.Clear();
            }

            //Rate Logic
            bool rateFlag = true;
            if (string.IsNullOrEmpty(RateTextBox2.Text.Trim()))
            {
                ExchangeRatesRateErrorProvider.SetError(RateTextBox2, "Rate is required!");
                rateFlag = false;
            }
            else if (!Regex.IsMatch(RateTextBox2.Text, "^[0-9.]+$")) //Only digits
            {
                ExchangeRatesRateErrorProvider.SetError(RateTextBox2, "Rate must contains only numbers!");
                rateFlag = false;
            }
            if (rateFlag)
            {
                ExchangeRatesRateErrorProvider.SetError(RateTextBox2, string.Empty);
                ExchangeRatesRateErrorProvider.Clear();
            }

            if (currencyFromFlag && currencyToFlag && rateFlag) return true;
            else return false;
        }
    }
}