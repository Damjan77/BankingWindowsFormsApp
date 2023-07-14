using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;
using WindowsFormsApp1.NBRMServiceReference;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.UI
{
    public partial class ExchangeRatesForm : Form
    {
        IExchangeRatesService exchangeRates;
        ICLS_CurrencyService cls_CurrencyService;

        public ExchangeRatesForm(IExchangeRatesService exchangeRates, ICLS_CurrencyService cls_CurrencyService)
        {
            InitializeComponent();
            this.exchangeRates = exchangeRates;
            this.cls_CurrencyService = cls_CurrencyService;
        }

        public ExchangeRatesForm() : this(new ExchangeRatesServiceImpl(), new CLSCurrencyServiceImpl()) { }

        private void ExchangeRatesForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            CurrencyFromComboBox.DataSource = cls_CurrencyService.getAllActiveData();
            CurrencyFromComboBox.ValueMember = "Code";
            CurrencyFromComboBox.DisplayMember = "Code";
            CurrencyFromComboBox.SelectedItem = null;

            CurrencyToComboBox.DataSource = cls_CurrencyService.getAllActiveData();
            CurrencyToComboBox.ValueMember = "Code";
            CurrencyFromComboBox.DisplayMember = "Code";
            CurrencyToComboBox.SelectedItem = null;

            getAllData();
        }

        private void getAllData()
        {
            ExchangeRatesDataGridView.DataSource = exchangeRates.getAllData();
        } 

        private void clearAllData()
        {
            ExchangeRatesdateTimePicker.Value = DateTime.Now;
            CurrencyFromComboBox.SelectedText = null;
            CurrencyFromComboBox.Text = "";
            CurrencyToComboBox.SelectedText = null;
            CurrencyToComboBox.Text = "";
            RateTextBox2.Text = "";
            ActivateUserCheckBox3.Checked = false;
        }

        public void DRYExchengeRate(object sender, EventArgs e, bool isExist)
        {
            ExchangeRate exchangeRate = new ExchangeRate();

            CLS_Currency currencyFromObj = CurrencyFromComboBox.SelectedItem as CLS_Currency;
            CLS_Currency currencyToObj = CurrencyToComboBox.SelectedItem as CLS_Currency;

            if (currencyFromObj.Code == currencyToObj.Code)
            {
                MessageBox.Show("CurrencyFrom and CurrencyTo cannot be the same!");
                return;
            }

            if (isExist)
            {
                var selected = ExchangeRatesDataGridView.SelectedRows[0];

                exchangeRate.exchangeRatesId = Convert.ToInt32(selected.Cells["ExchangeRatesId"].Value);
                exchangeRate.ValidityDate = DateTime.Now;
                exchangeRate.CurrencyFrom = CurrencyFromComboBox.Text.ToString();
                exchangeRate.CurrencyTo = CurrencyToComboBox.Text.ToString();
                exchangeRate.Rate = Decimal.Parse(RateTextBox2.Text.ToString());
                exchangeRate.IsActive = ActivateUserCheckBox3.Checked;
                
                exchangeRates.UpdateDataInExchangeRatesTable(exchangeRate);
            }
            else
            {
                exchangeRate.ValidityDate = DateTime.Now;
                exchangeRate.CurrencyFrom = CurrencyFromComboBox.Text.ToString();
                exchangeRate.CurrencyTo = CurrencyToComboBox.Text.ToString();
                exchangeRate.Rate = Decimal.Parse(RateTextBox2.Text.ToString());
                exchangeRate.IsActive = ActivateUserCheckBox3.Checked;

                exchangeRates.AddNewDataInExchangeRateTable(exchangeRate);
            }

            getAllData();
            clearAllData();
        }   

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
            if (e.RowIndex != -1)
            {
                ExchangeRatesdateTimePicker.Text = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                CurrencyFromComboBox.Text = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                CurrencyFromComboBox.SelectedItem = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                CurrencyToComboBox.Text = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                CurrencyToComboBox.SelectedItem = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                RateTextBox2.Text = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                ActivateUserCheckBox3.Checked = (bool)ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[5].Value;
            }
        }

        private bool isDataValid()
        {
            //currencyFrom Logic
            bool currencyFromFlag = true;

            if (CurrencyFromComboBox.Text == "")
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

            if (CurrencyToComboBox.Text == "")
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
            else if (!(Regex.IsMatch(RateTextBox2.Text, "^[0-9]+(?:\\.?)+[0-9]+$")) && !(Regex.IsMatch(RateTextBox2.Text, "^[0-9]+$")))
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

        private void WebServiceButton_Click(object sender, EventArgs e)
        {
            var service = new KursSoapClient();
            string xmlResponse = service.GetExchangeRates(DateTime.Now.ToString("dd.MM.yyyy"), DateTime.Now.AddDays(1).ToString("dd.MM.yyyy"));
            var dataSet = new DataSet();
            dataSet.ReadXml(new System.IO.StringReader(xmlResponse));

            NBRMDataGridView.DataSource = dataSet.Tables[0];
        }
          
        private void DownloadExchangeRatesButton_Click(object sender, EventArgs e) //Da se povika metodot so scheduler sekoj den vo 12:00
        {
            exchangeRates.AddNBRMDataInDataBase();
            getAllData();
        }

        private void RefreshDataButton_Click(object sender, EventArgs e)
        {
            getAllData();
        }
    }
}
