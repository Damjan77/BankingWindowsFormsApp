using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officialRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchangeRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLSCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLSOperationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersPanel = new System.Windows.Forms.Panel();
            this.UsersDataLabel = new System.Windows.Forms.Label();
            this.CheckBoxForUserActivation = new System.Windows.Forms.CheckBox();
            this.UserActivationLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.SaveUserButton = new System.Windows.Forms.Button();
            this.AddNewUSer = new System.Windows.Forms.Button();
            this.OfficialRatesPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ValidityDatalabel = new System.Windows.Forms.Label();
            this.OfficialRatedataGridView = new System.Windows.Forms.DataGridView();
            this.OfficialRatesDatalabel = new System.Windows.Forms.Label();
            this.AddNewOfficialRateButton = new System.Windows.Forms.Button();
            this.ValidityDateTextBox = new System.Windows.Forms.TextBox();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.UserActivationcheckBox2 = new System.Windows.Forms.CheckBox();
            this.SaveOfficialRate = new System.Windows.Forms.Button();
            this.Currencylabel = new System.Windows.Forms.Label();
            this.UserActivationLabel2 = new System.Windows.Forms.Label();
            this.Ratelabel = new System.Windows.Forms.Label();
            this.CurrencyTextBox = new System.Windows.Forms.TextBox();
            this.ExchangeRatesPanel = new System.Windows.Forms.Panel();
            this.AddNewExchangeRateButton = new System.Windows.Forms.Button();
            this.ActivateUserCheckBox3 = new System.Windows.Forms.CheckBox();
            this.ActivateUserLabel3 = new System.Windows.Forms.Label();
            this.RateTextBox2 = new System.Windows.Forms.TextBox();
            this.CurrencyToTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyToLabel = new System.Windows.Forms.Label();
            this.ExchangeRatesDataLabel = new System.Windows.Forms.Label();
            this.RateLabel2 = new System.Windows.Forms.Label();
            this.CurrencyFromLabel = new System.Windows.Forms.Label();
            this.ValidityDateLabel2 = new System.Windows.Forms.Label();
            this.ExchangeRatesDataGridView = new System.Windows.Forms.DataGridView();
            this.CurrencyFromTextBox = new System.Windows.Forms.TextBox();
            this.ValidityDateTextBox2 = new System.Windows.Forms.TextBox();
            this.ExchangeRatesButton = new System.Windows.Forms.Button();
            this.OperationsPanel = new System.Windows.Forms.Panel();
            this.AddNewOperationButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CurrencyFromTextBox2 = new System.Windows.Forms.TextBox();
            this.CurrencyToLabel2 = new System.Windows.Forms.Label();
            this.CurrencyFromLabel2 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.OperationDateTextBox = new System.Windows.Forms.TextBox();
            this.OperationDateLabel = new System.Windows.Forms.Label();
            this.OperationsDataLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OperationsDataGridView = new System.Windows.Forms.DataGridView();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.OperationTypeTextBox = new System.Windows.Forms.TextBox();
            this.SaveOperationButton = new System.Windows.Forms.Button();
            this.CLS_OperationTypePanel = new System.Windows.Forms.Panel();
            this.AddNewOperationTypeButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CLS_OperationTypeLabel = new System.Windows.Forms.Label();
            this.NameLabel3 = new System.Windows.Forms.Label();
            this.CodeLabel2 = new System.Windows.Forms.Label();
            this.CLS_OperationTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.NameTextBox3 = new System.Windows.Forms.TextBox();
            this.CodeTextBox2 = new System.Windows.Forms.TextBox();
            this.VLS_OperationTypeButton = new System.Windows.Forms.Button();
            this.CLS_CurrencyPanel = new System.Windows.Forms.Panel();
            this.AddNewCLS_CurrencyButton = new System.Windows.Forms.Button();
            this.ActivateUserCheckBox4 = new System.Windows.Forms.CheckBox();
            this.ActivateUserLabel4 = new System.Windows.Forms.Label();
            this.CLS_CurrencyLabel = new System.Windows.Forms.Label();
            this.NameLabel2 = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.CLS_CurrencyDataGridView = new System.Windows.Forms.DataGridView();
            this.NameTextBox2 = new System.Windows.Forms.TextBox();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.CLS_CurrentButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.UsersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.OfficialRatesPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfficialRatedataGridView)).BeginInit();
            this.ExchangeRatesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesDataGridView)).BeginInit();
            this.OperationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsDataGridView)).BeginInit();
            this.CLS_OperationTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLS_OperationTypeDataGridView)).BeginInit();
            this.CLS_CurrencyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLS_CurrencyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.officialRatesToolStripMenuItem,
            this.exchangeRatesToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.cLSCurrencyToolStripMenuItem,
            this.cLSOperationTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.AccessibleName = "UsersPanel";
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // officialRatesToolStripMenuItem
            // 
            this.officialRatesToolStripMenuItem.AccessibleName = "OfficialRatesPanel";
            this.officialRatesToolStripMenuItem.Name = "officialRatesToolStripMenuItem";
            this.officialRatesToolStripMenuItem.Size = new System.Drawing.Size(131, 29);
            this.officialRatesToolStripMenuItem.Text = "Official Rates";
            this.officialRatesToolStripMenuItem.Click += new System.EventHandler(this.officialRatesToolStripMenuItem_Click);
            // 
            // exchangeRatesToolStripMenuItem
            // 
            this.exchangeRatesToolStripMenuItem.AccessibleName = "ExchangeRatesPanel";
            this.exchangeRatesToolStripMenuItem.Name = "exchangeRatesToolStripMenuItem";
            this.exchangeRatesToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.exchangeRatesToolStripMenuItem.Text = "Exchange Rates";
            this.exchangeRatesToolStripMenuItem.Click += new System.EventHandler(this.exchangeRatesToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.AccessibleName = "OperationsPanel";
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.operationsToolStripMenuItem.Text = "Operations";
            this.operationsToolStripMenuItem.Click += new System.EventHandler(this.operationsToolStripMenuItem_Click);
            // 
            // cLSCurrencyToolStripMenuItem
            // 
            this.cLSCurrencyToolStripMenuItem.AccessibleName = "CLS_CurrencyPanel";
            this.cLSCurrencyToolStripMenuItem.Name = "cLSCurrencyToolStripMenuItem";
            this.cLSCurrencyToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.cLSCurrencyToolStripMenuItem.Text = "CLS_Currency";
            this.cLSCurrencyToolStripMenuItem.Click += new System.EventHandler(this.cLSCurrencyToolStripMenuItem_Click);
            // 
            // cLSOperationTypeToolStripMenuItem
            // 
            this.cLSOperationTypeToolStripMenuItem.AccessibleName = "CLS_OperationTypePanel";
            this.cLSOperationTypeToolStripMenuItem.Name = "cLSOperationTypeToolStripMenuItem";
            this.cLSOperationTypeToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.cLSOperationTypeToolStripMenuItem.Text = "CLS_Operation_Type";
            this.cLSOperationTypeToolStripMenuItem.Click += new System.EventHandler(this.cLSOperationTypeToolStripMenuItem_Click);
            // 
            // UsersPanel
            // 
            this.UsersPanel.Controls.Add(this.UsersDataLabel);
            this.UsersPanel.Controls.Add(this.CheckBoxForUserActivation);
            this.UsersPanel.Controls.Add(this.UserActivationLabel);
            this.UsersPanel.Controls.Add(this.SurnameLabel);
            this.UsersPanel.Controls.Add(this.NameLabel);
            this.UsersPanel.Controls.Add(this.UsersDataGridView);
            this.UsersPanel.Controls.Add(this.SurnameTextBox);
            this.UsersPanel.Controls.Add(this.NameTextBox1);
            this.UsersPanel.Controls.Add(this.SaveUserButton);
            this.UsersPanel.Controls.Add(this.AddNewUSer);
            this.UsersPanel.Location = new System.Drawing.Point(48, 122);
            this.UsersPanel.Name = "UsersPanel";
            this.UsersPanel.Size = new System.Drawing.Size(1047, 576);
            this.UsersPanel.TabIndex = 8;
            // 
            // UsersDataLabel
            // 
            this.UsersDataLabel.AutoSize = true;
            this.UsersDataLabel.Location = new System.Drawing.Point(717, 40);
            this.UsersDataLabel.Name = "UsersDataLabel";
            this.UsersDataLabel.Size = new System.Drawing.Size(90, 20);
            this.UsersDataLabel.TabIndex = 21;
            this.UsersDataLabel.Text = "Users Data";
            // 
            // CheckBoxForUserActivation
            // 
            this.CheckBoxForUserActivation.AutoSize = true;
            this.CheckBoxForUserActivation.Location = new System.Drawing.Point(192, 150);
            this.CheckBoxForUserActivation.Name = "CheckBoxForUserActivation";
            this.CheckBoxForUserActivation.Size = new System.Drawing.Size(147, 24);
            this.CheckBoxForUserActivation.TabIndex = 20;
            this.CheckBoxForUserActivation.Text = "Click to Activate";
            this.CheckBoxForUserActivation.UseVisualStyleBackColor = true;
            // 
            // UserActivationLabel
            // 
            this.UserActivationLabel.AutoSize = true;
            this.UserActivationLabel.Location = new System.Drawing.Point(37, 154);
            this.UserActivationLabel.Name = "UserActivationLabel";
            this.UserActivationLabel.Size = new System.Drawing.Size(116, 20);
            this.UserActivationLabel.TabIndex = 19;
            this.UserActivationLabel.Text = "User Activation";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(37, 99);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(74, 20);
            this.SurnameLabel.TabIndex = 18;
            this.SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(37, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Name";
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToOrderColumns = true;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Location = new System.Drawing.Point(495, 99);
            this.UsersDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsersDataGridView.MultiSelect = false;
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.RowHeadersWidth = 62;
            this.UsersDataGridView.RowTemplate.Height = 33;
            this.UsersDataGridView.Size = new System.Drawing.Size(539, 451);
            this.UsersDataGridView.TabIndex = 16;
            this.UsersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridView_CellClick);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(192, 93);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(266, 26);
            this.SurnameTextBox.TabIndex = 15;
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Location = new System.Drawing.Point(192, 40);
            this.NameTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(266, 26);
            this.NameTextBox1.TabIndex = 14;
            // 
            // SaveUserButton
            // 
            this.SaveUserButton.Location = new System.Drawing.Point(192, 211);
            this.SaveUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveUserButton.Name = "SaveUserButton";
            this.SaveUserButton.Size = new System.Drawing.Size(135, 34);
            this.SaveUserButton.TabIndex = 13;
            this.SaveUserButton.Text = "Save";
            this.SaveUserButton.UseVisualStyleBackColor = true;
            this.SaveUserButton.Click += new System.EventHandler(this.SaveUserButton_Click);
            // 
            // AddNewUSer
            // 
            this.AddNewUSer.Location = new System.Drawing.Point(192, 261);
            this.AddNewUSer.Size = new System.Drawing.Size(135, 34);
            this.AddNewUSer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddNewUSer.Name = "AddNewUSer";
            this.AddNewUSer.Size = new System.Drawing.Size(135, 34);
            this.AddNewUSer.TabIndex = 22;
            this.AddNewUSer.Text = "Add";
            this.AddNewUSer.UseVisualStyleBackColor = true;
            this.AddNewUSer.Click += new System.EventHandler(this.button1_Click);
            // 
            // OfficialRatesPanel
            // 
            this.OfficialRatesPanel.Controls.Add(this.tableLayoutPanel1);
            this.OfficialRatesPanel.Location = new System.Drawing.Point(48, 122);
            this.OfficialRatesPanel.Name = "OfficialRatesPanel";
            this.OfficialRatesPanel.Size = new System.Drawing.Size(1571, 864);
            this.OfficialRatesPanel.TabIndex = 22;
            this.OfficialRatesPanel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ValidityDatalabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OfficialRatedataGridView, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.OfficialRatesDatalabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddNewOfficialRateButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ValidityDateTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RateTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UserActivationcheckBox2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SaveOfficialRate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Currencylabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserActivationLabel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Ratelabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CurrencyTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(129, 159);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 545);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // ValidityDatalabel
            // 
            this.ValidityDatalabel.AutoSize = true;
            this.ValidityDatalabel.Location = new System.Drawing.Point(3, 0);
            this.ValidityDatalabel.Name = "ValidityDatalabel";
            this.ValidityDatalabel.Size = new System.Drawing.Size(94, 20);
            this.ValidityDatalabel.TabIndex = 17;
            this.ValidityDatalabel.Text = "ValidityDate";
            // 
            // OfficialRatedataGridView
            // 
            this.OfficialRatedataGridView.AllowUserToOrderColumns = true;
            this.OfficialRatedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OfficialRatedataGridView.Location = new System.Drawing.Point(403, 42);
            this.OfficialRatedataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OfficialRatedataGridView.MultiSelect = false;
            this.OfficialRatedataGridView.Name = "OfficialRatedataGridView";
            this.OfficialRatedataGridView.RowHeadersWidth = 62;
            this.tableLayoutPanel1.SetRowSpan(this.OfficialRatedataGridView, 4);
            this.OfficialRatedataGridView.RowTemplate.Height = 33;
            this.OfficialRatedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OfficialRatedataGridView.Size = new System.Drawing.Size(539, 451);
            this.OfficialRatedataGridView.TabIndex = 16;
            this.OfficialRatedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OfficialRatedataGridView_CellClick);
            // 
            // OfficialRatesDatalabel
            // 
            this.OfficialRatesDatalabel.AutoSize = true;
            this.OfficialRatesDatalabel.Location = new System.Drawing.Point(403, 0);
            this.OfficialRatesDatalabel.Name = "OfficialRatesDatalabel";
            this.OfficialRatesDatalabel.Size = new System.Drawing.Size(143, 20);
            this.OfficialRatesDatalabel.TabIndex = 21;
            this.OfficialRatesDatalabel.Text = "Official Rates Data";
            // 
            // AddNewOfficialRateButton
            // 
            this.AddNewOfficialRateButton.Location = new System.Drawing.Point(3, 163);
            this.AddNewOfficialRateButton.Name = "AddNewOfficialRateButton";
            this.AddNewOfficialRateButton.Size = new System.Drawing.Size(150, 30);
            this.AddNewOfficialRateButton.TabIndex = 33;
            this.AddNewOfficialRateButton.Text = "Add";
            this.AddNewOfficialRateButton.UseVisualStyleBackColor = true;
            this.AddNewOfficialRateButton.Click += new System.EventHandler(this.AddNewOfficialRateButton_Click);
            // 
            // ValidityDateTextBox
            // 
            this.ValidityDateTextBox.Location = new System.Drawing.Point(203, 2);
            this.ValidityDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValidityDateTextBox.Name = "ValidityDateTextBox";
            this.ValidityDateTextBox.Size = new System.Drawing.Size(194, 26);
            this.ValidityDateTextBox.TabIndex = 14;
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(203, 82);
            this.RateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(194, 26);
            this.RateTextBox.TabIndex = 23;
            // 
            // UserActivationcheckBox2
            // 
            this.UserActivationcheckBox2.AutoSize = true;
            this.UserActivationcheckBox2.Location = new System.Drawing.Point(203, 123);
            this.UserActivationcheckBox2.Name = "UserActivationcheckBox2";
            this.UserActivationcheckBox2.Size = new System.Drawing.Size(147, 24);
            this.UserActivationcheckBox2.TabIndex = 20;
            this.UserActivationcheckBox2.Text = "Click to Activate";
            this.UserActivationcheckBox2.UseVisualStyleBackColor = true;
            // 
            // SaveOfficialRate
            // 
            this.SaveOfficialRate.Location = new System.Drawing.Point(203, 162);
            this.SaveOfficialRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveOfficialRate.Name = "SaveOfficialRate";
            this.SaveOfficialRate.Size = new System.Drawing.Size(159, 34);
            this.SaveOfficialRate.TabIndex = 13;
            this.SaveOfficialRate.Text = "Save";
            this.SaveOfficialRate.UseVisualStyleBackColor = true;
            this.SaveOfficialRate.Click += new System.EventHandler(this.SaveOfficialRate_Click);
            // 
            // Currencylabel
            // 
            this.Currencylabel.AutoSize = true;
            this.Currencylabel.Location = new System.Drawing.Point(3, 40);
            this.Currencylabel.Name = "Currencylabel";
            this.Currencylabel.Size = new System.Drawing.Size(72, 20);
            this.Currencylabel.TabIndex = 18;
            this.Currencylabel.Text = "Currency";
            // 
            // UserActivationLabel2
            // 
            this.UserActivationLabel2.AutoSize = true;
            this.UserActivationLabel2.Location = new System.Drawing.Point(3, 120);
            this.UserActivationLabel2.Name = "UserActivationLabel2";
            this.UserActivationLabel2.Size = new System.Drawing.Size(116, 20);
            this.UserActivationLabel2.TabIndex = 19;
            this.UserActivationLabel2.Text = "User Activation";
            // 
            // Ratelabel
            // 
            this.Ratelabel.AutoSize = true;
            this.Ratelabel.Location = new System.Drawing.Point(3, 80);
            this.Ratelabel.Name = "Ratelabel";
            this.Ratelabel.Size = new System.Drawing.Size(44, 20);
            this.Ratelabel.TabIndex = 22;
            this.Ratelabel.Text = "Rate";
            // 
            // CurrencyTextBox
            // 
            this.CurrencyTextBox.Location = new System.Drawing.Point(203, 42);
            this.CurrencyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrencyTextBox.Name = "CurrencyTextBox";
            this.CurrencyTextBox.Size = new System.Drawing.Size(194, 26);
            this.CurrencyTextBox.TabIndex = 15;
            // 
            // ExchangeRatesPanel
            // 
            this.ExchangeRatesPanel.Controls.Add(this.AddNewExchangeRateButton);
            this.ExchangeRatesPanel.Controls.Add(this.ActivateUserCheckBox3);
            this.ExchangeRatesPanel.Controls.Add(this.ActivateUserLabel3);
            this.ExchangeRatesPanel.Controls.Add(this.RateTextBox2);
            this.ExchangeRatesPanel.Controls.Add(this.CurrencyToTextBox);
            this.ExchangeRatesPanel.Controls.Add(this.CurrencyToLabel);
            this.ExchangeRatesPanel.Controls.Add(this.ExchangeRatesDataLabel);
            this.ExchangeRatesPanel.Controls.Add(this.RateLabel2);
            this.ExchangeRatesPanel.Controls.Add(this.CurrencyFromLabel);
            this.ExchangeRatesPanel.Controls.Add(this.ValidityDateLabel2);
            this.ExchangeRatesPanel.Controls.Add(this.ExchangeRatesDataGridView);
            this.ExchangeRatesPanel.Controls.Add(this.CurrencyFromTextBox);
            this.ExchangeRatesPanel.Controls.Add(this.ValidityDateTextBox2);
            this.ExchangeRatesPanel.Controls.Add(this.ExchangeRatesButton);
            this.ExchangeRatesPanel.Location = new System.Drawing.Point(48, 122);
            this.ExchangeRatesPanel.Name = "ExchangeRatesPanel";
            this.ExchangeRatesPanel.Size = new System.Drawing.Size(1044, 576);
            this.ExchangeRatesPanel.TabIndex = 24;
            this.ExchangeRatesPanel.Visible = false;
            // 
            // AddNewExchangeRateButton
            // 
            this.AddNewExchangeRateButton.Location = new System.Drawing.Point(177, 356);
            this.AddNewExchangeRateButton.Size = new System.Drawing.Size(207, 34);
            this.AddNewExchangeRateButton.Name = "AddNewExchangeRateButton";
            this.AddNewExchangeRateButton.TabIndex = 32;
            this.AddNewExchangeRateButton.Text = "Add";
            this.AddNewExchangeRateButton.UseVisualStyleBackColor = true;
            this.AddNewExchangeRateButton.Click += new System.EventHandler(this.AddNewExchangeRateButton_Click);
            // 
            // ActivateUserCheckBox3
            // 
            this.ActivateUserCheckBox3.AutoSize = true;
            this.ActivateUserCheckBox3.Location = new System.Drawing.Point(189, 257);
            this.ActivateUserCheckBox3.Name = "ActivateUserCheckBox3";
            this.ActivateUserCheckBox3.Size = new System.Drawing.Size(92, 24);
            this.ActivateUserCheckBox3.TabIndex = 27;
            this.ActivateUserCheckBox3.Text = "Activate";
            this.ActivateUserCheckBox3.UseVisualStyleBackColor = true;
            // 
            // ActivateUserLabel3
            // 
            this.ActivateUserLabel3.AutoSize = true;
            this.ActivateUserLabel3.Location = new System.Drawing.Point(37, 257);
            this.ActivateUserLabel3.Name = "ActivateUserLabel3";
            this.ActivateUserLabel3.Size = new System.Drawing.Size(104, 20);
            this.ActivateUserLabel3.TabIndex = 26;
            this.ActivateUserLabel3.Text = "Activate User";
            // 
            // RateTextBox2
            // 
            this.RateTextBox2.Location = new System.Drawing.Point(189, 208);
            this.RateTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RateTextBox2.Name = "RateTextBox2";
            this.RateTextBox2.Size = new System.Drawing.Size(266, 26);
            this.RateTextBox2.TabIndex = 24;
            // 
            // CurrencyToTextBox
            // 
            this.CurrencyToTextBox.Location = new System.Drawing.Point(192, 153);
            this.CurrencyToTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrencyToTextBox.Name = "CurrencyToTextBox";
            this.CurrencyToTextBox.Size = new System.Drawing.Size(266, 26);
            this.CurrencyToTextBox.TabIndex = 23;
            // 
            // CurrencyToLabel
            // 
            this.CurrencyToLabel.AutoSize = true;
            this.CurrencyToLabel.Location = new System.Drawing.Point(37, 156);
            this.CurrencyToLabel.Name = "CurrencyToLabel";
            this.CurrencyToLabel.Size = new System.Drawing.Size(94, 20);
            this.CurrencyToLabel.TabIndex = 22;
            this.CurrencyToLabel.Text = "Currecny To";
            // 
            // ExchangeRatesDataLabel
            // 
            this.ExchangeRatesDataLabel.AutoSize = true;
            this.ExchangeRatesDataLabel.Location = new System.Drawing.Point(717, 40);
            this.ExchangeRatesDataLabel.Name = "ExchangeRatesDataLabel";
            this.ExchangeRatesDataLabel.Size = new System.Drawing.Size(166, 20);
            this.ExchangeRatesDataLabel.TabIndex = 21;
            this.ExchangeRatesDataLabel.Text = "Exchange Rates Data";
            // 
            // RateLabel2
            // 
            this.RateLabel2.AutoSize = true;
            this.RateLabel2.Location = new System.Drawing.Point(37, 207);
            this.RateLabel2.Name = "RateLabel2";
            this.RateLabel2.Size = new System.Drawing.Size(44, 20);
            this.RateLabel2.TabIndex = 19;
            this.RateLabel2.Text = "Rate";
            // 
            // CurrencyFromLabel
            // 
            this.CurrencyFromLabel.AutoSize = true;
            this.CurrencyFromLabel.Location = new System.Drawing.Point(37, 101);
            this.CurrencyFromLabel.Name = "CurrencyFromLabel";
            this.CurrencyFromLabel.Size = new System.Drawing.Size(113, 20);
            this.CurrencyFromLabel.TabIndex = 18;
            this.CurrencyFromLabel.Text = "Currency From";
            // 
            // ValidityDateLabel2
            // 
            this.ValidityDateLabel2.AutoSize = true;
            this.ValidityDateLabel2.Location = new System.Drawing.Point(37, 46);
            this.ValidityDateLabel2.Name = "ValidityDateLabel2";
            this.ValidityDateLabel2.Size = new System.Drawing.Size(94, 20);
            this.ValidityDateLabel2.TabIndex = 17;
            this.ValidityDateLabel2.Text = "ValidityDate";
            // 
            // ExchangeRatesDataGridView
            // 
            this.ExchangeRatesDataGridView.AllowUserToOrderColumns = true;
            this.ExchangeRatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExchangeRatesDataGridView.Location = new System.Drawing.Point(495, 99);
            this.ExchangeRatesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExchangeRatesDataGridView.MultiSelect = false;
            this.ExchangeRatesDataGridView.Name = "ExchangeRatesDataGridView";
            this.ExchangeRatesDataGridView.RowHeadersWidth = 62;
            this.ExchangeRatesDataGridView.RowTemplate.Height = 33;
            this.ExchangeRatesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExchangeRatesDataGridView.Size = new System.Drawing.Size(539, 451);
            this.ExchangeRatesDataGridView.TabIndex = 16;
            this.ExchangeRatesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExchangeRatesDataGridView_CellClick);
            // 
            // CurrencyFromTextBox
            // 
            this.CurrencyFromTextBox.Location = new System.Drawing.Point(192, 101);
            this.CurrencyFromTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrencyFromTextBox.Name = "CurrencyFromTextBox";
            this.CurrencyFromTextBox.Size = new System.Drawing.Size(266, 26);
            this.CurrencyFromTextBox.TabIndex = 15;
            // 
            // ValidityDateTextBox2
            // 
            this.ValidityDateTextBox2.Location = new System.Drawing.Point(192, 43);
            this.ValidityDateTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValidityDateTextBox2.Name = "ValidityDateTextBox2";
            this.ValidityDateTextBox2.Size = new System.Drawing.Size(266, 26);
            this.ValidityDateTextBox2.TabIndex = 14;
            // 
            // ExchangeRatesButton
            // 
            this.ExchangeRatesButton.Location = new System.Drawing.Point(177, 306);
            this.ExchangeRatesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExchangeRatesButton.Name = "ExchangeRatesButton";
            this.ExchangeRatesButton.Size = new System.Drawing.Size(207, 34);
            this.ExchangeRatesButton.TabIndex = 13;
            this.ExchangeRatesButton.Text = "Save";
            this.ExchangeRatesButton.UseVisualStyleBackColor = true;
            this.ExchangeRatesButton.Click += new System.EventHandler(this.ExchangeRatesButton_Click);
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.Controls.Add(this.AddNewOperationButton);
            this.OperationsPanel.Controls.Add(this.textBox3);
            this.OperationsPanel.Controls.Add(this.CurrencyFromTextBox2);
            this.OperationsPanel.Controls.Add(this.CurrencyToLabel2);
            this.OperationsPanel.Controls.Add(this.CurrencyFromLabel2);
            this.OperationsPanel.Controls.Add(this.AmountTextBox);
            this.OperationsPanel.Controls.Add(this.OperationDateTextBox);
            this.OperationsPanel.Controls.Add(this.OperationDateLabel);
            this.OperationsPanel.Controls.Add(this.OperationsDataLabel);
            this.OperationsPanel.Controls.Add(this.AmountLabel);
            this.OperationsPanel.Controls.Add(this.UserIdLabel);
            this.OperationsPanel.Controls.Add(this.label5);
            this.OperationsPanel.Controls.Add(this.OperationsDataGridView);
            this.OperationsPanel.Controls.Add(this.UserIdTextBox);
            this.OperationsPanel.Controls.Add(this.OperationTypeTextBox);
            this.OperationsPanel.Controls.Add(this.SaveOperationButton);
            this.OperationsPanel.Location = new System.Drawing.Point(48, 122);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(1571, 864);
            this.OperationsPanel.TabIndex = 25;
            // 
            // AddNewOperationButton
            // 
            this.AddNewOperationButton.Location = new System.Drawing.Point(89, 461);
            this.AddNewOperationButton.Size = new System.Drawing.Size(207, 34);
            this.AddNewOperationButton.Name = "AddNewOperationButton";
            this.AddNewOperationButton.TabIndex = 33;
            this.AddNewOperationButton.Text = "Add";
            this.AddNewOperationButton.UseVisualStyleBackColor = true;
            this.AddNewOperationButton.Click += new System.EventHandler(this.AddNewOperationButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(189, 326);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(266, 26);
            this.textBox3.TabIndex = 28;
            // 
            // CurrencyFromTextBox2
            // 
            this.CurrencyFromTextBox2.Location = new System.Drawing.Point(189, 267);
            this.CurrencyFromTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrencyFromTextBox2.Name = "CurrencyFromTextBox2";
            this.CurrencyFromTextBox2.Size = new System.Drawing.Size(266, 26);
            this.CurrencyFromTextBox2.TabIndex = 27;
            // 
            // CurrencyToLabel2
            // 
            this.CurrencyToLabel2.AutoSize = true;
            this.CurrencyToLabel2.Location = new System.Drawing.Point(10, 326);
            this.CurrencyToLabel2.Name = "CurrencyToLabel2";
            this.CurrencyToLabel2.Size = new System.Drawing.Size(94, 20);
            this.CurrencyToLabel2.TabIndex = 26;
            this.CurrencyToLabel2.Text = "Currency To";
            // 
            // CurrencyFromLabel2
            // 
            this.CurrencyFromLabel2.AutoSize = true;
            this.CurrencyFromLabel2.Location = new System.Drawing.Point(10, 267);
            this.CurrencyFromLabel2.Name = "CurrencyFromLabel2";
            this.CurrencyFromLabel2.Size = new System.Drawing.Size(113, 20);
            this.CurrencyFromLabel2.TabIndex = 25;
            this.CurrencyFromLabel2.Text = "Currency From";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(189, 208);
            this.AmountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(266, 26);
            this.AmountTextBox.TabIndex = 24;
            // 
            // OperationDateTextBox
            // 
            this.OperationDateTextBox.Location = new System.Drawing.Point(192, 153);
            this.OperationDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OperationDateTextBox.Name = "OperationDateTextBox";
            this.OperationDateTextBox.Size = new System.Drawing.Size(266, 26);
            this.OperationDateTextBox.TabIndex = 23;
            // 
            // OperationDateLabel
            // 
            this.OperationDateLabel.AutoSize = true;
            this.OperationDateLabel.Location = new System.Drawing.Point(10, 153);
            this.OperationDateLabel.Name = "OperationDateLabel";
            this.OperationDateLabel.Size = new System.Drawing.Size(114, 20);
            this.OperationDateLabel.TabIndex = 22;
            this.OperationDateLabel.Text = "OperationDate";
            // 
            // OperationsDataLabel
            // 
            this.OperationsDataLabel.AutoSize = true;
            this.OperationsDataLabel.Location = new System.Drawing.Point(717, 40);
            this.OperationsDataLabel.Name = "OperationsDataLabel";
            this.OperationsDataLabel.Size = new System.Drawing.Size(126, 20);
            this.OperationsDataLabel.TabIndex = 21;
            this.OperationsDataLabel.Text = "Operations Data";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(10, 214);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(65, 20);
            this.AmountLabel.TabIndex = 19;
            this.AmountLabel.Text = "Amount";
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(10, 96);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(61, 20);
            this.UserIdLabel.TabIndex = 18;
            this.UserIdLabel.Text = "User Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Operation Type";
            // 
            // OperationsDataGridView
            // 
            this.OperationsDataGridView.AllowUserToOrderColumns = true;
            this.OperationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperationsDataGridView.Location = new System.Drawing.Point(495, 99);
            this.OperationsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OperationsDataGridView.MultiSelect = false;
            this.OperationsDataGridView.Name = "OperationsDataGridView";
            this.OperationsDataGridView.RowHeadersWidth = 62;
            this.OperationsDataGridView.RowTemplate.Height = 33;
            this.OperationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OperationsDataGridView.Size = new System.Drawing.Size(539, 451);
            this.OperationsDataGridView.TabIndex = 16;
            this.OperationsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OperationsDataGridView_CellClick);
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(192, 101);
            this.UserIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(266, 26);
            this.UserIdTextBox.TabIndex = 15;
            // 
            // OperationTypeTextBox
            // 
            this.OperationTypeTextBox.Location = new System.Drawing.Point(192, 43);
            this.OperationTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OperationTypeTextBox.Name = "OperationTypeTextBox";
            this.OperationTypeTextBox.Size = new System.Drawing.Size(266, 26);
            this.OperationTypeTextBox.TabIndex = 14;
            // 
            // SaveOperationButton
            // 
            this.SaveOperationButton.Location = new System.Drawing.Point(89, 411);
            this.SaveOperationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveOperationButton.Name = "SaveOperationButton";
            this.SaveOperationButton.Size = new System.Drawing.Size(207, 34);
            this.SaveOperationButton.TabIndex = 13;
            this.SaveOperationButton.Text = "Save";
            this.SaveOperationButton.UseVisualStyleBackColor = true;
            this.SaveOperationButton.Click += new System.EventHandler(this.SaveOperationButton_Click);
            // 
            // CLS_OperationTypePanel
            // 
            this.CLS_OperationTypePanel.Controls.Add(this.AddNewOperationTypeButton);
            this.CLS_OperationTypePanel.Controls.Add(this.checkBox1);
            this.CLS_OperationTypePanel.Controls.Add(this.label1);
            this.CLS_OperationTypePanel.Controls.Add(this.CLS_OperationTypeLabel);
            this.CLS_OperationTypePanel.Controls.Add(this.NameLabel3);
            this.CLS_OperationTypePanel.Controls.Add(this.CodeLabel2);
            this.CLS_OperationTypePanel.Controls.Add(this.CLS_OperationTypeDataGridView);
            this.CLS_OperationTypePanel.Controls.Add(this.NameTextBox3);
            this.CLS_OperationTypePanel.Controls.Add(this.CodeTextBox2);
            this.CLS_OperationTypePanel.Controls.Add(this.VLS_OperationTypeButton);
            this.CLS_OperationTypePanel.Location = new System.Drawing.Point(48, 122);
            this.CLS_OperationTypePanel.Name = "CLS_OperationTypePanel";
            this.CLS_OperationTypePanel.Size = new System.Drawing.Size(1047, 576);
            this.CLS_OperationTypePanel.TabIndex = 30;
            // 
            // AddNewOperationTypeButton
            // 
            this.AddNewOperationTypeButton.Location = new System.Drawing.Point(77, 291);
            this.AddNewOperationTypeButton.Name = "AddNewOperationTypeButton";
            this.AddNewOperationTypeButton.Size = new System.Drawing.Size(207, 34);
            this.AddNewOperationTypeButton.TabIndex = 32;
            this.AddNewOperationTypeButton.Text = "Add";
            this.AddNewOperationTypeButton.UseVisualStyleBackColor = true;
            this.AddNewOperationTypeButton.Click += new System.EventHandler(this.AddNewOperationTypeButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(192, 150);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 24);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Activate";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Activate User";
            // 
            // CLS_OperationTypeLabel
            // 
            this.CLS_OperationTypeLabel.AutoSize = true;
            this.CLS_OperationTypeLabel.Location = new System.Drawing.Point(717, 40);
            this.CLS_OperationTypeLabel.Name = "CLS_OperationTypeLabel";
            this.CLS_OperationTypeLabel.Size = new System.Drawing.Size(192, 20);
            this.CLS_OperationTypeLabel.TabIndex = 21;
            this.CLS_OperationTypeLabel.Text = "CLS_OperationType Data";
            // 
            // NameLabel3
            // 
            this.NameLabel3.AutoSize = true;
            this.NameLabel3.Location = new System.Drawing.Point(10, 96);
            this.NameLabel3.Name = "NameLabel3";
            this.NameLabel3.Size = new System.Drawing.Size(51, 20);
            this.NameLabel3.TabIndex = 18;
            this.NameLabel3.Text = "Name";
            // 
            // CodeLabel2
            // 
            this.CodeLabel2.AutoSize = true;
            this.CodeLabel2.Location = new System.Drawing.Point(10, 43);
            this.CodeLabel2.Name = "CodeLabel2";
            this.CodeLabel2.Size = new System.Drawing.Size(47, 20);
            this.CodeLabel2.TabIndex = 17;
            this.CodeLabel2.Text = "Code";
            // 
            // CLS_OperationTypeDataGridView
            // 
            this.CLS_OperationTypeDataGridView.AllowUserToOrderColumns = true;
            this.CLS_OperationTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLS_OperationTypeDataGridView.Location = new System.Drawing.Point(495, 99);
            this.CLS_OperationTypeDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CLS_OperationTypeDataGridView.MultiSelect = false;
            this.CLS_OperationTypeDataGridView.Name = "CLS_OperationTypeDataGridView";
            this.CLS_OperationTypeDataGridView.RowHeadersWidth = 62;
            this.CLS_OperationTypeDataGridView.RowTemplate.Height = 33;
            this.CLS_OperationTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CLS_OperationTypeDataGridView.Size = new System.Drawing.Size(539, 451);
            this.CLS_OperationTypeDataGridView.TabIndex = 16;
            this.CLS_OperationTypeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CLS_OperationTypeDataGridView_CellClick);
            // 
            // NameTextBox3
            // 
            this.NameTextBox3.Location = new System.Drawing.Point(192, 101);
            this.NameTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox3.Name = "NameTextBox3";
            this.NameTextBox3.Size = new System.Drawing.Size(266, 26);
            this.NameTextBox3.TabIndex = 15;
            // 
            // CodeTextBox2
            // 
            this.CodeTextBox2.Location = new System.Drawing.Point(192, 43);
            this.CodeTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodeTextBox2.Name = "CodeTextBox2";
            this.CodeTextBox2.Size = new System.Drawing.Size(266, 26);
            this.CodeTextBox2.TabIndex = 14;
            // 
            // VLS_OperationTypeButton
            // 
            this.VLS_OperationTypeButton.Location = new System.Drawing.Point(77, 241);
            this.VLS_OperationTypeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VLS_OperationTypeButton.Name = "VLS_OperationTypeButton";
            this.VLS_OperationTypeButton.Size = new System.Drawing.Size(207, 34);
            this.VLS_OperationTypeButton.TabIndex = 13;
            this.VLS_OperationTypeButton.Text = "Save";
            this.VLS_OperationTypeButton.UseVisualStyleBackColor = true;
            this.VLS_OperationTypeButton.Click += new System.EventHandler(this.VLS_OperationTypeButton_Click);
            // 
            // CLS_CurrencyPanel
            // 
            this.CLS_CurrencyPanel.Controls.Add(this.AddNewCLS_CurrencyButton);
            this.CLS_CurrencyPanel.Controls.Add(this.ActivateUserCheckBox4);
            this.CLS_CurrencyPanel.Controls.Add(this.ActivateUserLabel4);
            this.CLS_CurrencyPanel.Controls.Add(this.CLS_CurrencyLabel);
            this.CLS_CurrencyPanel.Controls.Add(this.NameLabel2);
            this.CLS_CurrencyPanel.Controls.Add(this.CodeLabel);
            this.CLS_CurrencyPanel.Controls.Add(this.CLS_CurrencyDataGridView);
            this.CLS_CurrencyPanel.Controls.Add(this.NameTextBox2);
            this.CLS_CurrencyPanel.Controls.Add(this.CodeTextBox);
            this.CLS_CurrencyPanel.Controls.Add(this.CLS_CurrentButton);
            this.CLS_CurrencyPanel.Location = new System.Drawing.Point(48, 122);
            this.CLS_CurrencyPanel.Name = "CLS_CurrencyPanel";
            this.CLS_CurrencyPanel.Size = new System.Drawing.Size(1047, 576);
            this.CLS_CurrencyPanel.TabIndex = 29;
            // 
            // AddNewCLS_CurrencyButton
            // 
            this.AddNewCLS_CurrencyButton.Location = new System.Drawing.Point(77, 291);
            this.AddNewCLS_CurrencyButton.Size = new System.Drawing.Size(207, 34);
            this.AddNewCLS_CurrencyButton.Name = "AddNewCLS_CurrencyButton";
            this.AddNewCLS_CurrencyButton.TabIndex = 31;
            this.AddNewCLS_CurrencyButton.Text = "Add";
            this.AddNewCLS_CurrencyButton.UseVisualStyleBackColor = true;
            this.AddNewCLS_CurrencyButton.Click += new System.EventHandler(this.AddNewCLS_CurrencyButton_Click);
            // 
            // ActivateUserCheckBox4
            // 
            this.ActivateUserCheckBox4.AutoSize = true;
            this.ActivateUserCheckBox4.Location = new System.Drawing.Point(192, 150);
            this.ActivateUserCheckBox4.Name = "ActivateUserCheckBox4";
            this.ActivateUserCheckBox4.Size = new System.Drawing.Size(92, 24);
            this.ActivateUserCheckBox4.TabIndex = 23;
            this.ActivateUserCheckBox4.Text = "Activate";
            this.ActivateUserCheckBox4.UseVisualStyleBackColor = true;
            // 
            // ActivateUserLabel4
            // 
            this.ActivateUserLabel4.AutoSize = true;
            this.ActivateUserLabel4.Location = new System.Drawing.Point(10, 159);
            this.ActivateUserLabel4.Name = "ActivateUserLabel4";
            this.ActivateUserLabel4.Size = new System.Drawing.Size(104, 20);
            this.ActivateUserLabel4.TabIndex = 22;
            this.ActivateUserLabel4.Text = "Activate User";
            // 
            // CLS_CurrencyLabel
            // 
            this.CLS_CurrencyLabel.AutoSize = true;
            this.CLS_CurrencyLabel.Location = new System.Drawing.Point(717, 40);
            this.CLS_CurrencyLabel.Name = "CLS_CurrencyLabel";
            this.CLS_CurrencyLabel.Size = new System.Drawing.Size(151, 20);
            this.CLS_CurrencyLabel.TabIndex = 21;
            this.CLS_CurrencyLabel.Text = "CLS_Currency Data";
            // 
            // NameLabel2
            // 
            this.NameLabel2.AutoSize = true;
            this.NameLabel2.Location = new System.Drawing.Point(10, 96);
            this.NameLabel2.Name = "NameLabel2";
            this.NameLabel2.Size = new System.Drawing.Size(51, 20);
            this.NameLabel2.TabIndex = 18;
            this.NameLabel2.Text = "Name";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(10, 43);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(47, 20);
            this.CodeLabel.TabIndex = 17;
            this.CodeLabel.Text = "Code";
            // 
            // CLS_CurrencyDataGridView
            // 
            this.CLS_CurrencyDataGridView.AllowUserToOrderColumns = true;
            this.CLS_CurrencyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLS_CurrencyDataGridView.Location = new System.Drawing.Point(495, 99);
            this.CLS_CurrencyDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CLS_CurrencyDataGridView.MultiSelect = false;
            this.CLS_CurrencyDataGridView.Name = "CLS_CurrencyDataGridView";
            this.CLS_CurrencyDataGridView.RowHeadersWidth = 62;
            this.CLS_CurrencyDataGridView.RowTemplate.Height = 33;
            this.CLS_CurrencyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CLS_CurrencyDataGridView.Size = new System.Drawing.Size(539, 451);
            this.CLS_CurrencyDataGridView.TabIndex = 16;
            this.CLS_CurrencyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CLS_CurrencyDataGridView_CellClick);
            // 
            // NameTextBox2
            // 
            this.NameTextBox2.Location = new System.Drawing.Point(192, 101);
            this.NameTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox2.Name = "NameTextBox2";
            this.NameTextBox2.Size = new System.Drawing.Size(266, 26);
            this.NameTextBox2.TabIndex = 15;
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(192, 43);
            this.CodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(266, 26);
            this.CodeTextBox.TabIndex = 14;
            // 
            // CLS_CurrentButton
            // 
            this.CLS_CurrentButton.Location = new System.Drawing.Point(77, 241);
            this.CLS_CurrentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CLS_CurrentButton.Name = "CLS_CurrentButton";
            this.CLS_CurrentButton.Size = new System.Drawing.Size(207, 34);
            this.CLS_CurrentButton.TabIndex = 13;
            this.CLS_CurrentButton.Text = "Save";
            this.CLS_CurrentButton.UseVisualStyleBackColor = true;
            this.CLS_CurrentButton.Click += new System.EventHandler(this.CLS_CurrentButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.OfficialRatesPanel);
            this.Controls.Add(this.CLS_OperationTypePanel);
            this.Controls.Add(this.CLS_CurrencyPanel);
            this.Controls.Add(this.ExchangeRatesPanel);
            this.Controls.Add(this.UsersPanel);
            this.Controls.Add(this.OperationsPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.UsersPanel.ResumeLayout(false);
            this.UsersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.OfficialRatesPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfficialRatedataGridView)).EndInit();
            this.ExchangeRatesPanel.ResumeLayout(false);
            this.ExchangeRatesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesDataGridView)).EndInit();
            this.OperationsPanel.ResumeLayout(false);
            this.OperationsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsDataGridView)).EndInit();
            this.CLS_OperationTypePanel.ResumeLayout(false);
            this.CLS_OperationTypePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLS_OperationTypeDataGridView)).EndInit();
            this.CLS_CurrencyPanel.ResumeLayout(false);
            this.CLS_CurrencyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLS_CurrencyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officialRatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exchangeRatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLSCurrencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLSOperationTypeToolStripMenuItem;
        private System.Windows.Forms.Panel UsersPanel;
        private System.Windows.Forms.Label UsersDataLabel;
        private System.Windows.Forms.CheckBox CheckBoxForUserActivation;
        private System.Windows.Forms.Label UserActivationLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.Button SaveUserButton;
        private System.Windows.Forms.Panel OfficialRatesPanel;
        private System.Windows.Forms.Label OfficialRatesDatalabel;
        private System.Windows.Forms.Label Currencylabel;
        private System.Windows.Forms.Label ValidityDatalabel;
        private System.Windows.Forms.DataGridView OfficialRatedataGridView;
        private System.Windows.Forms.TextBox CurrencyTextBox;
        private System.Windows.Forms.TextBox ValidityDateTextBox;
        private System.Windows.Forms.Button SaveOfficialRate;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.Label Ratelabel;
        private System.Windows.Forms.Label UserActivationLabel2;
        private System.Windows.Forms.CheckBox UserActivationcheckBox2;
        private System.Windows.Forms.Panel ExchangeRatesPanel;
        private System.Windows.Forms.TextBox RateTextBox2;
        private System.Windows.Forms.TextBox CurrencyToTextBox;
        private System.Windows.Forms.Label CurrencyToLabel;
        private System.Windows.Forms.Label ExchangeRatesDataLabel;
        private System.Windows.Forms.Label RateLabel2;
        private System.Windows.Forms.Label CurrencyFromLabel;
        private System.Windows.Forms.Label ValidityDateLabel2;
        private System.Windows.Forms.DataGridView ExchangeRatesDataGridView;
        private System.Windows.Forms.TextBox CurrencyFromTextBox;
        private System.Windows.Forms.TextBox ValidityDateTextBox2;
        private System.Windows.Forms.Button ExchangeRatesButton;
        private System.Windows.Forms.Panel OperationsPanel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox OperationDateTextBox;
        private System.Windows.Forms.Label OperationDateLabel;
        private System.Windows.Forms.Label OperationsDataLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView OperationsDataGridView;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.TextBox OperationTypeTextBox;
        private System.Windows.Forms.Button SaveOperationButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox CurrencyFromTextBox2;
        private System.Windows.Forms.Label CurrencyToLabel2;
        private System.Windows.Forms.Label CurrencyFromLabel2;
        private System.Windows.Forms.Panel CLS_CurrencyPanel;
        private System.Windows.Forms.CheckBox ActivateUserCheckBox4;
        private System.Windows.Forms.Label ActivateUserLabel4;
        private System.Windows.Forms.Label CLS_CurrencyLabel;
        private System.Windows.Forms.Label NameLabel2;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.DataGridView CLS_CurrencyDataGridView;
        private System.Windows.Forms.TextBox NameTextBox2;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Button CLS_CurrentButton;
        private System.Windows.Forms.CheckBox ActivateUserCheckBox3;
        private System.Windows.Forms.Label ActivateUserLabel3;
        private System.Windows.Forms.Panel CLS_OperationTypePanel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CLS_OperationTypeLabel;
        private System.Windows.Forms.Label NameLabel3;
        private System.Windows.Forms.Label CodeLabel2;
        private System.Windows.Forms.DataGridView CLS_OperationTypeDataGridView;
        private System.Windows.Forms.TextBox NameTextBox3;
        private System.Windows.Forms.TextBox CodeTextBox2;
        private System.Windows.Forms.Button VLS_OperationTypeButton;
        private Button AddNewUSer;
        private Button AddNewOfficialRateButton;
        private Button AddNewOperationTypeButton;
        private Button AddNewCLS_CurrencyButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AddNewExchangeRateButton;
        private Button AddNewOperationButton;
    }
}