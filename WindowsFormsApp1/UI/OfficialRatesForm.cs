using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.NBRMServiceReference;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;

namespace WindowsFormsApp1.UI
{
    public partial class OfficialRatesForm : Form
    {
        IOfficialRatesService officialRates;
        ICLS_CurrencyService cls_CurrencyService;
        public OfficialRatesForm(IOfficialRatesService officialRates, ICLS_CurrencyService cls_CurrencyService)
        {
            InitializeComponent();
            
            this.officialRates = officialRates;
            this.cls_CurrencyService = cls_CurrencyService;
        }

        public OfficialRatesForm() : this(new OfficialRatesServiceImpl(), new CLSCurrencyServiceImpl()) { }


        private void OfficialRatesForm_Load(object sender, EventArgs e)
        {
            OfficialRatesCurrencyComboBox.DataSource = cls_CurrencyService.getAllActiveData();
            OfficialRatesCurrencyComboBox.ValueMember = "Code";
            OfficialRatesCurrencyComboBox.DisplayMember = "Code";
            OfficialRatesCurrencyComboBox.SelectedItem = null;

            this.WindowState = FormWindowState.Maximized;
            getAllData();
        }

        private void getAllData()
        {
            OfficialRatedataGridView.DataSource = officialRates.getAllData();
        }

        private void clearOfficialRateData()
        {
            officialRateDateTimePicker.Value = DateTime.Now;
            OfficialRatesCurrencyComboBox.SelectedItem = null;
            OfficialRatesCurrencyComboBox.Text = "";
            RateTextBox.Text = "";
            UserActivationcheckBox2.Checked = false;
        }
   
        private bool isDataValid()
        {
            //currency Logic
            bool currencyFlag = true;
            if (OfficialRatesCurrencyComboBox.Text == "")
            {
                officialRateCurrencyErrorProvider.SetError(OfficialRatesCurrencyComboBox, "Please select currency!");
                currencyFlag = false;
            }
            if (currencyFlag)
            {
                officialRateCurrencyErrorProvider.SetError(OfficialRatesCurrencyComboBox, string.Empty);
                officialRateCurrencyErrorProvider.Clear();
            }

            //Rate Logic
            bool rateFlag = true;
            if (string.IsNullOrEmpty(RateTextBox.Text.Trim()))
            {
                officialRateRateErrorProvider.SetError(RateTextBox, "Rate is required!");
                rateFlag = false;
            }
            else if (!(Regex.IsMatch(RateTextBox.Text, "^[0-9]+(?:\\.?)+[0-9]+$")) && !(Regex.IsMatch(RateTextBox.Text, "^[0-9]+$"))) //Only digits and .
            {
                officialRateRateErrorProvider.SetError(RateTextBox, "Rate must contains only numbers!");
                rateFlag = false;
            }
            if (rateFlag)
            {
                officialRateRateErrorProvider.SetError(RateTextBox, string.Empty);
                officialRateRateErrorProvider.Clear();
            }

            if (currencyFlag && rateFlag) return true;
            else return false;

        }

        public void DRYOfficialRate(object sender, EventArgs e, bool isExist)
        {
            OfficialRate official = new OfficialRate();

            if (isExist)
            {
                var selected = OfficialRatedataGridView.SelectedRows[0];
                official.OfficialRatesId = Convert.ToInt32(selected.Cells["OfficialRatesId"].Value);
                official.ValidityDate = DateTime.Now;
                official.Currency = OfficialRatesCurrencyComboBox.Text.ToString();
                official.Rate = Decimal.Parse(RateTextBox.Text.ToString());
                official.isActive = UserActivationcheckBox2.Checked;

                officialRates.UpdateDataInOfficialRatesTable(official);
                getAllData();
            }
            else
            {
                official.ValidityDate = DateTime.Now;
                official.Currency = OfficialRatesCurrencyComboBox.Text.ToString();
                official.Rate = Decimal.Parse(RateTextBox.Text.ToString());
                official.isActive = UserActivationcheckBox2.Checked;

                officialRates.AddNewDataInOfficialRateTable(official);
                getAllData();
            }
        }

        private void AddNewOfficialRateButton_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                DRYOfficialRate(sender, e, false);
                clearOfficialRateData(); 
            }
        }

        private void SaveOfficialRate_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                DRYOfficialRate(sender, e, true);
                clearOfficialRateData(); 
            }           
        }

        private void OfficialRatedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                officialRateDateTimePicker.Text = OfficialRatedataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                OfficialRatesCurrencyComboBox.Text = OfficialRatedataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                RateTextBox.Text = OfficialRatedataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                UserActivationcheckBox2.Checked = (bool)OfficialRatedataGridView.Rows[e.RowIndex].Cells[4].Value;
            }
            
        }

        private void NBRMDataButton_Click(object sender, EventArgs e)
        {
            officialRates.AddNBRMDataInDataBase();
            getAllData();
        }

        private void viewOfficialRatesNBRM_Click(object sender, EventArgs e)
        {
            var service = new KursSoapClient();
            string xmlResponse = service.GetExchangeRate(DateTime.Now.ToString("dd.MM.yyyy"), DateTime.Now.AddDays(1).ToString("dd.MM.yyyy"));
            var dataSet = new DataSet();
            dataSet.ReadXml(new System.IO.StringReader(xmlResponse));

            ViewOfficialRatesNBRMDataGridView.DataSource = dataSet.Tables[0];
        }

        private void RefreshDataButton_Click_1(object sender, EventArgs e)
        {
            getAllData();
        }
        
    }
}
