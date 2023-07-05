using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;

namespace WindowsFormsApp1.UI
{
    public partial class CLS_OperatinoTypeForm : Form
    {
        SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        ICLS_OperationTypeService operationTypeService;
        public CLS_OperatinoTypeForm(ICLS_OperationTypeService operationTypeService)
        {
            InitializeComponent();
            this.operationTypeService = operationTypeService;
        }

        public CLS_OperatinoTypeForm() : this(new CLS_OperationTypeServiceImpl()) { }

        private void CLS_OperationTypeForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            getAllData();
        }

        private void getAllData()
        {
            CLS_OperationTypeDataGridView.DataSource = operationTypeService.getAllData("CLS_OperationType_GetAll");
        }

        private bool isDataValid()
        {
            //code Logic
            bool codeFlag = true;

            if (string.IsNullOrEmpty(CodeTextBox2.Text.Trim()))
            {
                clsOperationTypeCodeErrorProvider.SetError(CodeTextBox2, "Code is required!");
                codeFlag = false;
            }
            else if (CodeTextBox2.Text.Length > 3)
            {
                clsOperationTypeCodeErrorProvider.SetError(CodeTextBox2, "Code is too long!");
                codeFlag = false;
            }
            else if (!Regex.IsMatch(CodeTextBox2.Text, "^[A-Za-z]+$"))
            {
                clsOperationTypeCodeErrorProvider.SetError(CodeTextBox2, "Code must contain only letters!");
                codeFlag = false;
            }

            if (codeFlag)
            {
                clsOperationTypeCodeErrorProvider.SetError(CodeTextBox2, string.Empty);
                clsOperationTypeCodeErrorProvider.Clear();
            }

            //name Logic
            bool nameFlag = true;

            if (string.IsNullOrEmpty(NameTextBox3.Text.Trim()))
            {
                clsOperationTypeNameErrorProvider.SetError(NameTextBox3, "Name is required!");
                nameFlag = false;
            }
            else if (NameTextBox3.Text.Length > 50)
            {
                clsOperationTypeNameErrorProvider.SetError(NameTextBox3, "Name is too long!");
                nameFlag = false;
            }

            if (nameFlag)
            {
                clsOperationTypeNameErrorProvider.SetError(NameTextBox3, string.Empty);
                clsOperationTypeNameErrorProvider.Clear();
            }

            if (codeFlag && nameFlag) return true;
            else return false;

        }

        public void DRYCLS_OperationType(object sender, EventArgs e, bool isExist)
        {
            CLS_OperationType cls_OperationType = new CLS_OperationType();

            if (isExist)
            {
                var selectedRow = CLS_OperationTypeDataGridView.SelectedRows[0];
                cls_OperationType.OperationTypeId = Convert.ToInt32(selectedRow.Cells["OperationTypeId"].Value);
                cls_OperationType.Name = NameTextBox3.Text.ToString();
                cls_OperationType.Code = CodeTextBox2.Text.ToString().ToUpper();
                cls_OperationType.IsActive = checkBox1.Checked;

                operationTypeService.UpdateDataInExchangeRatesTable(cls_OperationType);
            }
            else
            {
                cls_OperationType.Name = NameTextBox3.Text.ToString();
                cls_OperationType.Code = CodeTextBox2.Text.ToString().ToUpper();
                cls_OperationType.IsActive = checkBox1.Checked;

                operationTypeService.AddNewDataInExchangeRateTable(cls_OperationType);
            }

            getAllData();
        }

        private void SaveCLS_OperationTypeButton_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            { 
                DRYCLS_OperationType(sender, e, true);
                clearData();
            }
           
        }

        private void AddNewOperationTypeButton_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            { 
                DRYCLS_OperationType(sender, e, false);
                clearData();
            }
            
        }

        private void CLS_OperationTypeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CodeTextBox2.Text = CLS_OperationTypeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                NameTextBox3.Text = CLS_OperationTypeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                checkBox1.Checked = (bool)CLS_OperationTypeDataGridView.Rows[e.RowIndex].Cells[3].Value;
            }
        }

        private void clearData()
        {
            CodeTextBox2.Text = "";
            NameTextBox3.Text = "";
            checkBox1.Checked = false;
        }
    }
}
