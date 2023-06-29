using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
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
        Operation selectedOperation = new Operation();
        string enviromentCurrency = Environment.GetEnvironmentVariable("CurrencyMKD");
        decimal rate = 0.0m;

        public OperationsForm(IOperationService operationService, ICLS_OperationTypeService cLS_OperationType)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.operationService = operationService;
            this.cLS_OperationType = cLS_OperationType;
        }

        public OperationsForm() : this(new OperationServiceImpl(), new CLS_OperationTypeServiceImpl()) { }

        private void Operation_Load(object sender, EventArgs e)
        {
            getAllData();

            using (var myDb = new Model1())
            {  
                var myOperationTypes = myDb.CLS_OperationType.ToList();
                OperationTypeComboBox.DataSource = myOperationTypes;
                OperationTypeComboBox.ValueMember = "Code";
                OperationTypeComboBox.DisplayMember = "Code";
                OperationTypeComboBox.SelectedItem = null;

                var myCurrencyFrom = myDb.CLS_Currency.ToList();
                var myCurrencyTo = myDb.CLS_Currency.ToList();

                CurrencyFromComboBox.DataSource = myCurrencyFrom;
                CurrencyToComboBox.DataSource = myCurrencyTo;
                CurrencyFromComboBox.ValueMember = "CurrencyId";
                CurrencyToComboBox.ValueMember = "CurrencyId";
                CurrencyFromComboBox.DisplayMember = "Code";
                CurrencyToComboBox.DisplayMember = "Code";
                CurrencyFromComboBox.SelectedItem = null;
                CurrencyToComboBox.SelectedItem = null;
            }

            OperationsDateTimePicker.Text = DateTime.Now.ToString();

        }

        private void getAllData()
        {
            OperationsDataGridView.DataSource = operationService.GetAllData("Operations_GetAll");
        }

        public void DRYOperation(object sender, EventArgs e, bool isExist)
        {
            Operation operation = new Operation();
            //User userObj = UsersComboBox.SelectedItem as User;
            CLS_OperationType operationTypeObj = OperationTypeComboBox.SelectedItem as CLS_OperationType;
            CLS_Currency currencyFromObj = CurrencyFromComboBox.SelectedItem as CLS_Currency;
            CLS_Currency currencyToObj = CurrencyToComboBox.SelectedItem as CLS_Currency;

            if (isExist)
            {
                var selectedRow = OperationsDataGridView.SelectedRows[0];
                operation.OperationId = Convert.ToInt32(selectedRow.Cells["OperationId"].Value);
                operation.OperationTypeId = (int)operationTypeObj.OperationTypeId;
                operation.userId = (int)UserSession.UserId;
                operation.OperationDate = OperationsDateTimePicker.Value;
                operation.Amount = Decimal.Parse(AmountTextBox.Text.ToString());
                operation.CurrencyFrom = (string)currencyFromObj.Code;
                operation.CurrencyTo = (string)currencyToObj.Code;

                operationService.UpdateDataInOperationsTable(operation);
            }
            else
            {
                operation.OperationTypeId = (int)operationTypeObj.OperationTypeId;
                //operation.userId = (int)userObj.userId;
                operation.userId = (int)UserSession.UserId;
                operation.OperationDate = OperationsDateTimePicker.Value;
                operation.Amount = Decimal.Parse(AmountTextBox.Text.ToString());
                operation.CurrencyFrom = (string)currencyFromObj.Code;
                operation.CurrencyTo = (string)currencyToObj.Code;

                if (operation.CurrencyFrom != enviromentCurrency && operation.CurrencyTo != enviromentCurrency) //Imame exchangeRate pr: EUR -> USD  
                {
                    rate = operationService.SearchRateFromExchangeRates((string)currencyFromObj.Code, (string)currencyToObj.Code); //Proverka za racno dodadeno
                    if (rate == 0.0m) //X -> Y zapis ne postoi vo ExchangeRate (ne e racno dodadeno)
                    {
                        rate = operationService.SearchRateFromExchangeRates((string)currencyFromObj.Code, enviromentCurrency); //Prvin najdi EUR -> MKD zemam kurs za evro vo denar
                        decimal tempMoney = operationService.transferMoney(Decimal.Parse(AmountTextBox.Text.ToString()), rate); //Sega imam denari, sledi MKD -> USD
                        rate = operationService.SearchRateFromExchangeRates(enviromentCurrency, (string)currencyToObj.Code); //baram ExchangeRate MKD -> USD
                        operation.t_money = operationService.transferMoney(tempMoney, 1/rate);
                    }
                    else
                    {
                        operation.t_money = operationService.transferMoney(operation.Amount, rate);
                    }
                }
                else
                {
                    rate = operationService.SearchRateFromExchangeRates((string)currencyFromObj.Code, (string)currencyToObj.Code);
                    if ((string)currencyFromObj.Code == enviromentCurrency) rate = 1 / rate;

                    operation.t_money = operationService.transferMoney(Decimal.Parse(AmountTextBox.Text.ToString()), rate);
                }

                if (rate == 0.0m)
                {
                    MessageBox.Show("ExchangeRate was not found!");
                }
                else
                {
                    operationService.AddNewDataInOperationsTable(operation);
                }
                


                //AddNewDataInOperationsTable(operation);
            }

            getAllData();
            //GetAllOperations(sender, e);
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
            selectedOperation = OperationsDataGridView.SelectedRows[0].DataBoundItem as Operation;           
            if (selectedOperation != null) 
            {
                OperationTypeComboBox.Text = cLS_OperationType.GetOperationTypeById(selectedOperation.OperationTypeId);
            }

            //OperationTypeComboBox.Text = selectedOperation.
            //OperationTypeComboBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            //UsersComboBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            OperationsDateTimePicker.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            AmountTextBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            CurrencyFromComboBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            CurrencyToComboBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void clearData()
        {
            OperationTypeComboBox.SelectedItem = null;
            OperationsDateTimePicker.Value = DateTime.Now;
            AmountTextBox.Text = "";
            CurrencyFromComboBox.SelectedItem = null;
            CurrencyToComboBox.SelectedItem = null;
        }

        private bool isDataValid()
        {
            //Operation Type Logic
            bool operationTypeFlag = true;

            if (OperationTypeComboBox.SelectedItem == null)
            {
                OperationsOperationTypeErrorProvider.SetError(OperationTypeComboBox, "Select Currency");
                operationTypeFlag = false;
            }
            if (operationTypeFlag)
            {
                OperationsOperationTypeErrorProvider.SetError(CurrencyFromComboBox, string.Empty);
                OperationsOperationTypeErrorProvider.Clear();
            }

            //currencyFrom Logic
            bool currencyFromFlag = true;

            if (CurrencyFromComboBox.SelectedItem == null)
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

            if (CurrencyToComboBox.SelectedItem == null)
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

    }
}
