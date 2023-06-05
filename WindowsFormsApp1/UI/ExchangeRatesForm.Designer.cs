namespace WindowsFormsApp1.UI
{
    partial class ExchangeRatesForm
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
            this.SaveExchangeRatesButton = new System.Windows.Forms.Button();
            this.ExchangeRatesDataGridView = new System.Windows.Forms.DataGridView();
            this.ValidityDateLabel2 = new System.Windows.Forms.Label();
            this.CurrencyFromLabel = new System.Windows.Forms.Label();
            this.RateLabel2 = new System.Windows.Forms.Label();
            this.ExchangeRatesDataLabel = new System.Windows.Forms.Label();
            this.CurrencyToLabel = new System.Windows.Forms.Label();
            this.RateTextBox2 = new System.Windows.Forms.TextBox();
            this.ActivateUserLabel3 = new System.Windows.Forms.Label();
            this.ActivateUserCheckBox3 = new System.Windows.Forms.CheckBox();
            this.AddNewExchangeRateButton = new System.Windows.Forms.Button();
            this.ExchangeRatesdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExchangeRatesPanel = new System.Windows.Forms.Panel();
            this.CurrencyToComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyFromComboBox = new System.Windows.Forms.ComboBox();
            this.ExchangeRatesCurrencyFromErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ExchangeRatesCurrencyToErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ExchangeRatesRateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesDataGridView)).BeginInit();
            this.ExchangeRatesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesCurrencyFromErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesCurrencyToErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesRateErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveExchangeRatesButton
            // 
            this.SaveExchangeRatesButton.Location = new System.Drawing.Point(177, 306);
            this.SaveExchangeRatesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveExchangeRatesButton.Name = "SaveExchangeRatesButton";
            this.SaveExchangeRatesButton.Size = new System.Drawing.Size(207, 34);
            this.SaveExchangeRatesButton.TabIndex = 13;
            this.SaveExchangeRatesButton.Text = "Save";
            this.SaveExchangeRatesButton.UseVisualStyleBackColor = true;
            this.SaveExchangeRatesButton.Click += new System.EventHandler(this.SaveExchangeRatesButton_Click);
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
            // ValidityDateLabel2
            // 
            this.ValidityDateLabel2.AutoSize = true;
            this.ValidityDateLabel2.Location = new System.Drawing.Point(37, 46);
            this.ValidityDateLabel2.Name = "ValidityDateLabel2";
            this.ValidityDateLabel2.Size = new System.Drawing.Size(94, 20);
            this.ValidityDateLabel2.TabIndex = 17;
            this.ValidityDateLabel2.Text = "ValidityDate";
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
            // RateLabel2
            // 
            this.RateLabel2.AutoSize = true;
            this.RateLabel2.Location = new System.Drawing.Point(37, 207);
            this.RateLabel2.Name = "RateLabel2";
            this.RateLabel2.Size = new System.Drawing.Size(44, 20);
            this.RateLabel2.TabIndex = 19;
            this.RateLabel2.Text = "Rate";
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
            // CurrencyToLabel
            // 
            this.CurrencyToLabel.AutoSize = true;
            this.CurrencyToLabel.Location = new System.Drawing.Point(37, 156);
            this.CurrencyToLabel.Name = "CurrencyToLabel";
            this.CurrencyToLabel.Size = new System.Drawing.Size(94, 20);
            this.CurrencyToLabel.TabIndex = 22;
            this.CurrencyToLabel.Text = "Currecny To";
            // 
            // RateTextBox2
            // 
            this.RateTextBox2.Location = new System.Drawing.Point(189, 208);
            this.RateTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RateTextBox2.Name = "RateTextBox2";
            this.RateTextBox2.Size = new System.Drawing.Size(269, 26);
            this.RateTextBox2.TabIndex = 24;
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
            // AddNewExchangeRateButton
            // 
            this.AddNewExchangeRateButton.Location = new System.Drawing.Point(177, 356);
            this.AddNewExchangeRateButton.Name = "AddNewExchangeRateButton";
            this.AddNewExchangeRateButton.Size = new System.Drawing.Size(207, 34);
            this.AddNewExchangeRateButton.TabIndex = 32;
            this.AddNewExchangeRateButton.Text = "Add";
            this.AddNewExchangeRateButton.UseVisualStyleBackColor = true;
            this.AddNewExchangeRateButton.Click += new System.EventHandler(this.AddNewExchangeRateButton_Click);
            // 
            // ExchangeRatesdateTimePicker
            // 
            this.ExchangeRatesdateTimePicker.Location = new System.Drawing.Point(189, 46);
            this.ExchangeRatesdateTimePicker.Name = "ExchangeRatesdateTimePicker";
            this.ExchangeRatesdateTimePicker.Size = new System.Drawing.Size(269, 26);
            this.ExchangeRatesdateTimePicker.TabIndex = 33;
            // 
            // ExchangeRatesPanel
            // 
            this.ExchangeRatesPanel.Controls.Add(this.CurrencyToComboBox);
            this.ExchangeRatesPanel.Controls.Add(this.CurrencyFromComboBox);
            this.ExchangeRatesPanel.Controls.Add(this.ExchangeRatesdateTimePicker);
            this.ExchangeRatesPanel.Controls.Add(this.AddNewExchangeRateButton);
            this.ExchangeRatesPanel.Controls.Add(this.ActivateUserCheckBox3);
            this.ExchangeRatesPanel.Controls.Add(this.ActivateUserLabel3);
            this.ExchangeRatesPanel.Controls.Add(this.RateTextBox2);
            this.ExchangeRatesPanel.Controls.Add(this.CurrencyToLabel);
            this.ExchangeRatesPanel.Controls.Add(this.ExchangeRatesDataLabel);
            this.ExchangeRatesPanel.Controls.Add(this.RateLabel2);
            this.ExchangeRatesPanel.Controls.Add(this.CurrencyFromLabel);
            this.ExchangeRatesPanel.Controls.Add(this.ValidityDateLabel2);
            this.ExchangeRatesPanel.Controls.Add(this.ExchangeRatesDataGridView);
            this.ExchangeRatesPanel.Controls.Add(this.SaveExchangeRatesButton);
            this.ExchangeRatesPanel.Location = new System.Drawing.Point(24, 30);
            this.ExchangeRatesPanel.Name = "ExchangeRatesPanel";
            this.ExchangeRatesPanel.Size = new System.Drawing.Size(1101, 596);
            this.ExchangeRatesPanel.TabIndex = 25;
            // 
            // CurrencyToComboBox
            // 
            this.CurrencyToComboBox.FormattingEnabled = true;
            this.CurrencyToComboBox.Location = new System.Drawing.Point(189, 156);
            this.CurrencyToComboBox.Name = "CurrencyToComboBox";
            this.CurrencyToComboBox.Size = new System.Drawing.Size(269, 28);
            this.CurrencyToComboBox.TabIndex = 35;
            // 
            // CurrencyFromComboBox
            // 
            this.CurrencyFromComboBox.FormattingEnabled = true;
            this.CurrencyFromComboBox.Location = new System.Drawing.Point(189, 99);
            this.CurrencyFromComboBox.Name = "CurrencyFromComboBox";
            this.CurrencyFromComboBox.Size = new System.Drawing.Size(269, 28);
            this.CurrencyFromComboBox.TabIndex = 34;
            // 
            // ExchangeRatesCurrencyFromErrorProvider
            // 
            this.ExchangeRatesCurrencyFromErrorProvider.ContainerControl = this;
            // 
            // ExchangeRatesCurrencyToErrorProvider
            // 
            this.ExchangeRatesCurrencyToErrorProvider.ContainerControl = this;
            // 
            // ExchangeRatesRateErrorProvider
            // 
            this.ExchangeRatesRateErrorProvider.ContainerControl = this;
            // 
            // ExchangeRatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 664);
            this.Controls.Add(this.ExchangeRatesPanel);
            this.Name = "ExchangeRatesForm";
            this.Text = "ExchangeRatesForm";
            this.Load += new System.EventHandler(this.ExchangeRatesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesDataGridView)).EndInit();
            this.ExchangeRatesPanel.ResumeLayout(false);
            this.ExchangeRatesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesCurrencyFromErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesCurrencyToErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesRateErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveExchangeRatesButton;
        private System.Windows.Forms.DataGridView ExchangeRatesDataGridView;
        private System.Windows.Forms.Label ValidityDateLabel2;
        private System.Windows.Forms.Label CurrencyFromLabel;
        private System.Windows.Forms.Label RateLabel2;
        private System.Windows.Forms.Label ExchangeRatesDataLabel;
        private System.Windows.Forms.Label CurrencyToLabel;
        private System.Windows.Forms.TextBox RateTextBox2;
        private System.Windows.Forms.Label ActivateUserLabel3;
        private System.Windows.Forms.CheckBox ActivateUserCheckBox3;
        private System.Windows.Forms.Button AddNewExchangeRateButton;
        private System.Windows.Forms.DateTimePicker ExchangeRatesdateTimePicker;
        private System.Windows.Forms.Panel ExchangeRatesPanel;
        private System.Windows.Forms.ErrorProvider ExchangeRatesCurrencyFromErrorProvider;
        private System.Windows.Forms.ErrorProvider ExchangeRatesCurrencyToErrorProvider;
        private System.Windows.Forms.ErrorProvider ExchangeRatesRateErrorProvider;
        private System.Windows.Forms.ComboBox CurrencyToComboBox;
        private System.Windows.Forms.ComboBox CurrencyFromComboBox;
    }
}