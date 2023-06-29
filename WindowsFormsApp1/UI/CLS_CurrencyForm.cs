using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;

namespace WindowsFormsApp1.UI
{
    public partial class CLS_CurrencyForm : Form
    {
        ICLS_CurrencyService cls_CurrencyService;

        public CLS_CurrencyForm(ICLS_CurrencyService cls_CurrencyService)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.cls_CurrencyService = cls_CurrencyService;
        }

        public CLS_CurrencyForm() : this(new CLSCurrencyServiceImpl()) { }

        private void CLS_CurrencyForm_Load(object sender, EventArgs e)
        {
            getAllData();
        }

        private void getAllData()
        {
            CLS_CurrencyDataGridView.DataSource = cls_CurrencyService.getAllData();
        }

        private bool isDataValid()
        {
            //code Logic
            bool codeFlag = true;

            if (string.IsNullOrEmpty(CodeTextBox.Text.Trim()))
            {
                clsCurrencyCodeErrorProvider.SetError(CodeTextBox, "Code is required!");
                codeFlag = false;
            }
            else if (CodeTextBox.Text.Length > 3)
            {
                clsCurrencyCodeErrorProvider.SetError(CodeTextBox, "Code is too long!");
                codeFlag = false;
            }
            else if (!Regex.IsMatch(CodeTextBox.Text, "^[A-Z]+$"))
            {
                clsCurrencyCodeErrorProvider.SetError(CodeTextBox, "Code must contain only letters!");
                codeFlag = false;
            }

            if (codeFlag)
            {
                clsCurrencyCodeErrorProvider.SetError(CodeTextBox, string.Empty);
                clsCurrencyCodeErrorProvider.Clear(); 
            }

            //name logic
            bool nameFlag = true;

            if (string.IsNullOrEmpty(NameTextBox2.Text.Trim()))
            {
                ClsCurrencyNameErrorProvider.SetError(NameTextBox2, "Name is required!");
                nameFlag = false;
            }
            else if (NameTextBox2.Text.Length > 50)
            {
                ClsCurrencyNameErrorProvider.SetError(NameTextBox2, "Name is too long!");
                nameFlag = false;
            }

            if (nameFlag)
            {
                ClsCurrencyNameErrorProvider.SetError(CodeTextBox, string.Empty);
                ClsCurrencyNameErrorProvider.Clear();
            }

            if (codeFlag && nameFlag) return true;
            else return false;
        }

        public void DRYCLS_Currency(object sender, EventArgs e, bool isExist)
        {
            CLS_Currency cls_Currency = new CLS_Currency();

            if (isExist)
            {
                var selectedRow = CLS_CurrencyDataGridView.SelectedRows[0];
                cls_Currency.CurrencyId = Convert.ToInt32(selectedRow.Cells["CurrencyId"].Value);
                cls_Currency.Name = NameTextBox2.Text.ToString();
                cls_Currency.Code = CodeTextBox.Text.ToString();
                cls_Currency.IsActive = ActivateUserCheckBox4.Checked;

                cls_CurrencyService.UpdateDataInExchangeRatesTable(cls_Currency);
            }
            else
            {
                cls_Currency.Name = NameTextBox2.Text.ToString();
                cls_Currency.Code = CodeTextBox.Text.ToString();
                cls_Currency.IsActive = ActivateUserCheckBox4.Checked;

                cls_CurrencyService.AddNewDataInExchangeRateTable(cls_Currency);
            }
            
            getAllData();
        }

        
        private void AddNewCLS_CurrencyButton_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            { 
                DRYCLS_Currency(sender, e, false);
                clearData();
            }
            
        }

        private void SaveCLS_CurrentButton_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                DRYCLS_Currency(sender, e, true);
                clearData();
            }
            
        }

        private void CLS_CurrencyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodeTextBox.Text = CLS_CurrencyDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            NameTextBox2.Text = CLS_CurrencyDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            ActivateUserCheckBox4.Checked = (bool)CLS_CurrencyDataGridView.Rows[e.RowIndex].Cells[3].Value;
        }

        private void clearData()
        {
            CodeTextBox.Text = "";
            NameTextBox2.Text = "";
            ActivateUserCheckBox4.Checked = false;
        }
    }
}
