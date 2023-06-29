using System;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;
using WindowsFormsApp1.UI;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        IExchangeRatesService exchangeRates;
        IOfficialRatesService officialRatesService;

        public Main(IExchangeRatesService exchangeRates, IOfficialRatesService officialRatesService)
        {
            InitializeComponent();
            this.exchangeRates = exchangeRates;
            this.officialRatesService = officialRatesService;
        }

        public Main() : this(new ExchangeRatesServiceImpl(), new OfficialRatesServiceImpl()) { }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Scheduler.StartScheduling(exchangeRates,officialRatesService);
        }

        private void OpenForm<T>(bool flagForSameForm) where T : Form, new()
        {
            if (!(ActiveMdiChild is T) && !flagForSameForm)
            {
                this.SuspendLayout();
                var currentForm = ActiveMdiChild;
                if (currentForm != null)
                {
                    currentForm.Close();
                }

                var form = new T();
                form.MdiParent = this;
                form.Show();
                this.ResumeLayout();
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<UserForm>(flagForSameForm: false);
        }

        private void officialRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<OfficialRatesForm>(flagForSameForm: false);
        }

        private void exchangeRatesToolStripMenuItem_Click(object sender, EventArgs e) //BUG padnuva pri brzo klikanje
        {
            OpenForm<ExchangeRatesForm>(flagForSameForm: false);
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<OperationsForm>(flagForSameForm: false);
        }

        private void cLSCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<CLS_CurrencyForm>(flagForSameForm: false);
        }

        private void cLSOperationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<CLS_OperatinoTypeForm>(flagForSameForm: false);
        }

        private void tDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<TDAForm>(flagForSameForm: false);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Log Out?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
                var logInForm = new LogInForm();
                UserSession.UserName = null;
                UserSession.UserId = null;
                logInForm.Show();
            }
        }   
    }
}
