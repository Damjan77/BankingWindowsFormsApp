namespace WindowsFormsApp1.UI
{
    partial class OperationsForm
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
            this.OperationsPanel = new System.Windows.Forms.Panel();
            this.CurrencyToComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyFromComboBox = new System.Windows.Forms.ComboBox();
            this.OperationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.UsersComboBox = new System.Windows.Forms.ComboBox();
            this.OperationsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddNewOperationButton = new System.Windows.Forms.Button();
            this.CurrencyToLabel2 = new System.Windows.Forms.Label();
            this.CurrencyFromLabel2 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.OperationDateLabel = new System.Windows.Forms.Label();
            this.OperationsDataLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OperationsDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveOperationButton = new System.Windows.Forms.Button();
            this.OperationsCurrencyFromErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OperationsCurrencyToErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OperationsAmountErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OperationsOperationTypeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OperationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsCurrencyFromErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsCurrencyToErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsAmountErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsOperationTypeErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.Controls.Add(this.CurrencyToComboBox);
            this.OperationsPanel.Controls.Add(this.CurrencyFromComboBox);
            this.OperationsPanel.Controls.Add(this.OperationTypeComboBox);
            this.OperationsPanel.Controls.Add(this.UsersComboBox);
            this.OperationsPanel.Controls.Add(this.OperationsDateTimePicker);
            this.OperationsPanel.Controls.Add(this.AddNewOperationButton);
            this.OperationsPanel.Controls.Add(this.CurrencyToLabel2);
            this.OperationsPanel.Controls.Add(this.CurrencyFromLabel2);
            this.OperationsPanel.Controls.Add(this.AmountTextBox);
            this.OperationsPanel.Controls.Add(this.OperationDateLabel);
            this.OperationsPanel.Controls.Add(this.OperationsDataLabel);
            this.OperationsPanel.Controls.Add(this.AmountLabel);
            this.OperationsPanel.Controls.Add(this.UserIdLabel);
            this.OperationsPanel.Controls.Add(this.label5);
            this.OperationsPanel.Controls.Add(this.OperationsDataGridView);
            this.OperationsPanel.Controls.Add(this.SaveOperationButton);
            this.OperationsPanel.Location = new System.Drawing.Point(39, 40);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(1107, 597);
            this.OperationsPanel.TabIndex = 26;
            // 
            // CurrencyToComboBox
            // 
            this.CurrencyToComboBox.FormattingEnabled = true;
            this.CurrencyToComboBox.Location = new System.Drawing.Point(189, 326);
            this.CurrencyToComboBox.Name = "CurrencyToComboBox";
            this.CurrencyToComboBox.Size = new System.Drawing.Size(269, 28);
            this.CurrencyToComboBox.TabIndex = 38;
            // 
            // CurrencyFromComboBox
            // 
            this.CurrencyFromComboBox.FormattingEnabled = true;
            this.CurrencyFromComboBox.Location = new System.Drawing.Point(189, 267);
            this.CurrencyFromComboBox.Name = "CurrencyFromComboBox";
            this.CurrencyFromComboBox.Size = new System.Drawing.Size(269, 28);
            this.CurrencyFromComboBox.TabIndex = 37;
            // 
            // OperationTypeComboBox
            // 
            this.OperationTypeComboBox.FormattingEnabled = true;
            this.OperationTypeComboBox.Location = new System.Drawing.Point(189, 43);
            this.OperationTypeComboBox.Name = "OperationTypeComboBox";
            this.OperationTypeComboBox.Size = new System.Drawing.Size(269, 28);
            this.OperationTypeComboBox.TabIndex = 36;
            // 
            // UsersComboBox
            // 
            this.UsersComboBox.FormattingEnabled = true;
            this.UsersComboBox.Location = new System.Drawing.Point(189, 99);
            this.UsersComboBox.Name = "UsersComboBox";
            this.UsersComboBox.Size = new System.Drawing.Size(269, 28);
            this.UsersComboBox.TabIndex = 35;
            // 
            // OperationsDateTimePicker
            // 
            this.OperationsDateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            this.OperationsDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OperationsDateTimePicker.Location = new System.Drawing.Point(189, 153);
            this.OperationsDateTimePicker.Name = "OperationsDateTimePicker";
            this.OperationsDateTimePicker.Size = new System.Drawing.Size(269, 26);
            this.OperationsDateTimePicker.TabIndex = 34;
            // 
            // AddNewOperationButton
            // 
            this.AddNewOperationButton.Location = new System.Drawing.Point(89, 461);
            this.AddNewOperationButton.Name = "AddNewOperationButton";
            this.AddNewOperationButton.Size = new System.Drawing.Size(207, 34);
            this.AddNewOperationButton.TabIndex = 33;
            this.AddNewOperationButton.Text = "Add";
            this.AddNewOperationButton.UseVisualStyleBackColor = true;
            this.AddNewOperationButton.Click += new System.EventHandler(this.AddNewOperationButton_Click);
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
            this.AmountTextBox.Size = new System.Drawing.Size(269, 26);
            this.AmountTextBox.TabIndex = 24;
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
            // OperationsCurrencyFromErrorProvider
            // 
            this.OperationsCurrencyFromErrorProvider.ContainerControl = this;
            // 
            // OperationsCurrencyToErrorProvider
            // 
            this.OperationsCurrencyToErrorProvider.ContainerControl = this;
            // 
            // OperationsAmountErrorProvider
            // 
            this.OperationsAmountErrorProvider.ContainerControl = this;
            // 
            // OperationsOperationTypeErrorProvider
            // 
            this.OperationsOperationTypeErrorProvider.ContainerControl = this;
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 705);
            this.Controls.Add(this.OperationsPanel);
            this.Name = "OperationsForm";
            this.Text = "OperationsForm";
            this.Load += new System.EventHandler(this.Operation_Load);
            this.OperationsPanel.ResumeLayout(false);
            this.OperationsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsCurrencyFromErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsCurrencyToErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsAmountErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsOperationTypeErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OperationsPanel;
        private System.Windows.Forms.Button AddNewOperationButton;
        private System.Windows.Forms.Label CurrencyToLabel2;
        private System.Windows.Forms.Label CurrencyFromLabel2;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label OperationDateLabel;
        private System.Windows.Forms.Label OperationsDataLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView OperationsDataGridView;
        private System.Windows.Forms.Button SaveOperationButton;
        private System.Windows.Forms.DateTimePicker OperationsDateTimePicker;
        private System.Windows.Forms.ErrorProvider OperationsCurrencyFromErrorProvider;
        private System.Windows.Forms.ErrorProvider OperationsCurrencyToErrorProvider;
        private System.Windows.Forms.ErrorProvider OperationsAmountErrorProvider;
        private System.Windows.Forms.ComboBox UsersComboBox;
        private System.Windows.Forms.ComboBox OperationTypeComboBox;
        private System.Windows.Forms.ComboBox CurrencyFromComboBox;
        private System.Windows.Forms.ComboBox CurrencyToComboBox;
        private System.Windows.Forms.ErrorProvider OperationsOperationTypeErrorProvider;
    }
}