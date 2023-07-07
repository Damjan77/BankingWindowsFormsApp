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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationsForm));
            this.OperationsPanel = new System.Windows.Forms.Panel();
            this.AllOperationsButton = new System.Windows.Forms.Button();
            this.SearchOperationsButton = new System.Windows.Forms.Button();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.SearchOperationLabel = new System.Windows.Forms.Label();
            this.SearchOperationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrencyToComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyFromComboBox = new System.Windows.Forms.ComboBox();
            this.OperationsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddNewOperationButton = new System.Windows.Forms.Button();
            this.CurrencyToLabel2 = new System.Windows.Forms.Label();
            this.CurrencyFromLabel2 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.OperationDateLabel = new System.Windows.Forms.Label();
            this.OperationsDataLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OperationsDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveOperationButton = new System.Windows.Forms.Button();
            this.OperationsCurrencyFromErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OperationsCurrencyToErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OperationsAmountErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OperationsOperationTypeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SearchErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OperationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsCurrencyFromErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsCurrencyToErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsAmountErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsOperationTypeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.Controls.Add(this.AllOperationsButton);
            this.OperationsPanel.Controls.Add(this.SearchOperationsButton);
            this.OperationsPanel.Controls.Add(this.UserIdLabel);
            this.OperationsPanel.Controls.Add(this.SearchOperationLabel);
            this.OperationsPanel.Controls.Add(this.SearchOperationTextBox);
            this.OperationsPanel.Controls.Add(this.label1);
            this.OperationsPanel.Controls.Add(this.CurrencyToComboBox);
            this.OperationsPanel.Controls.Add(this.CurrencyFromComboBox);
            this.OperationsPanel.Controls.Add(this.OperationsDateTimePicker);
            this.OperationsPanel.Controls.Add(this.AddNewOperationButton);
            this.OperationsPanel.Controls.Add(this.CurrencyToLabel2);
            this.OperationsPanel.Controls.Add(this.CurrencyFromLabel2);
            this.OperationsPanel.Controls.Add(this.AmountTextBox);
            this.OperationsPanel.Controls.Add(this.OperationDateLabel);
            this.OperationsPanel.Controls.Add(this.OperationsDataLabel);
            this.OperationsPanel.Controls.Add(this.AmountLabel);
            this.OperationsPanel.Controls.Add(this.OperationsDataGridView);
            this.OperationsPanel.Controls.Add(this.SaveOperationButton);
            this.OperationsPanel.Location = new System.Drawing.Point(39, 40);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(2022, 905);
            this.OperationsPanel.TabIndex = 26;
            // 
            // AllOperationsButton
            // 
            this.AllOperationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOperationsButton.Location = new System.Drawing.Point(1275, 611);
            this.AllOperationsButton.Name = "AllOperationsButton";
            this.AllOperationsButton.Size = new System.Drawing.Size(127, 35);
            this.AllOperationsButton.TabIndex = 44;
            this.AllOperationsButton.Text = "All Operations";
            this.AllOperationsButton.UseVisualStyleBackColor = true;
            this.AllOperationsButton.Click += new System.EventHandler(this.AllOperationsButton_Click);
            // 
            // SearchOperationsButton
            // 
            this.SearchOperationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOperationsButton.Location = new System.Drawing.Point(1123, 611);
            this.SearchOperationsButton.Name = "SearchOperationsButton";
            this.SearchOperationsButton.Size = new System.Drawing.Size(115, 35);
            this.SearchOperationsButton.TabIndex = 43;
            this.SearchOperationsButton.Text = "Search";
            this.SearchOperationsButton.UseVisualStyleBackColor = true;
            this.SearchOperationsButton.Click += new System.EventHandler(this.SearchOperationsButton_Click);
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdLabel.Location = new System.Drawing.Point(768, 611);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(86, 29);
            this.UserIdLabel.TabIndex = 42;
            this.UserIdLabel.Text = "userId:";
            // 
            // SearchOperationLabel
            // 
            this.SearchOperationLabel.AutoSize = true;
            this.SearchOperationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOperationLabel.Location = new System.Drawing.Point(1024, 560);
            this.SearchOperationLabel.Name = "SearchOperationLabel";
            this.SearchOperationLabel.Size = new System.Drawing.Size(214, 29);
            this.SearchOperationLabel.TabIndex = 41;
            this.SearchOperationLabel.Text = "Search Operations";
            // 
            // SearchOperationTextBox
            // 
            this.SearchOperationTextBox.Location = new System.Drawing.Point(873, 615);
            this.SearchOperationTextBox.Name = "SearchOperationTextBox";
            this.SearchOperationTextBox.Size = new System.Drawing.Size(192, 26);
            this.SearchOperationTextBox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Operation Information";
            // 
            // CurrencyToComboBox
            // 
            this.CurrencyToComboBox.FormattingEnabled = true;
            this.CurrencyToComboBox.Location = new System.Drawing.Point(264, 306);
            this.CurrencyToComboBox.Name = "CurrencyToComboBox";
            this.CurrencyToComboBox.Size = new System.Drawing.Size(290, 28);
            this.CurrencyToComboBox.TabIndex = 38;
            // 
            // CurrencyFromComboBox
            // 
            this.CurrencyFromComboBox.FormattingEnabled = true;
            this.CurrencyFromComboBox.Location = new System.Drawing.Point(264, 239);
            this.CurrencyFromComboBox.Name = "CurrencyFromComboBox";
            this.CurrencyFromComboBox.Size = new System.Drawing.Size(290, 28);
            this.CurrencyFromComboBox.TabIndex = 37;
            // 
            // OperationsDateTimePicker
            // 
            this.OperationsDateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            this.OperationsDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OperationsDateTimePicker.Location = new System.Drawing.Point(264, 116);
            this.OperationsDateTimePicker.Name = "OperationsDateTimePicker";
            this.OperationsDateTimePicker.Size = new System.Drawing.Size(290, 26);
            this.OperationsDateTimePicker.TabIndex = 34;
            // 
            // AddNewOperationButton
            // 
            this.AddNewOperationButton.Location = new System.Drawing.Point(289, 470);
            this.AddNewOperationButton.Name = "AddNewOperationButton";
            this.AddNewOperationButton.Size = new System.Drawing.Size(226, 45);
            this.AddNewOperationButton.TabIndex = 33;
            this.AddNewOperationButton.Text = "Add";
            this.AddNewOperationButton.UseVisualStyleBackColor = true;
            this.AddNewOperationButton.Click += new System.EventHandler(this.AddNewOperationButton_Click);
            // 
            // CurrencyToLabel2
            // 
            this.CurrencyToLabel2.AutoSize = true;
            this.CurrencyToLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyToLabel2.Location = new System.Drawing.Point(26, 302);
            this.CurrencyToLabel2.Name = "CurrencyToLabel2";
            this.CurrencyToLabel2.Size = new System.Drawing.Size(145, 29);
            this.CurrencyToLabel2.TabIndex = 26;
            this.CurrencyToLabel2.Text = "Currency To";
            // 
            // CurrencyFromLabel2
            // 
            this.CurrencyFromLabel2.AutoSize = true;
            this.CurrencyFromLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyFromLabel2.Location = new System.Drawing.Point(26, 235);
            this.CurrencyFromLabel2.Name = "CurrencyFromLabel2";
            this.CurrencyFromLabel2.Size = new System.Drawing.Size(172, 29);
            this.CurrencyFromLabel2.TabIndex = 25;
            this.CurrencyFromLabel2.Text = "Currency From";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(264, 174);
            this.AmountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(290, 26);
            this.AmountTextBox.TabIndex = 24;
            // 
            // OperationDateLabel
            // 
            this.OperationDateLabel.AutoSize = true;
            this.OperationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationDateLabel.Location = new System.Drawing.Point(25, 112);
            this.OperationDateLabel.Name = "OperationDateLabel";
            this.OperationDateLabel.Size = new System.Drawing.Size(170, 29);
            this.OperationDateLabel.TabIndex = 22;
            this.OperationDateLabel.Text = "OperationDate";
            // 
            // OperationsDataLabel
            // 
            this.OperationsDataLabel.AutoSize = true;
            this.OperationsDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationsDataLabel.Location = new System.Drawing.Point(1024, 43);
            this.OperationsDataLabel.Name = "OperationsDataLabel";
            this.OperationsDataLabel.Size = new System.Drawing.Size(202, 29);
            this.OperationsDataLabel.TabIndex = 21;
            this.OperationsDataLabel.Text = "Operations Data";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(25, 170);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(94, 29);
            this.AmountLabel.TabIndex = 19;
            this.AmountLabel.Text = "Amount";
            // 
            // OperationsDataGridView
            // 
            this.OperationsDataGridView.AllowUserToOrderColumns = true;
            this.OperationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperationsDataGridView.Location = new System.Drawing.Point(653, 96);
            this.OperationsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OperationsDataGridView.MultiSelect = false;
            this.OperationsDataGridView.Name = "OperationsDataGridView";
            this.OperationsDataGridView.RowHeadersWidth = 62;
            this.OperationsDataGridView.RowTemplate.Height = 33;
            this.OperationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OperationsDataGridView.Size = new System.Drawing.Size(974, 451);
            this.OperationsDataGridView.TabIndex = 16;
            this.OperationsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OperationsDataGridView_CellClick);
            // 
            // SaveOperationButton
            // 
            this.SaveOperationButton.Location = new System.Drawing.Point(289, 392);
            this.SaveOperationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveOperationButton.Name = "SaveOperationButton";
            this.SaveOperationButton.Size = new System.Drawing.Size(226, 45);
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
            // SearchErrorProvider
            // 
            this.SearchErrorProvider.ContainerControl = this;
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(2122, 1011);
            this.Controls.Add(this.OperationsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.SearchErrorProvider)).EndInit();
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
        private System.Windows.Forms.DataGridView OperationsDataGridView;
        private System.Windows.Forms.Button SaveOperationButton;
        private System.Windows.Forms.DateTimePicker OperationsDateTimePicker;
        private System.Windows.Forms.ErrorProvider OperationsCurrencyFromErrorProvider;
        private System.Windows.Forms.ErrorProvider OperationsCurrencyToErrorProvider;
        private System.Windows.Forms.ErrorProvider OperationsAmountErrorProvider;
        private System.Windows.Forms.ComboBox CurrencyFromComboBox;
        private System.Windows.Forms.ComboBox CurrencyToComboBox;
        private System.Windows.Forms.ErrorProvider OperationsOperationTypeErrorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchOperationsButton;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label SearchOperationLabel;
        private System.Windows.Forms.TextBox SearchOperationTextBox;
        private System.Windows.Forms.Button AllOperationsButton;
        private System.Windows.Forms.ErrorProvider SearchErrorProvider;
    }
}