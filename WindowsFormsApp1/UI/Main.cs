using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;
using WindowsFormsApp1.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        IExchangeRatesService exchangeRates;
        IOfficialRatesService officialRatesService;
        bool flagForSameForm = false;

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
                var currentForm = ActiveMdiChild;
                if (currentForm != null)
                {
                    currentForm.Close();
                }

                var form = new T();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form currentForm = this.ActiveMdiChild;
            //if (currentForm != null)
            //{
            //    currentForm.Close(); // Close the current form
            //    currentForm.Dispose(); // Dispose the current form
            //}

            //var userForm = new UserForm();
            //userForm.MdiParent = this;
            //userForm.Show();

            //this.SuspendLayout();
            //var currentForm = this.ActiveMdiChild;
            //if (currentForm != null)
            //{
            //    ActiveMdiChild.Close(); //Pravi avtomatski Dispose, bidejki formata e otvorena preku Show() 
            //}

            //var userForm = new UserForm();
            //userForm.MdiParent = this;
            //userForm.Show();
            //this.ResumeLayout();

            //this.SuspendLayout();
            //var currentForm = this.ActiveMdiChild;
            //if (ActiveMdiChild is UserForm)
            //{
            //    flagForSameForm = true;
            //}

            //if (!flagForSameForm)
            //{
            //    if (currentForm != null)
            //    {
            //        currentForm.Close(); // Close the current form
            //    }

            //    var userForm = new UserForm();
            //    userForm.MdiParent = this;
            //    userForm.Show();
            //}
            //flagForSameForm = false;
            //this.ResumeLayout();

            this.SuspendLayout();
            OpenForm<UserForm>(flagForSameForm: false);
            this.ResumeLayout();
        }

        private void officialRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            OpenForm<OfficialRatesForm>(flagForSameForm: false);
            this.ResumeLayout();

            //this.SuspendLayout();
            //var currentForm = this.ActiveMdiChild;
            //if (ActiveMdiChild is OfficialRatesForm)
            //{
            //    flagForSameForm = true;
            //}

            //if (!flagForSameForm)
            //{
            //    if (currentForm != null)
            //    {
            //        currentForm.Close(); // Close the current form
            //    }

            //    var officialRateForm = new OfficialRatesForm();
            //    officialRateForm.MdiParent = this;
            //    officialRateForm.Show();

            //}
            //flagForSameForm = false;
            //this.ResumeLayout();

            //this.SuspendLayout();
            //var currentForm = this.ActiveMdiChild;
            //if (currentForm != null)
            //{
            //    ActiveMdiChild.Close(); // Close the current form 
            //}

            //var officialRateForm = new OfficialRatesForm();
            //officialRateForm.MdiParent = this;
            //officialRateForm.Show();
            //this.ResumeLayout();
        }

        private void exchangeRatesToolStripMenuItem_Click(object sender, EventArgs e) //BUG padnuva pri brzo klikanje
        {
            //Form currentForm = this.ActiveMdiChild;
            //if (currentForm != null)
            //{
            //    currentForm.Close(); // Close the current form
            //    currentForm.FormClosed += (s, args) =>
            //    {
            //        currentForm.Dispose(); // Dispose the form after it is closed
            //    };

            //}

            //var userForm = new ExchangeRatesForm();
            //userForm.MdiParent = this;
            //userForm.Show();

            this.SuspendLayout();
            OpenForm<ExchangeRatesForm>(flagForSameForm: false);
            this.ResumeLayout();
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form currentForm = this.ActiveMdiChild;
            //if (currentForm != null)
            //{
            //    currentForm.Close(); // Close the current form
            //    currentForm.FormClosed += (s, args) =>
            //    {
            //        currentForm.Dispose(); // Dispose the form after it is closed
            //    };

            //}

            //var userForm = new OperationsForm();
            //userForm.MdiParent = this;
            //userForm.Show();

            this.SuspendLayout();
            OpenForm<OperationsForm>(flagForSameForm: false);
            this.ResumeLayout();
        }

        private void cLSCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form currentForm = this.ActiveMdiChild;
            //if (currentForm != null)
            //{
            //    currentForm.Close(); // Close the current form
            //    currentForm.FormClosed += (s, args) =>
            //    {
            //        currentForm.Dispose(); // Dispose the form after it is closed
            //    };

            //}

            //var userForm = new CLS_CurrencyForm();
            //userForm.MdiParent = this;
            //userForm.Show();

            this.SuspendLayout();
            OpenForm<CLS_CurrencyForm>(flagForSameForm: false);
            this.ResumeLayout();
        }

        private void cLSOperationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form currentForm = this.ActiveMdiChild;
            //if (currentForm != null)
            //{
            //    currentForm.Close(); // Close the current form
            //    currentForm.FormClosed += (s, args) =>
            //    {
            //        currentForm.Dispose(); // Dispose the form after it is closed
            //    };

            //}

            //var userForm = new CLS_OperatinoTypeForm();
            //userForm.MdiParent = this;
            //userForm.Show();

            this.SuspendLayout();
            OpenForm<CLS_OperatinoTypeForm>(flagForSameForm: false);
            this.ResumeLayout();
        }

        private void tDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form currentForm = this.ActiveMdiChild;

            //if (currentForm != null)
            //{
            //    currentForm.Close(); // Close the current form
            //    currentForm.FormClosed += (s, args) =>
            //    {
            //        currentForm.Dispose(); // Dispose the form after it is closed
            //    };
            //}
            //var tdaForm = new TDAForm();
            //tdaForm.MdiParent = this;
            //tdaForm.Show();

            this.SuspendLayout();
            OpenForm<TDAForm>(flagForSameForm: false);
            this.ResumeLayout();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form currentForm = this.ActiveMdiChild;
            //if (currentForm != null)
            //{
            //    currentForm.Close(); // Close the current form
            //    currentForm.FormClosed += (s, args) =>
            //    {
            //        currentForm.Dispose(); // Dispose the form after it is closed
            //    };
            //}
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
