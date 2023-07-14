using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;

namespace WindowsFormsApp1.UI
{
    public partial class OperationsForm : Form
    {
        IOperationService operationService;
        ICLS_OperationTypeService cLS_OperationType;
        ICLS_CurrencyService cLS_Currency;
        Operation selectedOperation = new Operation();
        string enviromentCurrency = Environment.GetEnvironmentVariable("CurrencyMKD");
        decimal rate = 0.0m;

        public OperationsForm(IOperationService operationService, ICLS_OperationTypeService cLS_OperationType, ICLS_CurrencyService cLS_Currency)
        {
            InitializeComponent();
            this.operationService = operationService;
            this.cLS_OperationType = cLS_OperationType;
            this.cLS_Currency = cLS_Currency;
        }

        public OperationsForm() : this(new OperationServiceImpl(), new CLS_OperationTypeServiceImpl(), new CLSCurrencyServiceImpl()) { }

        private void Operation_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            CurrencyFromComboBox.DataSource = cLS_Currency.getAllActiveData();
            CurrencyToComboBox.DataSource = cLS_Currency.getAllActiveData();
            CurrencyFromComboBox.ValueMember = "CurrencyId";
            CurrencyToComboBox.ValueMember = "CurrencyId";
            CurrencyFromComboBox.DisplayMember = "Code";
            CurrencyToComboBox.DisplayMember = "Code";
            CurrencyFromComboBox.SelectedItem = null;
            CurrencyToComboBox.SelectedItem = null;

            if (UserSession.roleid == 1) //Basic 
            {
                getAllDataByUserId();
                SaveOperationButton.Visible = false;
                SearchOperationLabel.Visible = false;
                UserIdLabel.Visible = false;
                SearchOperationTextBox.Visible = false;
                SearchOperationsButton.Visible = false;
                AllOperationsButton.Visible = false;
            }
            else if (UserSession.roleid == 2) //Admin
            {
                getAllData();
                SaveOperationButton.Visible = true;
                SearchOperationLabel.Visible = true;
                UserIdLabel.Visible = true;
                SearchOperationTextBox.Visible = true;
                SearchOperationsButton.Visible = true;
                AllOperationsButton.Visible = true;
            }

            OperationsDateTimePicker.Text = DateTime.Now.ToString();
        }

        private void getAllData()
        {
            OperationsDataGridView.DataSource = operationService.GetAllData();
        }

        private void getAllDataByUserId()
        {
            OperationsDataGridView.DataSource = operationService.GetAllOperationByUserId((int)UserSession.UserId);
        }

        private string GetOperationType(string currencyFromCode) //Method to return SEL Or BUY
        {
            return currencyFromCode == Environment.GetEnvironmentVariable("CurrencyMKD") ? Environment.GetEnvironmentVariable("OperationTypeBUY")
                : Environment.GetEnvironmentVariable("OperationTypeSEL");
        }

        private int? GetOperationTypeId(string operationType)
        {
            return cLS_OperationType.getOperationTypeId(operationType);
        }

        private decimal CalculateExchangeRate(string currencyFrom, string currencyTo)
        {
            decimal rate = operationService.SearchRateFromExchangeRates(currencyFrom, currencyTo);
            
            if (rate > 0 && rate < 1)//
            {
                return rate;
            }
            else if (rate > 0)
            {
                if (currencyFrom == Environment.GetEnvironmentVariable("CurrencyMKD"))
                    rate = 1 / rate;
            }

            return rate;
        }

        public void DRYOperation(object sender, EventArgs e, bool isExist)
        {
            Operation operation = new Operation();

            CLS_Currency currencyFromObj = CurrencyFromComboBox.SelectedItem as CLS_Currency;
            CLS_Currency currencyToObj = CurrencyToComboBox.SelectedItem as CLS_Currency;

            if (currencyFromObj.Code == currencyToObj.Code)
            {
                MessageBox.Show("CurrencyFrom and CurrencyTo can not be the same!");
                return;
            }

            string operationType = GetOperationType(currencyFromObj.Code); //BUY or SEL
            int? operationTypeId = GetOperationTypeId(operationType); //7002 or 7003

            if (operationTypeId == -1)
            {
                MessageBox.Show("Operation Type was not found! Data update unsuccessful.");
                return;
            }

            operation.OperationTypeId = operationTypeId;
            operation.userId = (int)UserSession.UserId;
            operation.OperationDate = DateTime.Now;
            operation.Amount = decimal.Parse(AmountTextBox.Text.ToString());
            operation.CurrencyFrom = currencyFromObj.Code;
            operation.CurrencyTo = currencyToObj.Code;

            if (operation.CurrencyFrom != enviromentCurrency && operation.CurrencyTo != enviromentCurrency) //EUR -> USD
            {
                rate = CalculateExchangeRate(operation.CurrencyFrom, operation.CurrencyTo); //Proverka za racno vneseno
                if (rate == 0.0m) //Zapisot ne postoi
                {
                    rate = operationService.SearchRateFromExchangeRates((string)currencyFromObj.Code, enviromentCurrency); //Prvin najdi EUR -> MKD zemam kurs za evro vo denar
                    decimal tempMoney = operationService.transferMoney(Decimal.Parse(AmountTextBox.Text.ToString()), rate); //Sega imam denari, sledi MKD -> USD
                    rate = operationService.SearchRateFromExchangeRates(enviromentCurrency, (string)currencyToObj.Code); //baram ExchangeRate MKD -> USD
                    operation.t_money = operationService.transferMoney(tempMoney, 1 / rate);
                }
                else //Zapisot e racno vnesen i postoi vo ExchangeRates
                {
                    operation.t_money = operationService.transferMoney(operation.Amount, rate);
                }
            }
            else //EUR -> MKD   ||   MKD -> EUR
            {
                rate = CalculateExchangeRate(operation.CurrencyFrom, operation.CurrencyTo);
                operation.t_money = operationService.transferMoney(Decimal.Parse(AmountTextBox.Text.ToString()), rate);

                if (operation.t_money == 0)
                {
                    MessageBox.Show("ExchangeRate does not find!");
                    return;
                }
            }

            //operation.t_money = operationService.transferMoney(operation.Amount, rate);

            if (isExist)
            {
                var selectedRow = OperationsDataGridView.SelectedRows[0];
                operation.OperationId = Convert.ToInt32(selectedRow.Cells["OperationId"].Value);
                operationService.UpdateDataInOperationsTable(operation);
            }
            else
            {
                operationService.AddNewDataInOperationsTable(operation);
            }

            if (UserSession.roleid == 1)
            {
                getAllDataByUserId();
            }
            else
            {
                getAllData();
            }
            
        }

