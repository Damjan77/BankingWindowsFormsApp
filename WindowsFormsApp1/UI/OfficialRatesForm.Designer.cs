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
            this.label1 = new System.Windows.Forms.Label();
            this.viewOfficialRatesNBRM = new System.Windows.Forms.Button();
            this.ViewOfficialRatesNBRMDataGridView = new System.Windows.Forms.DataGridView();
            this.Ratelabel = new System.Windows.Forms.Label();
            this.UserActivationLabel2 = new System.Windows.Forms.Label();
            this.Currencylabel = new System.Windows.Forms.Label();
            this.SaveOfficialRate = new System.Windows.Forms.Button();
            this.UserActivationcheckBox2 = new System.Windows.Forms.CheckBox();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.AddNewOfficialRateButton = new System.Windows.Forms.Button();
            this.OfficialRatesDatalabel = new System.Windows.Forms.Label();
            this.OfficialRatedataGridView = new System.Windows.Forms.DataGridView();
            this.ValidityDatalabel = new System.Windows.Forms.Label();
            this.officialRateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OfficialRatesCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.NBRMDataButton = new System.Windows.Forms.Button();
            this.RefreshDataButton = new System.Windows.Forms.Button();
            this.officialRateCurrencyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.officialRateRateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OfficialRatesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOfficialRatesNBRMDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficialRatedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officialRateCurrencyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officialRateRateErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // OfficialRatesPanel
            // 
            this.OfficialRatesPanel.Controls.Add(this.label1);
            this.OfficialRatesPanel.Controls.Add(this.viewOfficialRatesNBRM);
            this.OfficialRatesPanel.Controls.Add(this.ViewOfficialRatesNBRMDataGridView);
            this.OfficialRatesPanel.Controls.Add(this.Ratelabel);
            this.OfficialRatesPanel.Controls.Add(this.UserActivationLabel2);
            this.OfficialRatesPanel.Controls.Add(this.Currencylabel);
            this.OfficialRatesPanel.Controls.Add(this.SaveOfficialRate);
            this.OfficialRatesPanel.Controls.Add(this.UserActivationcheckBox2);
            this.OfficialRatesPanel.Controls.Add(this.RateTextBox);
            this.OfficialRatesPanel.Controls.Add(this.AddNewOfficialRateButton);
            this.OfficialRatesPanel.Controls.Add(this.OfficialRatesDatalabel);
            this.OfficialRatesPanel.Controls.Add(this.OfficialRatedataGridView);
            this.OfficialRatesPanel.Controls.Add(this.ValidityDatalabel);
            this.OfficialRatesPanel.Controls.Add(this.officialRateDateTimePicker);
            this.OfficialRatesPanel.Controls.Add(this.OfficialRatesCurrencyComboBox);
            this.OfficialRatesPanel.Controls.Add(this.NBRMDataButton);
            this.OfficialRatesPanel.Controls.Add(this.RefreshDataButton);
            this.OfficialRatesPanel.Location = new System.Drawing.Point(33, 14);
            this.OfficialRatesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OfficialRatesPanel.Name = "OfficialRatesPanel";
            this.OfficialRatesPanel.Size = new System.Drawing.Size(2036, 838);
            this.OfficialRatesPanel.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(996, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 31);
            this.label1.TabIndex = 43;
            this.label1.Text = "Welcome to Official Rates";
            // 
            // viewOfficialRatesNBRM
            // 
            this.viewOfficialRatesNBRM.Location = new System.Drawing.Point(1490, 156);
            this.viewOfficialRatesNBRM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewOfficialRatesNBRM.Name = "viewOfficialRatesNBRM";
            this.viewOfficialRatesNBRM.Size = new System.Drawing.Size(141, 32);
            this.viewOfficialRatesNBRM.TabIndex = 37;
            this.viewOfficialRatesNBRM.Text = "View Officials";
            this.viewOfficialRatesNBRM.UseVisualStyleBackColor = true;
            this.viewOfficialRatesNBRM.Click += new System.EventHandler(this.viewOfficialRatesNBRM_Click);
            // 
            // ViewOfficialRatesNBRMDataGridView
            // 
            this.ViewOfficialRatesNBRMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOfficialRatesNBRMDataGridView.Location = new System.Drawing.Point(1197, 204);
            this.ViewOfficialRatesNBRMDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewOfficialRatesNBRMDataGridView.Name = "ViewOfficialRatesNBRMDataGridView";
            this.ViewOfficialRatesNBRMDataGridView.RowHeadersWidth = 62;
            this.ViewOfficialRatesNBRMDataGridView.RowTemplate.Height = 28;
            this.ViewOfficialRatesNBRMDataGridView.Size = new System.Drawing.Size(712, 506);
            this.ViewOfficialRatesNBRMDataGridView.TabIndex = 36;
            // 
            // Ratelabel
            // 
            this.Ratelabel.AutoSize = true;
            this.Ratelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratelabel.Location = new System.Drawing.Point(43, 314);
            this.Ratelabel.Name = "Ratelabel";
            this.Ratelabel.Size = new System.Drawing.Size(63, 29);
            this.Ratelabel.TabIndex = 22;
            this.Ratelabel.Text = "Rate";
            // 
            // UserActivationLabel2
            // 
            this.UserActivationLabel2.AutoSize = true;
            this.UserActivationLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserActivationLabel2.Location = new System.Drawing.Point(43, 357);
            this.UserActivationLabel2.Name = "UserActivationLabel2";
            this.UserActivationLabel2.Size = new System.Drawing.Size(171, 29);
            this.UserActivationLabel2.TabIndex = 19;
            this.UserActivationLabel2.Text = "Rate Activation";
            // 
            // Currencylabel
            // 
            this.Currencylabel.AutoSize = true;
            this.Currencylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currencylabel.Location = new System.Drawing.Point(43, 271);
            this.Currencylabel.Name = "Currencylabel";
            this.Currencylabel.Size = new System.Drawing.Size(109, 29);
            this.Currencylabel.TabIndex = 18;
            this.Currencylabel.Text = "Currency";
            // 
            // SaveOfficialRate
            // 
            this.SaveOfficialRate.Location = new System.Drawing.Point(176, 447);
            this.SaveOfficialRate.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.SaveOfficialRate.Name = "SaveOfficialRate";
            this.SaveOfficialRate.Size = new System.Drawing.Size(175, 34);
            this.SaveOfficialRate.TabIndex = 13;
            this.SaveOfficialRate.Text = "Save";
            this.SaveOfficialRate.UseVisualStyleBackColor = true;
            this.SaveOfficialRate.Click += new System.EventHandler(this.SaveOfficialRate_Click);
            // 
            // UserActivationcheckBox2
            // 
            this.UserActivationcheckBox2.AutoSize = true;
            this.UserActivationcheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserActivationcheckBox2.Location = new System.Drawing.Point(240, 361);
            this.UserActivationcheckBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserActivationcheckBox2.Name = "UserActivationcheckBox2";
            this.UserActivationcheckBox2.Size = new System.Drawing.Size(162, 28);
            this.UserActivationcheckBox2.TabIndex = 20;
            this.UserActivationcheckBox2.Text = "Click to Activate";
            this.UserActivationcheckBox2.UseVisualStyleBackColor = true;
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(240, 314);
            this.RateTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(225, 22);
            this.RateTextBox.TabIndex = 23;
            // 
            // AddNewOfficialRateButton
            // 
            this.AddNewOfficialRateButton.Location = new System.Drawing.Point(176, 503);
            this.AddNewOfficialRateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddNewOfficialRateButton.Name = "AddNewOfficialRateButton";
            this.AddNewOfficialRateButton.Size = new System.Drawing.Size(175, 32);
            this.AddNewOfficialRateButton.TabIndex = 33;
            this.AddNewOfficialRateButton.Text = "Add";
            this.AddNewOfficialRateButton.UseVisualStyleBackColor = true;
            this.AddNewOfficialRateButton.Click += new System.EventHandler(this.AddNewOfficialRateButton_Click);
            // 
            // OfficialRatesDatalabel
            // 
            this.OfficialRatesDatalabel.AutoSize = true;
            this.OfficialRatesDatalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficialRatesDatalabel.Location = new System.Drawing.Point(109, 138);
            this.OfficialRatesDatalabel.Name = "OfficialRatesDatalabel";
            this.OfficialRatesDatalabel.Size = new System.Drawing.Size(243, 29);
            this.OfficialRatesDatalabel.TabIndex = 21;
            this.OfficialRatesDatalabel.Text = "Official Rates Data";
            // 
            // OfficialRatedataGridView
            // 
            this.OfficialRatedataGridView.AllowUserToOrderColumns = true;
            this.OfficialRatedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OfficialRatedataGridView.Location = new System.Drawing.Point(522, 204);
            this.OfficialRatedataGridView.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.OfficialRatedataGridView.MultiSelect = false;
            this.OfficialRatedataGridView.Name = "OfficialRatedataGridView";
            this.OfficialRatedataGridView.RowHeadersWidth = 62;
            this.OfficialRatedataGridView.RowTemplate.Height = 33;
            this.OfficialRatedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OfficialRatedataGridView.Size = new System.Drawing.Size(653, 506);
            this.OfficialRatedataGridView.TabIndex = 16;
            this.OfficialRatedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OfficialRatedataGridView_CellClick);
            // 
            // ValidityDatalabel
            // 
            this.ValidityDatalabel.AutoSize = true;
            this.ValidityDatalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidityDatalabel.Location = new System.Drawing.Point(43, 225);
            this.ValidityDatalabel.Name = "ValidityDatalabel";
            this.ValidityDatalabel.Size = new System.Drawing.Size(140, 29);
            this.ValidityDatalabel.TabIndex = 17;
            this.ValidityDatalabel.Text = "ValidityDate";
            // 
            // officialRateDateTimePicker
            // 
            this.officialRateDateTimePicker.Enabled = false;
            this.officialRateDateTimePicker.Location = new System.Drawing.Point(240, 225);
            this.officialRateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.officialRateDateTimePicker.Name = "officialRateDateTimePicker";
            this.officialRateDateTimePicker.Size = new System.Drawing.Size(225, 22);
            this.officialRateDateTimePicker.TabIndex = 35;
            // 
            // OfficialRatesCurrencyComboBox
            // 
            this.OfficialRatesCurrencyComboBox.FormattingEnabled = true;
            this.OfficialRatesCurrencyComboBox.Location = new System.Drawing.Point(240, 271);
            this.OfficialRatesCurrencyComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OfficialRatesCurrencyComboBox.Name = "OfficialRatesCurrencyComboBox";
            this.OfficialRatesCurrencyComboBox.Size = new System.Drawing.Size(225, 24);
            this.OfficialRatesCurrencyComboBox.TabIndex = 24;
            // 
            // NBRMDataButton
            // 
            this.NBRMDataButton.Location = new System.Drawing.Point(746, 156);
            this.NBRMDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NBRMDataButton.Name = "NBRMDataButton";
            this.NBRMDataButton.Size = new System.Drawing.Size(148, 32);
            this.NBRMDataButton.TabIndex = 24;
            this.NBRMDataButton.Text = "Download Officials";
            this.NBRMDataButton.UseVisualStyleBackColor = true;
            this.NBRMDataButton.Click += new System.EventHandler(this.NBRMDataButton_Click);
            // 
            // RefreshDataButton
            // 
            this.RefreshDataButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RefreshDataButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.RefreshDataButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RefreshDataButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshDataButton.Image")));
            this.RefreshDataButton.Location = new System.Drawing.Point(522, 156);
            this.RefreshDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshDataButton.Name = "RefreshDataButton";
            this.RefreshDataButton.Size = new System.Drawing.Size(64, 34);
            this.RefreshDataButton.TabIndex = 42;
            this.RefreshDataButton.UseVisualStyleBackColor = false;
            this.RefreshDataButton.Click += new System.EventHandler(this.RefreshDataButton_Click_1);
            // 
            // officialRateCurrencyErrorProvider
            // 
            this.officialRateCurrencyErrorProvider.ContainerControl = this;
            // 
            // officialRateRateErrorProvider
            // 
            this.officialRateRateErrorProvider.ContainerControl = this;
            // 
            // OfficialRatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(2116, 879);
            this.Controls.Add(this.OfficialRatesPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OfficialRatesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OfficialRatesForm";
            this.Load += new System.EventHandler(this.OfficialRatesForm_Load);
            this.OfficialRatesPanel.ResumeLayout(false);
            this.OfficialRatesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOfficialRatesNBRMDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficialRatedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officialRateCurrencyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officialRateRateErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OfficialRatesPanel;
        private System.Windows.Forms.ErrorProvider officialRateCurrencyErrorProvider;
        private System.Windows.Forms.ErrorProvider officialRateRateErrorProvider;
        private System.Windows.Forms.Button viewOfficialRatesNBRM;
        private System.Windows.Forms.DataGridView ViewOfficialRatesNBRMDataGridView;
        private System.Windows.Forms.Label Ratelabel;
        private System.Windows.Forms.Label UserActivationLabel2;
        private System.Windows.Forms.Label Currencylabel;
        private System.Windows.Forms.Button SaveOfficialRate;
        private System.Windows.Forms.CheckBox UserActivationcheckBox2;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.Button AddNewOfficialRateButton;
        private System.Windows.Forms.Label OfficialRatesDatalabel;
        private System.Windows.Forms.DataGridView OfficialRatedataGridView;
        private System.Windows.Forms.Label ValidityDatalabel;
        private System.Windows.Forms.DateTimePicker officialRateDateTimePicker;
        private System.Windows.Forms.ComboBox OfficialRatesCurrencyComboBox;
        private System.Windows.Forms.Button NBRMDataButton;
        private System.Windows.Forms.Button RefreshDataButton;
        private System.Windows.Forms.Label label1;
    }
}