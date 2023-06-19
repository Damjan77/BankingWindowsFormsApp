using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.UI;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        //ObservableCollection<Panel> panels = new ObservableCollection<Panel>();

        //SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public Main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            //panels.Add(OfficialRatesPanel);
            //panels.Add(UsersPanel);
            //panels.Add(ExchangeRatesPanel);
            //panels.Add(OperationsPanel);
            //panels.Add(CLS_CurrencyPanel);
            //panels.Add(CLS_OperationTypePanel);

            UsersPanel.Visible = false;
            OfficialRatesPanel.Visible = false;
            ExchangeRatesPanel.Visible = false;
            OperationsPanel.Visible = false;
            CLS_CurrencyPanel.Visible = false;
            CLS_OperationTypePanel.Visible = false;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form currentForm = this.ActiveMdiChild;
            if (currentForm != null)
            {
                currentForm.Close(); // Close the current form
                currentForm.Dispose(); // Dispose the current form
            }

            var userForm = new UserForm();
            userForm.MdiParent = this;
            userForm.Show();      
        }

        private void officialRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form currentForm = this.ActiveMdiChild;
            if (currentForm != null)
            {
                currentForm.Close(); // Close the current form
                currentForm.Dispose(); // Dispose the current form
            }

            var userForm = new OfficialRatesForm();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void exchangeRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form currentForm = this.ActiveMdiChild;
            if (currentForm != null)
            {
                currentForm.Close(); // Close the current form
                currentForm.Dispose(); // Dispose the current form
            }

            var userForm = new ExchangeRatesForm();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form currentForm = this.ActiveMdiChild;
            if (currentForm != null)
            {
                currentForm.Close(); // Close the current form
                currentForm.Dispose(); // Dispose the current form
            }

            var userForm = new OperationsForm();
            userForm.MdiParent = this;
            userForm.Show(); 
        }

        private void cLSCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form currentForm = this.ActiveMdiChild;
            if (currentForm != null)
            {
                currentForm.Close(); // Close the current form
                currentForm.Dispose(); // Dispose the current form
            }

            var userForm = new CLS_CurrencyForm();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void cLSOperationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form currentForm = this.ActiveMdiChild;
            if (currentForm != null)
            {
                currentForm.Close(); // Close the current form
                currentForm.Dispose(); // Dispose the current form
            }

            var userForm = new CLS_OperatinoTypeForm();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void tDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form currentForm = this.ActiveMdiChild;
            if (currentForm != null)
            {
                currentForm.Close(); // Close the current form
                currentForm.Dispose(); // Dispose the current form
            }

            var tdaForm = new TDAForm();
            tdaForm.MdiParent = this;
            tdaForm.Show();
        }

        //private void getAllData(string procedure, DataGridView dataGridView)
        //{
        //    //using(var myDb = new Model1())
        //    //{
        //    //    var myUsers = myDb.Users.ToList();
        //    //    dataGridView.DataSource = myUsers;
        //    //}

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


        //public void InsertDataInUserTable(object toSave)
        //{        
        //    User usr = toSave as User;

        //    try
        //    {
        //        con.Open();

        //        SqlCommand sqlCommand = new SqlCommand("Users_InsertUser", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("userId", usr.userId);
        //        sqlCommand.Parameters.AddWithValue("name", usr.name);
        //        sqlCommand.Parameters.AddWithValue("surname", usr.surname);
        //        sqlCommand.Parameters.AddWithValue("isActive", usr.isActive);
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

        //private void UpdateDataInOperationsTable(object toSave) //Update Operation
        //{
        //    Operation operation = toSave as Operation;

        //    try
        //    {
        //        con.Open();

        //        SqlCommand sqlCommand = new SqlCommand("Operations_Update", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("OperationId", operation.OperationId);
        //        sqlCommand.Parameters.AddWithValue("OperationTypeId",operation.OperationTypeId);
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

        //private void UpdateDataInClsCurrencyTable(object toSave) //Update CLS_Currency
        //{
        //    CLS_Currency cls_Currency = toSave as CLS_Currency;         

        //    try
        //    {
        //        con.Open();

        //        SqlCommand sqlCommand = new SqlCommand("CLS_Currency_Update", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("CurrencyId", cls_Currency.CurrencyId);
        //        sqlCommand.Parameters.AddWithValue("Code", cls_Currency.Code);
        //        sqlCommand.Parameters.AddWithValue("Name", cls_Currency.Name);
        //        sqlCommand.Parameters.AddWithValue("IsActive", cls_Currency.IsActive);
        //        sqlCommand.ExecuteNonQuery();

        //        MessageBox.Show("Data updated Successfull");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //private void AddNewDataInClsCurrencyTable(object toSave) //Add CLS_Currency
        //{
        //    CLS_Currency cls_Currency = toSave as CLS_Currency;

        //    try
        //    {
        //        con.Open();

        //        SqlCommand sqlCommand = new SqlCommand("CLS_Currency_INSERT", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("Code", cls_Currency.Code);
        //        sqlCommand.Parameters.AddWithValue("Name", cls_Currency.Name);
        //        sqlCommand.Parameters.AddWithValue("IsActive", cls_Currency.IsActive);
        //        sqlCommand.ExecuteNonQuery();

        //        MessageBox.Show("Data saved Successfull");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}



        //private void UpdateDataInClsOperationTypeTable(object toSave) //Update CLS_OperationType
        //{
        //    CLS_OperationType cls_OperationType = toSave as CLS_OperationType;

        //    try
        //    {
        //        con.Open();

        //        SqlCommand sqlCommand = new SqlCommand("CLS_OperationType_Update", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("OperationTypeId", cls_OperationType.OperationTypeId);
        //        sqlCommand.Parameters.AddWithValue("Code", cls_OperationType.Code);
        //        sqlCommand.Parameters.AddWithValue("Name", cls_OperationType.Name);
        //        sqlCommand.Parameters.AddWithValue("IsActive", cls_OperationType.IsActive);
        //        sqlCommand.ExecuteNonQuery();

        //        MessageBox.Show("Data saved Successfull");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //private void AddNewDataInClsOperationTypeTable(object toSave) //Add CLS_OperationType
        //{
        //    CLS_OperationType cls_OperationType = toSave as CLS_OperationType;  

        //    try
        //    {
        //        con.Open();

        //        SqlCommand sqlCommand = new SqlCommand("CLS_OperationType_Insert", con);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("Code", cls_OperationType.Code);
        //        sqlCommand.Parameters.AddWithValue("Name", cls_OperationType.Name);
        //        sqlCommand.Parameters.AddWithValue("IsActive", cls_OperationType.IsActive);
        //        sqlCommand.ExecuteNonQuery();

        //        MessageBox.Show("Data saved Successfull");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //private void GetAllUsers(object sender, EventArgs e)
        //{
        //     getAllData("Users_GetAll", UsersDataGridView);
        //}

        //private void GetAllOfficialRates(object sender, EventArgs e)
        //{
        //    getAllData("OfficialRates_GetAll", OfficialRatedataGridView);
        //}

        //private void GetAllExchangeRates(object sender, EventArgs e)
        //{
        //    getAllData("ExchangeRates_GetAll", ExchangeRatesDataGridView);
        //}

        //private void GetAllOperations(object sender, EventArgs e)
        //{
        //    getAllData("Operations_GetAll", OperationsDataGridView);
        //}

        //private void GetAll_Cls_Currency(object sender, EventArgs e)
        //{ 
        //    getAllData("CLS_Currency_GetAll", CLS_CurrencyDataGridView);
        //}

        //private void GetAll_CLS_OperationType(object sender, EventArgs e)
        //{
        //    getAllData("CLS_OperationType_GetAll", CLS_OperationTypeDataGridView);
        //}

        //private void SetVisibility(object sender)
        //{
        //    var findPanel = panels.ToList().Find(x => x.Name == (sender as ToolStripMenuItem).AccessibleName);
        //    findPanel.Visible = true;
        //    findPanel.BringToFront();
        //    panels.ToList().FindAll(x => x.Name != (sender as ToolStripMenuItem).AccessibleName).ForEach(y => y.Visible = false);
        //}



        //private void SaveUserButton_Click(object sender, EventArgs e)
        //{
        //    DRYUser(sender, e, true);

        //}
        //public void DRYUser(object sender, EventArgs e, bool IamExisting)
        //{
        //    User usr = new User();

        //    if (IamExisting)
        //    {
        //        var selected = ((DataRowView)UsersDataGridView.SelectedRows[0].DataBoundItem).Row.ItemArray;
        //        usr.userId = Int32.Parse(selected[0].ToString());
        //    }
        //    usr.surname = SurnameTextBox.Text.ToString();
        //    usr.isActive = CheckBoxForUserActivation.Checked;
        //    usr.name = NameTextBox1.Text.ToString();

        //    InsertDataInUserTable(usr);
        //    GetAllUsers(sender, e);
        //}

        //public void DRYOfficialRate(object sender, EventArgs e)
        //{
        //    OfficialRate official = new OfficialRate();

        //    official.ValidityDate = DateTime.Parse(ValidityDateTextBox.Text.ToString());
        //    official.Currency = CurrencyTextBox.Text.ToString();
        //    official.Rate = Decimal.Parse(RateTextBox.Text.ToString());
        //    official.isActive = UserActivationcheckBox2.Checked;

        //    AddNewDataInOfficialRateTable(official);
        //    GetAllOfficialRates(sender, e);
        //}

        //public void DRYExchengeRate(object sender, EventArgs e)
        //{
        //    ExchangeRate exchangeRate = new ExchangeRate();

        //    exchangeRate.ValidityDate = DateTime.Parse(ValidityDateTextBox2.Text.ToString());
        //    exchangeRate.CurrencyFrom = CurrencyFromTextBox.Text.ToString();
        //    exchangeRate.CurrencyTo = CurrencyToTextBox.Text.ToString();
        //    exchangeRate.Rate = Decimal.Parse(RateTextBox2.Text.ToString());
        //    exchangeRate.IsActive = ActivateUserCheckBox3.Checked;

        //    AddNewDataInExchangeRateTable(exchangeRate);
        //    GetAllExchangeRates(sender, e);
        //}

        //public void DRYOperation(object sender, EventArgs e)
        //{
        //    Operation operation = new Operation();

        //    operation.OperationTypeId = Int32.Parse(OperationTypeTextBox.Text.ToString());
        //    operation.userId = Int32.Parse(UserIdTextBox.Text.ToString());
        //    operation.OperationDate = DateTime.Parse(OperationDateTextBox.Text.ToString());
        //    operation.Amount = Decimal.Parse(AmountTextBox.Text.ToString());
        //    operation.CurrencyFrom = CurrencyFromTextBox2.Text.ToString();
        //    operation.CurrencyTo = textBox3.Text.ToString(); //TODO promeni name na text box

        //    AddNewDataInOperationsTable(operation);
        //    GetAllOperations(sender, e);
        //}

        //public void DRYCLS_Currency(object sender, EventArgs e)
        //{
        //    CLS_Currency cls_Currency = new CLS_Currency();

        //    cls_Currency.Name = NameTextBox2.Text.ToString();
        //    cls_Currency.Code = CodeTextBox.Text.ToString();
        //    cls_Currency.IsActive = ActivateUserCheckBox4.Checked;

        //    AddNewDataInClsCurrencyTable(cls_Currency);
        //    GetAll_Cls_Currency(sender, e);          
        //}

        //public void DRYCLS_OperationType(object sender, EventArgs e)
        //{
        //    CLS_OperationType cls_OperationType = new CLS_OperationType();

        //    cls_OperationType.Name = NameTextBox3.Text.ToString();
        //    cls_OperationType.Code = CodeTextBox2.Text.ToString();
        //    cls_OperationType.IsActive = checkBox1.Checked;

        //    AddNewDataInClsOperationTypeTable(cls_OperationType);
        //    GetAll_CLS_OperationType(sender, e);
        //}


        //private void SaveOfficialRate_Click(object sender, EventArgs e)
        //{
        //    OfficialRate officialRate = new OfficialRate();
        //    var selected = ((System.Data.DataRowView)OfficialRatedataGridView.SelectedRows[0].DataBoundItem).Row.ItemArray;

        //    officialRate.OfficialRatesId = Int32.Parse(selected[0].ToString());
        //    officialRate.ValidityDate = DateTime.Parse(ValidityDateTextBox.Text.ToString());
        //    officialRate.Currency = CurrencyTextBox.Text.ToString();
        //    officialRate.Rate = Decimal.Parse(RateTextBox.Text.ToString());
        //    officialRate.isActive = UserActivationcheckBox2.Checked;


        //    UpdateDataInOfficialRatesTable(officialRate);
        //    GetAllOfficialRates(sender, e);
        //}

        //private void ExchangeRatesButton_Click(object sender, EventArgs e)
        //{
        //    ExchangeRate exchangeRate = new ExchangeRate();
        //    var selected = ((System.Data.DataRowView)ExchangeRatesDataGridView.SelectedRows[0].DataBoundItem).Row.ItemArray;

        //    exchangeRate.exchangeRatesId = Int32.Parse(selected[0].ToString());
        //    exchangeRate.ValidityDate = DateTime.Parse(ValidityDateTextBox2.Text.ToString());
        //    exchangeRate.CurrencyFrom = CurrencyFromTextBox.Text.ToString();
        //    exchangeRate.CurrencyTo = CurrencyToTextBox.Text.ToString();
        //    exchangeRate.Rate = Decimal.Parse(RateTextBox2.Text.ToString());
        //    exchangeRate.IsActive = ActivateUserCheckBox3.Checked;

        //    UpdateDataInExchangeRatesTable(exchangeRate);
        //    GetAllExchangeRates(sender, e);
        //}

        //private void SaveOperationButton_Click(object sender, EventArgs e)
        //{
        //    Operation operation = new Operation();
        //    var selected = ((System.Data.DataRowView)OperationsDataGridView.SelectedRows[0].DataBoundItem).Row.ItemArray;


        //    operation.OperationId = Int32.Parse(selected[0].ToString());
        //    operation.OperationTypeId = Int32.Parse(OperationTypeTextBox.Text.ToString());
        //    operation.userId = Int32.Parse(UserIdTextBox.Text.ToString());
        //    operation.OperationDate = DateTime.Parse(OperationDateTextBox.Text.ToString());
        //    operation.Amount = Decimal.Parse(AmountTextBox.Text.ToString());
        //    operation.CurrencyFrom = CurrencyFromTextBox2.Text.ToString();   
        //    operation.CurrencyTo = textBox3.Text.ToString();

        //    UpdateDataInOperationsTable(operation);
        //    GetAllOperations(sender, e);
        //}

        //private void CLS_CurrentButton_Click(object sender, EventArgs e)
        //{
        //    CLS_Currency cls_Currency = new CLS_Currency();
        //    var selected = ((System.Data.DataRowView)CLS_CurrencyDataGridView.SelectedRows[0].DataBoundItem).Row.ItemArray;

        //    cls_Currency.CurrencyId = Int32.Parse(selected[0].ToString());
        //    cls_Currency.Name = NameTextBox2.Text.ToString();
        //    cls_Currency.Code = CodeTextBox.Text.ToString();
        //    cls_Currency.IsActive = ActivateUserCheckBox4.Checked;

        //    UpdateDataInClsCurrencyTable(cls_Currency);
        //    GetAll_Cls_Currency(sender, e);
        //}

        //private void VLS_OperationTypeButton_Click(object sender, EventArgs e)
        //{
        //    CLS_OperationType cls_OperationType = new CLS_OperationType();
        //    var selected = ((System.Data.DataRowView)CLS_OperationTypeDataGridView.SelectedRows[0].DataBoundItem).Row.ItemArray;

        //    cls_OperationType.OperationTypeId = Int32.Parse(selected[0].ToString());
        //    cls_OperationType.Name = NameTextBox3.Text.ToString();
        //    cls_OperationType.Code = CodeTextBox2.Text.ToString();
        //    cls_OperationType.IsActive = checkBox1.Checked;

        //    UpdateDataInClsOperationTypeTable(cls_OperationType);
        //    GetAll_CLS_OperationType(sender, e);
        //}

        //private void UsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    UsersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Dokolku se klikne bilo kade na dataGridiew

        //    UsersDataGridView.CurrentCell.Selected = true;
        //    NameTextBox1.Text = UsersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    SurnameTextBox.Text = UsersDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    CheckBoxForUserActivation.Checked = (bool)UsersDataGridView.Rows[e.RowIndex].Cells[3].Value;
        //}

        //private string getDateWithoutTime(string dateTime)
        //{
        //    string dateTimeString = dateTime.ToString();
        //    string[] array = dateTimeString.Split(' ');
        //    return array[0];
        //}

        //private void OfficialRatedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string dateTime = getDateWithoutTime(OfficialRatedataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
        //    ValidityDateTextBox.Text = dateTime;
        //    CurrencyTextBox.Text = OfficialRatedataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    RateTextBox.Text = OfficialRatedataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        //    UserActivationcheckBox2.Checked = (bool)OfficialRatedataGridView.Rows[e.RowIndex].Cells[4].Value;
        //}

        //private void ExchangeRatesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string dateTime = getDateWithoutTime(ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
        //    ValidityDateTextBox2.Text = dateTime;
        //    CurrencyFromTextBox.Text = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    CurrencyToTextBox.Text = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        //    RateTextBox2.Text = ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
        //    ActivateUserCheckBox3.Checked = (bool)ExchangeRatesDataGridView.Rows[e.RowIndex].Cells[5].Value;
        //}

        //private void OperationsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    OperationTypeTextBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    UserIdTextBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    OperationDateTextBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        //    AmountTextBox.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
        //    CurrencyFromTextBox2.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        //    textBox3.Text = OperationsDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        //}

        //private void CLS_CurrencyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    CodeTextBox.Text = CLS_CurrencyDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    NameTextBox2.Text = CLS_CurrencyDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    ActivateUserCheckBox4.Checked = (bool)CLS_CurrencyDataGridView.Rows[e.RowIndex].Cells[3].Value;
        //}

        //private void CLS_OperationTypeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    CodeTextBox2.Text = CLS_OperationTypeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    NameTextBox3.Text = CLS_OperationTypeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    checkBox1.Checked = (bool)CLS_OperationTypeDataGridView.Rows[e.RowIndex].Cells[3].Value;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    DRYUser(sender, e, false);
        //}

        //private void AddNewOfficialRateButton_Click(object sender, EventArgs e)
        //{   
        //    DRYOfficialRate(sender, e);
        //}

        //private void AddNewExchangeRateButton_Click(object sender, EventArgs e)
        //{
        //    DRYExchengeRate(sender, e);
        //}

        //private void AddNewOperationButton_Click(object sender, EventArgs e)
        //{
        //    DRYOperation(sender, e);
        //}

        //private void AddNewCLS_CurrencyButton_Click(object sender, EventArgs e)
        //{
        //    DRYCLS_Currency(sender, e);
        //}

        //private void AddNewOperationTypeButton_Click(object sender, EventArgs e)
        //{
        //    DRYCLS_OperationType(sender, e);
        //}
    }
}