        private void SaveOperationButton_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                DRYOperation(sender, e, true);
                clearData();
            }
        }

        private void AddNewOperationButton_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                DRYOperation(sender, e, false);
                clearData();
            }
        }


        private void OperationsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //selectedOperation = OperationsDataGridView.SelectedRows[0].DataBoundItem as Operation;           
                //if (selectedOperation != null) 
                //{
                //    OperationTypeComboBox.Text = cLS_OperationType.GetOperationTypeById(selectedOperation.OperationTypeId);
                //}

                //OperationTypeComboBox.Text = selectedOperation.
                //OperationTypeComboBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                //UsersComboBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                OperationsDateTimePicker.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                AmountTextBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                CurrencyFromComboBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                CurrencyToComboBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void clearData()
        {
            //OperationTypeComboBox.SelectedItem = null;
            OperationsDateTimePicker.Value = DateTime.Now;
            AmountTextBox.Text = "";
            CurrencyFromComboBox.SelectedItem = null;
            CurrencyToComboBox.SelectedItem = null;
        }

        private bool isDataValid()
        {
            ////Operation Type Logic
            //bool operationTypeFlag = true;

            //if (OperationTypeComboBox.SelectedItem == null)
            //{
            //    OperationsOperationTypeErrorProvider.SetError(OperationTypeComboBox, "Select Currency");
            //    operationTypeFlag = false;
            //}
            //if (operationTypeFlag)
            //{
            //    OperationsOperationTypeErrorProvider.SetError(CurrencyFromComboBox, string.Empty);
            //    OperationsOperationTypeErrorProvider.Clear();
            //}

            //currencyFrom Logic
            bool currencyFromFlag = true;

            if (CurrencyFromComboBox.Text == "")
            {
                OperationsCurrencyFromErrorProvider.SetError(CurrencyFromComboBox, "Select Currency");
                currencyFromFlag = false;
            }          
            if (currencyFromFlag)
            {
                OperationsCurrencyFromErrorProvider.SetError(CurrencyFromComboBox, string.Empty);
                OperationsCurrencyFromErrorProvider.Clear();
            }
            
            //CurrencyTo Logic
            bool currencyToFlag = true;

            if (CurrencyToComboBox.Text == "")
            {
                OperationsCurrencyToErrorProvider.SetError(CurrencyToComboBox, "Select Currency");
                currencyToFlag = false;
            }
            if (currencyToFlag)
            {
                OperationsCurrencyToErrorProvider.SetError(CurrencyToComboBox, string.Empty);
                OperationsCurrencyToErrorProvider.Clear();
            }


            //amount Logic
            bool amountFlag = true;
            if (string.IsNullOrEmpty(AmountTextBox.Text.Trim()))
            {
                OperationsAmountErrorProvider.SetError(AmountTextBox, "Amount is required!");
                amountFlag = false;
            }
            else if (!(Regex.IsMatch(AmountTextBox.Text, "^[0-9]+(?:\\.?)+[0-9]+$")) && !(Regex.IsMatch(AmountTextBox.Text, "^[0-9]+$")))
            {
                OperationsAmountErrorProvider.SetError(AmountTextBox, "CurrencyTo must contains only numbers!");
                amountFlag = false;
            }
            if (amountFlag)
            {
                OperationsAmountErrorProvider.SetError(AmountTextBox, string.Empty);
                OperationsAmountErrorProvider.Clear();
            }

            if (currencyFromFlag && currencyToFlag && amountFlag) return true;
            else return false;
        }

        public bool isDataSearchValid()
        {
            //userId Logic
            bool userIdFlag = true;
            if (string.IsNullOrEmpty(SearchOperationTextBox.Text.Trim()))
            {
                SearchErrorProvider.SetError(SearchOperationTextBox, "Please enter userId for searching");
                userIdFlag = false;
            }
            else if (!(Regex.IsMatch(SearchOperationTextBox.Text, "^[0-9]+$"))) //Only numbers
            {
                SearchErrorProvider.SetError(SearchOperationTextBox, "userId contains only numbers!");
                userIdFlag = false;
            }
            if (userIdFlag)
            {
                SearchErrorProvider.SetError(SearchOperationTextBox, string.Empty);
                SearchErrorProvider.Clear();
            }

            return userIdFlag;
        }

        private void SearchOperationsButton_Click(object sender, EventArgs e)
        {
            if (isDataSearchValid())
            {
                int userId = Int32.Parse(SearchOperationTextBox.Text);
                OperationsDataGridView.DataSource = operationService.GetAllOperationByUserId(userId);
            }
        }

        private void AllOperationsButton_Click(object sender, EventArgs e)
        {
            getAllData();
        }
    }
}
