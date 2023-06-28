using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;

namespace WindowsFormsApp1.UI
{
    public partial class TDAForm : Form
    {
        ITDAService tDAService;
        public TDAForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            tDAService = new TDAServiceImpl();
        }
        private void TDAForm_Load(object sender, EventArgs e)
        {
            //OriginalCalculateButtonRectangle = new Rectangle(CalculateButton.Location.X, CalculateButton.Location.Y, CalculateButton.Width, CalculateButton.Height);
            //OriginalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
        }

        private void getAllData()
        {
            
            Decimal amount = Decimal.Parse(AmountTextBox.Text);
            int period = Int32.Parse(PeriodTextBox.Text);
            Decimal interestRate = Decimal.Parse(InterestRateTextBox.Text);

            TDADataGridView.DataSource = tDAService.getAllTDAData(amount, period, interestRate);
            var result = tDAService.getAllAnnuityData(amount, period, interestRate);
            AnnuitydataGridView.DataSource = result; 
        }

        //private void GetTdaData(object sender, EventArgs e)
        //{
        //    getAllData("CalculateTermDepositAmount", TDADataGridView);
        //}

        private void clearData()
        {
            AmountTextBox.Text = "";
            PeriodTextBox.Text = "";
            InterestRateTextBox.Text = "";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                getAllData();
                clearData(); 
            }
            
        }

        private bool isDataValid()
        {
            //Amount Logic
            bool amountFlag = true;

            if(string.IsNullOrEmpty(AmountTextBox.Text))
            {
                amountFlag = false;
                AmountErrorProvider.SetError(AmountTextBox, "Amount is required!");
            }
            else if (!(Regex.IsMatch(AmountTextBox.Text, "^[0-9]+(?:\\.?)+[0-9]+$")) && !(Regex.IsMatch(AmountTextBox.Text, "^[0-9]+$")))
            {
                AmountErrorProvider.SetError(AmountTextBox, "Amount must contains only numbers!");
                amountFlag = false;
            }
            else
            {
                AmountErrorProvider.SetError(AmountTextBox, string.Empty);
                AmountErrorProvider.Clear();
            }

            //Period Logic
            bool periodFlag = true;

            if (string.IsNullOrEmpty(PeriodTextBox.Text))
            {
                periodFlag = false;
                PeriodErrorProvider.SetError(PeriodTextBox, "Period is required!");
            }
            else if (!Regex.IsMatch(PeriodTextBox.Text, "^[0-9]+$"))
            {
                PeriodErrorProvider.SetError(PeriodTextBox, "Period must contains only numbers!");
                periodFlag = false;
            }
            else
            {
                PeriodErrorProvider.SetError(PeriodTextBox, string.Empty);
                PeriodErrorProvider.Clear();
            }

            //Interest Rate Logic
            bool interestRateFlag = true;

            if (string.IsNullOrEmpty(InterestRateTextBox.Text))
            {
                interestRateFlag = false;
                InterestRateErrorProvider.SetError(InterestRateTextBox, "Interest Rate is required!");
            }
            //else if (!Regex.IsMatch(InterestRateTextBox.Text, "^[0-9.]+$")) //Only digits
            else if (!(Regex.IsMatch(InterestRateTextBox.Text, "^[0-9]+(?:\\.?)+[0-9]+$")) && !(Regex.IsMatch(InterestRateTextBox.Text, "^[0-9]+$")))
            {
                InterestRateErrorProvider.SetError(InterestRateTextBox, "Interest Rate must contains only numbers!");
                interestRateFlag = false;
            }
            else
            {
                InterestRateErrorProvider.SetError(InterestRateTextBox, string.Empty);
                InterestRateErrorProvider.Clear();
            }

            if (amountFlag && periodFlag && interestRateFlag) return true;
            else return false;
        }

        //private void resizeControl(Rectangle r, Control c)
        //{
        //    float xRation = (float)(this.Width) / (float)(OriginalFormSize.Width);
        //    float yRation = (float)(this.Height) / (float)(OriginalFormSize.Height);

        //    int newX = (int)(r.Width * xRation);
        //    int newY = (int)(r.Height * yRation);

        //    int newWidth = (int)(r.Width * xRation);
        //    int newHeight = (int)(r.Height * yRation);

        //    c.Location = new Point(newX, newY);
        //    c.Size = new Size(newWidth, newHeight);
        //}

        //private void TDAForm_Resize(object sender, EventArgs e)
        //{
        //    resizeControl(OriginalCalculateButtonRectangle, CalculateButton);
        //}
    }
}
