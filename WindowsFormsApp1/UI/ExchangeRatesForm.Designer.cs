using System.Drawing;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeRatesForm));
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchCurrencyFromComboBox = new System.Windows.Forms.ComboBox();
            this.SearchExchangeRateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchCurrrencyToComboBox = new System.Windows.Forms.ComboBox();
            this.RefreshDataButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DownloadExchangeRatesButton = new System.Windows.Forms.Button();
            this.WebServiceButton = new System.Windows.Forms.Button();
            this.NBRMDataGridView = new System.Windows.Forms.DataGridView();
            this.CurrencyToComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyFromComboBox = new System.Windows.Forms.ComboBox();
            this.ExchangeRatesCurrencyFromErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ExchangeRatesCurrencyToErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ExchangeRatesRateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CurrencyFromSearchErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CurrencyToSearchErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesDataGridView)).BeginInit();
            this.ExchangeRatesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBRMDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesCurrencyFromErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesCurrencyToErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRatesRateErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyFromSearchErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyToSearchErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveExchangeRatesButton
            // 
            this.SaveExchangeRatesButton.Location = new System.Drawing.Point(228, 318);
            this.SaveExchangeRatesButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveExchangeRatesButton.Name = "SaveExchangeRatesButton";
            this.SaveExchangeRatesButton.Size = new System.Drawing.Size(138, 30);
            this.SaveExchangeRatesButton.TabIndex = 13;
            this.SaveExchangeRatesButton.Text = "Save";
            this.SaveExchangeRatesButton.UseVisualStyleBackColor = true;
            this.SaveExchangeRatesButton.Click += new System.EventHandler(this.SaveExchangeRatesButton_Click);
            // 
            // ExchangeRatesDataGridView
            // 
            this.ExchangeRatesDataGridView.AllowUserToOrderColumns = true;
            this.ExchangeRatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExchangeRatesDataGridView.Location = new System.Drawing.Point(446, 102);
            this.ExchangeRatesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ExchangeRatesDataGridView.MultiSelect = false;
            this.ExchangeRatesDataGridView.Name = "ExchangeRatesDataGridView";
            this.ExchangeRatesDataGridView.RowHeadersWidth = 62;
            this.ExchangeRatesDataGridView.RowTemplate.Height = 33;
            this.ExchangeRatesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExchangeRatesDataGridView.Size = new System.Drawing.Size(453, 388);
            this.ExchangeRatesDataGridView.TabIndex = 16;
            this.ExchangeRatesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExchangeRatesDataGridView_CellClick);
            // 
            // ValidityDateLabel2
            // 
            this.ValidityDateLabel2.AutoSize = true;
            this.ValidityDateLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidityDateLabel2.Location = new System.Drawing.Point(52, 143);
            this.ValidityDateLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValidityDateLabel2.Name = "ValidityDateLabel2";
            this.ValidityDateLabel2.Size = new System.Drawing.Size(116, 25);
            this.ValidityDateLabel2.TabIndex = 17;
            this.ValidityDateLabel2.Text = "ValidityDate";
            // 
            // CurrencyFromLabel
            // 
            this.CurrencyFromLabel.AutoSize = true;
            this.CurrencyFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyFromLabel.Location = new System.Drawing.Point(53, 179);
            this.CurrencyFromLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrencyFromLabel.Name = "CurrencyFromLabel";
            this.CurrencyFromLabel.Size = new System.Drawing.Size(142, 25);
            this.CurrencyFromLabel.TabIndex = 18;
            this.CurrencyFromLabel.Text = "Currency From";
            // 
            // RateLabel2
            // 
            this.RateLabel2.AutoSize = true;
            this.RateLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateLabel2.Location = new System.Drawing.Point(52, 248);
            this.RateLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RateLabel2.Name = "RateLabel2";
            this.RateLabel2.Size = new System.Drawing.Size(52, 25);
            this.RateLabel2.TabIndex = 19;
            this.RateLabel2.Text = "Rate";
            // 
            // ExchangeRatesDataLabel
            // 
            this.ExchangeRatesDataLabel.AutoSize = true;
            this.ExchangeRatesDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeRatesDataLabel.Location = new System.Drawing.Point(550, 32);
            this.ExchangeRatesDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExchangeRatesDataLabel.Name = "ExchangeRatesDataLabel";
            this.ExchangeRatesDataLabel.Size = new System.Drawing.Size(243, 26);
            this.ExchangeRatesDataLabel.TabIndex = 21;
            this.ExchangeRatesDataLabel.Text = "Exchange Rates Data";
            // 
            // CurrencyToLabel
            // 
            this.CurrencyToLabel.AutoSize = true;
            this.CurrencyToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyToLabel.Location = new System.Drawing.Point(53, 214);
            this.CurrencyToLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrencyToLabel.Name = "CurrencyToLabel";
            this.CurrencyToLabel.Size = new System.Drawing.Size(121, 25);
            this.CurrencyToLabel.TabIndex = 22;
            this.CurrencyToLabel.Text = "Currency To";
            // 
            // RateTextBox2
            // 
            this.RateTextBox2.Location = new System.Drawing.Point(210, 248);
            this.RateTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.RateTextBox2.Name = "RateTextBox2";
            this.RateTextBox2.Size = new System.Drawing.Size(180, 20);
            this.RateTextBox2.TabIndex = 24;
            // 
            // ActivateUserLabel3
            // 
            this.ActivateUserLabel3.AutoSize = true;
            this.ActivateUserLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateUserLabel3.Location = new System.Drawing.Point(53, 280);
            this.ActivateUserLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActivateUserLabel3.Name = "ActivateUserLabel3";
            this.ActivateUserLabel3.Size = new System.Drawing.Size(142, 25);
            this.ActivateUserLabel3.TabIndex = 26;
            this.ActivateUserLabel3.Text = "Rate Activation";
            // 
            // ActivateUserCheckBox3
            // 
            this.ActivateUserCheckBox3.AutoSize = true;
            this.ActivateUserCheckBox3.Location = new System.Drawing.Point(210, 280);
            this.ActivateUserCheckBox3.Margin = new System.Windows.Forms.Padding(2);
            this.ActivateUserCheckBox3.Name = "ActivateUserCheckBox3";
            this.ActivateUserCheckBox3.Size = new System.Drawing.Size(65, 17);
            this.ActivateUserCheckBox3.TabIndex = 27;
            this.ActivateUserCheckBox3.Text = "Activate";
            this.ActivateUserCheckBox3.UseVisualStyleBackColor = true;
            // 
            // AddNewExchangeRateButton
            // 
            this.AddNewExchangeRateButton.Location = new System.Drawing.Point(228, 368);
            this.AddNewExchangeRateButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddNewExchangeRateButton.Name = "AddNewExchangeRateButton";
            this.AddNewExchangeRateButton.Size = new System.Drawing.Size(138, 29);
            this.AddNewExchangeRateButton.TabIndex = 32;
            this.AddNewExchangeRateButton.Text = "Add";
            this.AddNewExchangeRateButton.UseVisualStyleBackColor = true;
            this.AddNewExchangeRateButton.Click += new System.EventHandler(this.AddNewExchangeRateButton_Click);
            // 
            // ExchangeRatesdateTimePicker
            // 
            this.ExchangeRatesdateTimePicker.Enabled = false;
            this.ExchangeRatesdateTimePicker.Location = new System.Drawing.Point(210, 143);
            this.ExchangeRatesdateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ExchangeRatesdateTimePicker.Name = "ExchangeRatesdateTimePicker";
            this.ExchangeRatesdateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.ExchangeRatesdateTimePicker.TabIndex = 33;
            // 
            // ExchangeRatesPanel
            // 
            this.ExchangeRatesPanel.Controls.Add(this.label5);
            this.ExchangeRatesPanel.Controls.Add(this.label4);
            this.ExchangeRatesPanel.Controls.Add(this.SearchCurrencyFromComboBox);
            this.ExchangeRatesPanel.Controls.Add(this.SearchExchangeRateButton);
            this.ExchangeRatesPanel.Controls.Add(this.label3);
            this.ExchangeRatesPanel.Controls.Add(this.SearchCurrrencyToComboBox);
            this.ExchangeRatesPanel.Controls.Add(this.RefreshDataButton);
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
            this.ExchangeRatesPanel.Location = new System.Drawing.Point(16, 20);
            this.ExchangeRatesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ExchangeRatesPanel.Name = "ExchangeRatesPanel";
            this.ExchangeRatesPanel.Size = new System.Drawing.Size(1403, 657);
            this.ExchangeRatesPanel.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(873, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Currency To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Currency From";
            // 
            // SearchCurrencyFromComboBox
            // 
            this.SearchCurrencyFromComboBox.FormattingEnabled = true;
            this.SearchCurrencyFromComboBox.Location = new System.Drawing.Point(702, 618);
            this.SearchCurrencyFromComboBox.Name = "SearchCurrencyFromComboBox";
            this.SearchCurrencyFromComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchCurrencyFromComboBox.TabIndex = 46;
            // 
            // SearchExchangeRateButton
            // 
            this.SearchExchangeRateButton.Location = new System.Drawing.Point(1016, 618);
            this.SearchExchangeRateButton.Name = "SearchExchangeRateButton";
            this.SearchExchangeRateButton.Size = new System.Drawing.Size(117, 23);
            this.SearchExchangeRateButton.TabIndex = 44;
            this.SearchExchangeRateButton.Text = "Search";
            this.SearchExchangeRateButton.UseVisualStyleBackColor = true;
            this.SearchExchangeRateButton.Click += new System.EventHandler(this.SearchExchangeRateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(797, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Search Exchange Rate";
            // 
            // SearchCurrrencyToComboBox
            // 
            this.SearchCurrrencyToComboBox.FormattingEnabled = true;
            this.SearchCurrrencyToComboBox.Location = new System.Drawing.Point(848, 618);
            this.SearchCurrrencyToComboBox.Name = "SearchCurrrencyToComboBox";
            this.SearchCurrrencyToComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchCurrrencyToComboBox.TabIndex = 42;
            // 
            // RefreshDataButton
            // 
            this.RefreshDataButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RefreshDataButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.RefreshDataButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RefreshDataButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshDataButton.Image")));
            this.RefreshDataButton.Location = new System.Drawing.Point(446, 68);
            this.RefreshDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshDataButton.Name = "RefreshDataButton";
            this.RefreshDataButton.Size = new System.Drawing.Size(40, 31);
            this.RefreshDataButton.TabIndex = 41;
            this.RefreshDataButton.UseVisualStyleBackColor = false;
            this.RefreshDataButton.Click += new System.EventHandler(this.RefreshDataButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(956, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Exchange Rates Live Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "Exchange Rates Infromation";
            // 
            // DownloadExchangeRatesButton
            // 
            this.DownloadExchangeRatesButton.Location = new System.Drawing.Point(583, 508);
            this.DownloadExchangeRatesButton.Margin = new System.Windows.Forms.Padding(2);
            this.DownloadExchangeRatesButton.Name = "DownloadExchangeRatesButton";
            this.DownloadExchangeRatesButton.Size = new System.Drawing.Size(146, 28);
            this.DownloadExchangeRatesButton.TabIndex = 38;
            this.DownloadExchangeRatesButton.Text = "DOWNLOAD DATA";
            this.DownloadExchangeRatesButton.UseVisualStyleBackColor = true;
            this.DownloadExchangeRatesButton.Click += new System.EventHandler(this.DownloadExchangeRatesButton_Click);
            // 
            // WebServiceButton
            // 
            this.WebServiceButton.Location = new System.Drawing.Point(1084, 508);
            this.WebServiceButton.Margin = new System.Windows.Forms.Padding(2);
            this.WebServiceButton.Name = "WebServiceButton";
            this.WebServiceButton.Size = new System.Drawing.Size(141, 28);
            this.WebServiceButton.TabIndex = 37;
            this.WebServiceButton.Text = "VIEW NBRM DATA";
            this.WebServiceButton.UseVisualStyleBackColor = true;
            this.WebServiceButton.Click += new System.EventHandler(this.WebServiceButton_Click);
            // 
            // NBRMDataGridView
            // 
            this.NBRMDataGridView.AllowUserToOrderColumns = true;
            this.NBRMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NBRMDataGridView.Location = new System.Drawing.Point(924, 102);
            this.NBRMDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.NBRMDataGridView.MultiSelect = false;
            this.NBRMDataGridView.Name = "NBRMDataGridView";
            this.NBRMDataGridView.RowHeadersWidth = 62;
            this.NBRMDataGridView.RowTemplate.Height = 33;
            this.NBRMDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NBRMDataGridView.Size = new System.Drawing.Size(458, 388);
            this.NBRMDataGridView.TabIndex = 36;
            // 
            // CurrencyToComboBox
            // 
            this.CurrencyToComboBox.FormattingEnabled = true;
            this.CurrencyToComboBox.Location = new System.Drawing.Point(210, 214);
            this.CurrencyToComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CurrencyToComboBox.Name = "CurrencyToComboBox";
            this.CurrencyToComboBox.Size = new System.Drawing.Size(180, 21);
            this.CurrencyToComboBox.TabIndex = 35;
            // 
            // CurrencyFromComboBox
            // 
            this.CurrencyFromComboBox.FormattingEnabled = true;
            this.CurrencyFromComboBox.Location = new System.Drawing.Point(210, 179);
            this.CurrencyFromComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CurrencyFromComboBox.Name = "CurrencyFromComboBox";
            this.CurrencyFromComboBox.Size = new System.Drawing.Size(180, 21);
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
            // CurrencyFromSearchErrorProvider
            // 
            this.CurrencyFromSearchErrorProvider.ContainerControl = this;
            // 
            // CurrencyToSearchErrorProvider
            // 
            this.CurrencyToSearchErrorProvider.ContainerControl = this;
            // 
            // ExchangeRatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1448, 688);
            this.Controls.Add(this.ExchangeRatesPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyFromSearchErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyToSearchErrorProvider)).EndInit();
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
        private System.Windows.Forms.Button RefreshDataButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SearchCurrrencyToComboBox;
        private System.Windows.Forms.Button SearchExchangeRateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SearchCurrencyFromComboBox;
        private System.Windows.Forms.ErrorProvider CurrencyFromSearchErrorProvider;
        private System.Windows.Forms.ErrorProvider CurrencyToSearchErrorProvider;
    }
}