﻿namespace WindowsFormsApp1.UI
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
            this.DownloadExchangeRatesButton = new System.Windows.Forms.Button();
            this.WebServiceButton = new System.Windows.Forms.Button();
            this.NBRMDataGridView = new System.Windows.Forms.DataGridView();
            this.CurrencyToComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyFromComboBox = new System.Windows.Forms.ComboBox();
            this.ExchangeRatesCurrencyFromErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ExchangeRatesCurrencyToErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ExchangeRatesRateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesDataGridView)).BeginInit();
            this.ExchangeRatesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBRMDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesCurrencyFromErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesCurrencyToErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesRateErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveExchangeRatesButton
            // 
            this.SaveExchangeRatesButton.Location = new System.Drawing.Point(236, 434);
            this.SaveExchangeRatesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveExchangeRatesButton.Name = "SaveExchangeRatesButton";
            this.SaveExchangeRatesButton.Size = new System.Drawing.Size(207, 39);
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
            this.ValidityDateLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidityDateLabel2.Location = new System.Drawing.Point(26, 158);
            this.ValidityDateLabel2.Name = "ValidityDateLabel2";
            this.ValidityDateLabel2.Size = new System.Drawing.Size(140, 29);
            this.ValidityDateLabel2.TabIndex = 17;
            this.ValidityDateLabel2.Text = "ValidityDate";
            // 
            // CurrencyFromLabel
            // 
            this.CurrencyFromLabel.AutoSize = true;
            this.CurrencyFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyFromLabel.Location = new System.Drawing.Point(27, 212);
            this.CurrencyFromLabel.Name = "CurrencyFromLabel";
            this.CurrencyFromLabel.Size = new System.Drawing.Size(172, 29);
            this.CurrencyFromLabel.TabIndex = 18;
            this.CurrencyFromLabel.Text = "Currency From";
            // 
            // RateLabel2
            // 
            this.RateLabel2.AutoSize = true;
            this.RateLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateLabel2.Location = new System.Drawing.Point(26, 319);
            this.RateLabel2.Name = "RateLabel2";
            this.RateLabel2.Size = new System.Drawing.Size(63, 29);
            this.RateLabel2.TabIndex = 19;
            this.RateLabel2.Text = "Rate";
            // 
            // ExchangeRatesDataLabel
            // 
            this.ExchangeRatesDataLabel.AutoSize = true;
            this.ExchangeRatesDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeRatesDataLabel.Location = new System.Drawing.Point(651, 46);
            this.ExchangeRatesDataLabel.Name = "ExchangeRatesDataLabel";
            this.ExchangeRatesDataLabel.Size = new System.Drawing.Size(261, 29);
            this.ExchangeRatesDataLabel.TabIndex = 21;
            this.ExchangeRatesDataLabel.Text = "Exchange Rates Data";
            // 
            // CurrencyToLabel
            // 
            this.CurrencyToLabel.AutoSize = true;
            this.CurrencyToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyToLabel.Location = new System.Drawing.Point(27, 267);
            this.CurrencyToLabel.Name = "CurrencyToLabel";
            this.CurrencyToLabel.Size = new System.Drawing.Size(145, 29);
            this.CurrencyToLabel.TabIndex = 22;
            this.CurrencyToLabel.Text = "Currecny To";
            // 
            // RateTextBox2
            // 
            this.RateTextBox2.Location = new System.Drawing.Point(209, 319);
            this.RateTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RateTextBox2.Name = "RateTextBox2";
            this.RateTextBox2.Size = new System.Drawing.Size(268, 26);
            this.RateTextBox2.TabIndex = 24;
            // 
            // ActivateUserLabel3
            // 
            this.ActivateUserLabel3.AutoSize = true;
            this.ActivateUserLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateUserLabel3.Location = new System.Drawing.Point(27, 368);
            this.ActivateUserLabel3.Name = "ActivateUserLabel3";
            this.ActivateUserLabel3.Size = new System.Drawing.Size(153, 29);
            this.ActivateUserLabel3.TabIndex = 26;
            this.ActivateUserLabel3.Text = "Activate User";
            // 
            // ActivateUserCheckBox3
            // 
            this.ActivateUserCheckBox3.AutoSize = true;
            this.ActivateUserCheckBox3.Location = new System.Drawing.Point(209, 374);
            this.ActivateUserCheckBox3.Name = "ActivateUserCheckBox3";
            this.ActivateUserCheckBox3.Size = new System.Drawing.Size(92, 24);
            this.ActivateUserCheckBox3.TabIndex = 27;
            this.ActivateUserCheckBox3.Text = "Activate";
            this.ActivateUserCheckBox3.UseVisualStyleBackColor = true;
            // 
            // AddNewExchangeRateButton
            // 
            this.AddNewExchangeRateButton.Location = new System.Drawing.Point(236, 484);
            this.AddNewExchangeRateButton.Name = "AddNewExchangeRateButton";
            this.AddNewExchangeRateButton.Size = new System.Drawing.Size(207, 39);
            this.AddNewExchangeRateButton.TabIndex = 32;
            this.AddNewExchangeRateButton.Text = "Add";
            this.AddNewExchangeRateButton.UseVisualStyleBackColor = true;
            this.AddNewExchangeRateButton.Click += new System.EventHandler(this.AddNewExchangeRateButton_Click);
            // 
            // ExchangeRatesdateTimePicker
            // 
            this.ExchangeRatesdateTimePicker.Location = new System.Drawing.Point(209, 158);
            this.ExchangeRatesdateTimePicker.Name = "ExchangeRatesdateTimePicker";
            this.ExchangeRatesdateTimePicker.Size = new System.Drawing.Size(268, 26);
            this.ExchangeRatesdateTimePicker.TabIndex = 33;
            // 
            // ExchangeRatesPanel
            // 
            this.ExchangeRatesPanel.Controls.Add(this.label2);
            this.ExchangeRatesPanel.Controls.Add(this.label1);
            this.ExchangeRatesPanel.Controls.Add(this.DownloadExchangeRatesButton);
            this.ExchangeRatesPanel.Controls.Add(this.WebServiceButton);
            this.ExchangeRatesPanel.Controls.Add(this.NBRMDataGridView);
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
            this.ExchangeRatesPanel.Size = new System.Drawing.Size(1796, 803);
            this.ExchangeRatesPanel.TabIndex = 25;
            // 
            // DownloadExchangeRatesButton
            // 
            this.DownloadExchangeRatesButton.Location = new System.Drawing.Point(670, 588);
            this.DownloadExchangeRatesButton.Name = "DownloadExchangeRatesButton";
            this.DownloadExchangeRatesButton.Size = new System.Drawing.Size(213, 36);
            this.DownloadExchangeRatesButton.TabIndex = 38;
            this.DownloadExchangeRatesButton.Text = "DOWNLOAD DATA";
            this.DownloadExchangeRatesButton.UseVisualStyleBackColor = true;
            this.DownloadExchangeRatesButton.Click += new System.EventHandler(this.DownloadExchangeRatesButton_Click);
            // 
            // WebServiceButton
            // 
            this.WebServiceButton.Location = new System.Drawing.Point(1315, 588);
            this.WebServiceButton.Name = "WebServiceButton";
            this.WebServiceButton.Size = new System.Drawing.Size(207, 36);
            this.WebServiceButton.TabIndex = 37;
            this.WebServiceButton.Text = "VIEW NBRM DATA";
            this.WebServiceButton.UseVisualStyleBackColor = true;
            this.WebServiceButton.Click += new System.EventHandler(this.WebServiceButton_Click);
            // 
            // NBRMDataGridView
            // 
            this.NBRMDataGridView.AllowUserToOrderColumns = true;
            this.NBRMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NBRMDataGridView.Location = new System.Drawing.Point(1056, 99);
            this.NBRMDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NBRMDataGridView.MultiSelect = false;
            this.NBRMDataGridView.Name = "NBRMDataGridView";
            this.NBRMDataGridView.RowHeadersWidth = 62;
            this.NBRMDataGridView.RowTemplate.Height = 33;
            this.NBRMDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NBRMDataGridView.Size = new System.Drawing.Size(687, 451);
            this.NBRMDataGridView.TabIndex = 36;
            // 
            // CurrencyToComboBox
            // 
            this.CurrencyToComboBox.FormattingEnabled = true;
            this.CurrencyToComboBox.Location = new System.Drawing.Point(209, 267);
            this.CurrencyToComboBox.Name = "CurrencyToComboBox";
            this.CurrencyToComboBox.Size = new System.Drawing.Size(268, 28);
            this.CurrencyToComboBox.TabIndex = 35;
            // 
            // CurrencyFromComboBox
            // 
            this.CurrencyFromComboBox.FormattingEnabled = true;
            this.CurrencyFromComboBox.Location = new System.Drawing.Point(209, 212);
            this.CurrencyFromComboBox.Name = "CurrencyFromComboBox";
            this.CurrencyFromComboBox.Size = new System.Drawing.Size(268, 28);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Exchange Rates Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1259, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Exchange Rates Data";
            // 
            // ExchangeRatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1901, 881);
            this.Controls.Add(this.ExchangeRatesPanel);
            this.Name = "ExchangeRatesForm";
            this.Text = "ExchangeRatesForm";
            this.Load += new System.EventHandler(this.ExchangeRatesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesDataGridView)).EndInit();
            this.ExchangeRatesPanel.ResumeLayout(false);
            this.ExchangeRatesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBRMDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView NBRMDataGridView;
        private System.Windows.Forms.Button WebServiceButton;
        private System.Windows.Forms.Button DownloadExchangeRatesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}