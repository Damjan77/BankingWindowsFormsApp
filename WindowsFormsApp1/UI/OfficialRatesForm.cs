using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;

namespace WindowsFormsApp1.UI
{
    public partial class OfficialRatesForm : Form
    {
        SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        IOfficialRatesService officialRates;
        ICLS_CurrencyService cls_CurrencyService;
        public OfficialRatesForm()
        {
            InitializeComponent();
            officialRates = new OfficialRatesServiceImpl();
            cls_CurrencyService = new CLSCurrencyServiceImpl();
        }

        private void OfficialRatesForm_Load(object sender, EventArgs e)
        {
            OfficialRatesCurrencyComboBox.DataSource = cls_CurrencyService.getAllData();
            OfficialRatesCurrencyComboBox.ValueMember = "Code";
            OfficialRatesCurrencyComboBox.DisplayMember = "Code";
            OfficialRatesCurrencyComboBox.SelectedItem = null;
            getAllData();
        }

        private void getAllData()
        {
            OfficialRatedataGridView.DataSource = officialRates.getAllData("OfficialRates_GetAll");
        }

        private void clearOfficialRateData()
        {
            officialRateDateTimePicker.Value = DateTime.Now;
            OfficialRatesCurrencyComboBox.SelectedItem = null;
            RateTextBox.Text = "";
            UserActivationcheckBox2.Checked = false;
        }

        //private void GetAllOfficialRates(object sender, EventArgs e)
        //{
        //    getAllData(OfficialRatedataGridView);
        //}
   
        private bool isDataValid()
        {
            //currency Logic
            bool currencyFlag = true;
            if (OfficialRatesCurrencyComboBox.SelectedItem == null)
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
            else if (!Regex.IsMatch(RateTextBox.Text, "^[0-9.]+$")) //Only digits
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
                official.ValidityDate = officialRateDateTimePicker.Value;
                official.Currency = OfficialRatesCurrencyComboBox.Text.ToString();
                //official.Currency = CurrencyTextBox.Text.ToString();
                official.Rate = Decimal.Parse(RateTextBox.Text.ToString());
                official.isActive = UserActivationcheckBox2.Checked;

                officialRates.UpdateDataInOfficialRatesTable(official);
                getAllData();
                //UpdateDataInOfficialRatesTable(official);
                //GetAllOfficialRates(sender, e);
            }
            else
            {
                official.ValidityDate = officialRateDateTimePicker.Value;
                official.Currency = OfficialRatesCurrencyComboBox.Text.ToString();
                //official.Currency = CurrencyTextBox.Text.ToString();
                official.Rate = Decimal.Parse(RateTextBox.Text.ToString());
                official.isActive = UserActivationcheckBox2.Checked;

                officialRates.AddNewDataInOfficialRateTable(official);
                getAllData();
                //AddNewDataInOfficialRateTable(official);
                //GetAllOfficialRates(sender, e);
            }
        }

        //private void AddNewDataInOfficialRateTable(object toSave) //Add OfficialRate
        //{
        //    OfficialRate officialRate = toSave as OfficialRate;

        //    try
        //    {
        //        con.Open();
        //        SqlCommand sqlCommand = new SqlCommand("OfficialRates_Insert", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("ValidityDate", officialRate.ValidityDate);
        //        sqlCommand.Parameters.AddWithValue("Currency", officialRate.Currency);
        //        sqlCommand.Parameters.AddWithValue("Rate", officialRate.Rate);
        //        sqlCommand.Parameters.AddWithValue("isActive", officialRate.isActive);
        //        sqlCommand.ExecuteNonQuery();

        //        MessageBox.Show("Data saved Successfull");
        //        con.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //private void UpdateDataInOfficialRatesTable(object toSave) //Update OfficialRate
        //{
        //    OfficialRate officialRate = toSave as OfficialRate;
        //    try
        //    {
        //        con.Open();

        //        SqlCommand sqlCommand = new SqlCommand("OfficialRates_Update", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("OfficialRatesId", officialRate.OfficialRatesId);
        //        sqlCommand.Parameters.AddWithValue("ValidityDate", officialRate.ValidityDate);
        //        sqlCommand.Parameters.AddWithValue("Currency", officialRate.Currency);
        //        sqlCommand.Parameters.AddWithValue("Rate", officialRate.Rate);
        //        sqlCommand.Parameters.AddWithValue("isActive", officialRate.isActive);
        //        sqlCommand.ExecuteNonQuery();

        //        MessageBox.Show("Data updated Successfull");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

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
            officialRateDateTimePicker.Text = OfficialRatedataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            OfficialRatesCurrencyComboBox.Text = OfficialRatedataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            RateTextBox.Text = OfficialRatedataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            UserActivationcheckBox2.Checked = (bool)OfficialRatedataGridView.Rows[e.RowIndex].Cells[4].Value;
        }
    }
}
