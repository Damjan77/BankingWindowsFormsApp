namespace WindowsFormsApp1.UI
{
    partial class OfficialRatesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficialRatesForm));
            this.OfficialRatesPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NBRMDataButton = new System.Windows.Forms.Button();
            this.OfficialRatesCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.officialRateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ValidityDatalabel = new System.Windows.Forms.Label();
            this.OfficialRatedataGridView = new System.Windows.Forms.DataGridView();
            this.OfficialRatesDatalabel = new System.Windows.Forms.Label();
            this.AddNewOfficialRateButton = new System.Windows.Forms.Button();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.UserActivationcheckBox2 = new System.Windows.Forms.CheckBox();
            this.SaveOfficialRate = new System.Windows.Forms.Button();
            this.Currencylabel = new System.Windows.Forms.Label();
            this.UserActivationLabel2 = new System.Windows.Forms.Label();
            this.Ratelabel = new System.Windows.Forms.Label();
            this.ViewOfficialRatesNBRMDataGridView = new System.Windows.Forms.DataGridView();
            this.viewOfficialRatesNBRM = new System.Windows.Forms.Button();
            this.officialRateCurrencyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.officialRateRateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RefreshDataButton = new System.Windows.Forms.Button();
            this.OfficialRatesPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfficialRatedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOfficialRatesNBRMDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officialRateCurrencyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officialRateRateErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // OfficialRatesPanel
            // 
            this.OfficialRatesPanel.Controls.Add(this.tableLayoutPanel1);
            this.OfficialRatesPanel.Location = new System.Drawing.Point(38, 24);
            this.OfficialRatesPanel.Name = "OfficialRatesPanel";
            this.OfficialRatesPanel.Size = new System.Drawing.Size(1629, 830);
            this.OfficialRatesPanel.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 554F));
            this.tableLayoutPanel1.Controls.Add(this.RefreshDataButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.NBRMDataButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.OfficialRatesCurrencyComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.officialRateDateTimePicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ValidityDatalabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OfficialRatedataGridView, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.OfficialRatesDatalabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddNewOfficialRateButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.RateTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UserActivationcheckBox2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SaveOfficialRate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Currencylabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserActivationLabel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Ratelabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ViewOfficialRatesNBRMDataGridView, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.viewOfficialRatesNBRM, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1557, 670);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // NBRMDataButton
            // 
            this.NBRMDataButton.Location = new System.Drawing.Point(387, 43);
            this.NBRMDataButton.Name = "NBRMDataButton";
            this.NBRMDataButton.Size = new System.Drawing.Size(194, 34);
            this.NBRMDataButton.TabIndex = 24;
            this.NBRMDataButton.Text = "Download Officials";
            this.NBRMDataButton.UseVisualStyleBackColor = true;
            this.NBRMDataButton.Click += new System.EventHandler(this.NBRMDataButton_Click);
            // 
            // OfficialRatesCurrencyComboBox
            // 
            this.OfficialRatesCurrencyComboBox.FormattingEnabled = true;
            this.OfficialRatesCurrencyComboBox.Location = new System.Drawing.Point(177, 43);
            this.OfficialRatesCurrencyComboBox.Name = "OfficialRatesCurrencyComboBox";
            this.OfficialRatesCurrencyComboBox.Size = new System.Drawing.Size(194, 28);
            this.OfficialRatesCurrencyComboBox.TabIndex = 24;
            // 
            // officialRateDateTimePicker
            // 
            this.officialRateDateTimePicker.Location = new System.Drawing.Point(177, 3);
            this.officialRateDateTimePicker.Name = "officialRateDateTimePicker";
            this.officialRateDateTimePicker.Size = new System.Drawing.Size(194, 26);
            this.officialRateDateTimePicker.TabIndex = 35;
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
            this.OfficialRatedataGridView.Location = new System.Drawing.Point(387, 182);
            this.OfficialRatedataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OfficialRatedataGridView.MultiSelect = false;
            this.OfficialRatedataGridView.Name = "OfficialRatedataGridView";
            this.OfficialRatedataGridView.RowHeadersWidth = 62;
            this.OfficialRatedataGridView.RowTemplate.Height = 33;
            this.OfficialRatedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OfficialRatedataGridView.Size = new System.Drawing.Size(613, 460);
            this.OfficialRatedataGridView.TabIndex = 16;
            this.OfficialRatedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OfficialRatedataGridView_CellClick);
            // 
            // OfficialRatesDatalabel
            // 
            this.OfficialRatesDatalabel.AutoSize = true;
            this.OfficialRatesDatalabel.Location = new System.Drawing.Point(387, 0);
            this.OfficialRatesDatalabel.Name = "OfficialRatesDatalabel";
            this.OfficialRatesDatalabel.Size = new System.Drawing.Size(143, 20);
            this.OfficialRatesDatalabel.TabIndex = 21;
            this.OfficialRatesDatalabel.Text = "Official Rates Data";
            // 
            // AddNewOfficialRateButton
            // 
            this.AddNewOfficialRateButton.Location = new System.Drawing.Point(3, 183);
            this.AddNewOfficialRateButton.Name = "AddNewOfficialRateButton";
            this.AddNewOfficialRateButton.Size = new System.Drawing.Size(150, 30);
            this.AddNewOfficialRateButton.TabIndex = 33;
            this.AddNewOfficialRateButton.Text = "Add";
            this.AddNewOfficialRateButton.UseVisualStyleBackColor = true;
            this.AddNewOfficialRateButton.Click += new System.EventHandler(this.AddNewOfficialRateButton_Click);
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(177, 82);
            this.RateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(194, 26);
            this.RateTextBox.TabIndex = 23;
            // 
            // UserActivationcheckBox2
            // 
            this.UserActivationcheckBox2.AutoSize = true;
            this.UserActivationcheckBox2.Location = new System.Drawing.Point(177, 126);
            this.UserActivationcheckBox2.Name = "UserActivationcheckBox2";
            this.UserActivationcheckBox2.Size = new System.Drawing.Size(147, 24);
            this.UserActivationcheckBox2.TabIndex = 20;
            this.UserActivationcheckBox2.Text = "Click to Activate";
            this.UserActivationcheckBox2.UseVisualStyleBackColor = true;
            // 
            // SaveOfficialRate
            // 
            this.SaveOfficialRate.Location = new System.Drawing.Point(177, 182);
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
            this.UserActivationLabel2.Location = new System.Drawing.Point(3, 123);
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
            // ViewOfficialRatesNBRMDataGridView
            // 
            this.ViewOfficialRatesNBRMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOfficialRatesNBRMDataGridView.Location = new System.Drawing.Point(1006, 183);
            this.ViewOfficialRatesNBRMDataGridView.Name = "ViewOfficialRatesNBRMDataGridView";
            this.ViewOfficialRatesNBRMDataGridView.RowHeadersWidth = 62;
            this.ViewOfficialRatesNBRMDataGridView.RowTemplate.Height = 28;
            this.ViewOfficialRatesNBRMDataGridView.Size = new System.Drawing.Size(548, 459);
            this.ViewOfficialRatesNBRMDataGridView.TabIndex = 36;
            // 
            // viewOfficialRatesNBRM
            // 
            this.viewOfficialRatesNBRM.Location = new System.Drawing.Point(1006, 83);
            this.viewOfficialRatesNBRM.Name = "viewOfficialRatesNBRM";
            this.viewOfficialRatesNBRM.Size = new System.Drawing.Size(148, 37);
            this.viewOfficialRatesNBRM.TabIndex = 37;
            this.viewOfficialRatesNBRM.Text = "View Officials";
            this.viewOfficialRatesNBRM.UseVisualStyleBackColor = true;
            this.viewOfficialRatesNBRM.Click += new System.EventHandler(this.viewOfficialRatesNBRM_Click);
            // 
            // officialRateCurrencyErrorProvider
            // 
            this.officialRateCurrencyErrorProvider.ContainerControl = this;
            // 
            // officialRateRateErrorProvider
            // 
            this.officialRateRateErrorProvider.ContainerControl = this;
            // 
            // RefreshDataButton
            // 
            this.RefreshDataButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RefreshDataButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.RefreshDataButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RefreshDataButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshDataButton.Image")));
            this.RefreshDataButton.Location = new System.Drawing.Point(387, 126);
            this.RefreshDataButton.Name = "RefreshDataButton";
            this.RefreshDataButton.Size = new System.Drawing.Size(68, 43);
            this.RefreshDataButton.TabIndex = 42;
            this.RefreshDataButton.UseVisualStyleBackColor = false;
            this.RefreshDataButton.Click += new System.EventHandler(this.RefreshDataButton_Click_1);
            // 
            // OfficialRatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(2063, 1029);
            this.Controls.Add(this.OfficialRatesPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OfficialRatesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OfficialRatesForm";
            this.Load += new System.EventHandler(this.OfficialRatesForm_Load);
            this.OfficialRatesPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfficialRatedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOfficialRatesNBRMDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officialRateCurrencyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officialRateRateErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OfficialRatesPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ValidityDatalabel;
        private System.Windows.Forms.DataGridView OfficialRatedataGridView;
        private System.Windows.Forms.Label OfficialRatesDatalabel;
        private System.Windows.Forms.Button AddNewOfficialRateButton;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.CheckBox UserActivationcheckBox2;
        private System.Windows.Forms.Button SaveOfficialRate;
        private System.Windows.Forms.Label Currencylabel;
        private System.Windows.Forms.Label UserActivationLabel2;
        private System.Windows.Forms.Label Ratelabel;
        private System.Windows.Forms.ErrorProvider officialRateCurrencyErrorProvider;
        private System.Windows.Forms.DateTimePicker officialRateDateTimePicker;
        private System.Windows.Forms.ErrorProvider officialRateRateErrorProvider;
        private System.Windows.Forms.ComboBox OfficialRatesCurrencyComboBox;
        private System.Windows.Forms.Button NBRMDataButton;
        private System.Windows.Forms.DataGridView ViewOfficialRatesNBRMDataGridView;
        private System.Windows.Forms.Button viewOfficialRatesNBRM;
        private System.Windows.Forms.Button RefreshDataButton;
    }
}