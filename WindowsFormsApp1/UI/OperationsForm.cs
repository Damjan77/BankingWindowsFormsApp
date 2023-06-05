using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;

namespace WindowsFormsApp1.UI
{
    public partial class OperationsForm : Form
    {
        SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        IOperationService operationService;
        ICLS_OperationTypeService cLS_OperationType;
        public OperationsForm()
        {
            InitializeComponent();
            operationService = new OperationServiceImpl();
            cLS_OperationType = new CLS_OperationTypeServiceImpl(); 
        }
        Operation selectedOperation = new Operation();
        private void Operation_Load(object sender, EventArgs e)
        {
            getAllData();
            //GetAllOperations(sender, e);

            using (var myDb = new Model1())
            {
                var myUsers = myDb.Users.ToList();
                UsersComboBox.DataSource = myUsers;
                UsersComboBox.ValueMember = "UserId";
                UsersComboBox.DisplayMember = "UserId";
                UsersComboBox.SelectedItem = null;

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

        //private void GetAllOperations(object sender, EventArgs e)
        //{
        //    getAllData(OperationsDataGridView);
        //}

        //private Operation getOparationById(int? operationId)
        //{
        //    try
        //    {
        //        con.Open();
        //        SqlCommand sqlCommand = new SqlCommand(procedure, con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
        //        DataTable dataTable = new DataTable();
        //        adapter.Fill(dataTable);
        //        dataGridView.DataSource = dataTable;
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //private void getAllData(DataGridView dataGridView)
        //{
        //    using (var myDb = new Model1())
        //    {
        //        var myOperations = myDb.Operations.Select(operation => new {
        //            operation.OperationId,
        //            operation.OperationTypeId,
        //            operation.userId,
        //            operation.OperationDate,
        //            operation.Amount,
        //            operation.CurrencyFrom,
        //            operation.CurrencyTo,
        //        }).ToList();
        //        dataGridView.DataSource = myOperations.ToList();
        //    } 
        //}


        public void DRYOperation(object sender, EventArgs e, bool isExist)
        {
            Operation operation = new Operation();
            User userObj = UsersComboBox.SelectedItem as User;
            CLS_OperationType operationTypeObj = OperationTypeComboBox.SelectedItem as CLS_OperationType;
            CLS_Currency currencyFromObj = CurrencyFromComboBox.SelectedItem as CLS_Currency;
            CLS_Currency currencyToObj = CurrencyToComboBox.SelectedItem as CLS_Currency;

            if (isExist)
            {
                var selectedRow = OperationsDataGridView.SelectedRows[0];
                operation.OperationId = Convert.ToInt32(selectedRow.Cells["OperationId"].Value);
                operation.OperationTypeId = (int)operationTypeObj.OperationTypeId;
                operation.userId = (int)userObj.userId;
                operation.OperationDate = OperationsDateTimePicker.Value;
                operation.Amount = Decimal.Parse(AmountTextBox.Text.ToString());
                operation.CurrencyFrom = (string)currencyFromObj.Code;
                operation.CurrencyTo = (string)currencyToObj.Code;

                operationService.UpdateDataInOperationsTable(operation);
                //UpdateDataInOperationsTable(operation);
            }
            else
            {
                operation.OperationTypeId = (int)operationTypeObj.OperationTypeId;
                operation.userId = (int)userObj.userId;
                operation.OperationDate = OperationsDateTimePicker.Value;
                operation.Amount = Decimal.Parse(AmountTextBox.Text.ToString());
                operation.CurrencyFrom = (string)currencyFromObj.Code;
                operation.CurrencyTo = (string)currencyToObj.Code;

                operationService.AddNewDataInOperationsTable(operation);
                //AddNewDataInOperationsTable(operation);
            }

            getAllData();
            //GetAllOperations(sender, e);
        }

        //private void UpdateDataInOperationsTable(object toSave) //Update Operation
        //{
        //    Operation operation = toSave as Operation;

        //    try
        //    {
        //        con.Open();

        //        SqlCommand sqlCommand = new SqlCommand("Operations_Update", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("OperationId", operation.OperationId);
        //        sqlCommand.Parameters.AddWithValue("OperationTypeId", operation.OperationTypeId);
        //        sqlCommand.Parameters.AddWithValue("UserId", operation.userId);
        //        sqlCommand.Parameters.AddWithValue("OperationDate", operation.OperationDate);
        //        sqlCommand.Parameters.AddWithValue("Amount", operation.Amount);
        //        sqlCommand.Parameters.AddWithValue("CurrencyFrom", operation.CurrencyFrom);
        //        sqlCommand.Parameters.AddWithValue("CurrencyTo", operation.CurrencyTo);
        //        sqlCommand.ExecuteNonQuery();

        //        MessageBox.Show("Data updated Successfull");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //private void AddNewDataInOperationsTable(object toSave) //Add Operation
        //{
        //    Operation operation = toSave as Operation;

        //    try
        //    {
        //        con.Open();

        //        SqlCommand sqlCommand = new SqlCommand("Operations_Insert", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("OperationTypeId", operation.OperationTypeId);
        //        sqlCommand.Parameters.AddWithValue("UserId", operation.userId);
        //        sqlCommand.Parameters.AddWithValue("OperationDate", operation.OperationDate);
        //        sqlCommand.Parameters.AddWithValue("Amount", operation.Amount);
        //        sqlCommand.Parameters.AddWithValue("CurrencyFrom", operation.CurrencyFrom);
        //        sqlCommand.Parameters.AddWithValue("CurrencyTo", operation.CurrencyTo);
        //        sqlCommand.ExecuteNonQuery();

        //        MessageBox.Show("Data saved Successfull");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

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

        //private Operation getOparationTypeById(int? operationId)
        //{
            
        //}

        private void OperationsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedOperation = OperationsDataGridView.SelectedRows[0].DataBoundItem as Operation;           
            if (selectedOperation != null) 
            {
                OperationTypeComboBox.Text = cLS_OperationType.GetOperationTypeById(selectedOperation.OperationTypeId);
            }

            //OperationTypeComboBox.Text = selectedOperation.
            //OperationTypeComboBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            UsersComboBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            OperationsDateTimePicker.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            AmountTextBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            CurrencyFromComboBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            CurrencyToComboBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void clearData()
        {
            OperationTypeComboBox.SelectedItem = null;
            UsersComboBox.SelectedItem = null;
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
            else if (!Regex.IsMatch(AmountTextBox.Text, @"^[0-9.]+$")) //only letters
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
