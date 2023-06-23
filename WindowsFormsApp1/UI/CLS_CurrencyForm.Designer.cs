namespace WindowsFormsApp1.UI
{
    partial class CLS_CurrencyForm
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
            this.SaveCLS_CurrentButton = new System.Windows.Forms.Button();
            this.clsCurrencyCodeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ClsCurrencyNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CLS_CurrencyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLS_CurrencyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCurrencyCodeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClsCurrencyNameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CLS_CurrencyPanel
            // 
            this.CLS_CurrencyPanel.Controls.Add(this.label1);
            this.CLS_CurrencyPanel.Controls.Add(this.AddNewCLS_CurrencyButton);
            this.CLS_CurrencyPanel.Controls.Add(this.ActivateUserCheckBox4);
            this.CLS_CurrencyPanel.Controls.Add(this.ActivateUserLabel4);
            this.CLS_CurrencyPanel.Controls.Add(this.CLS_CurrencyLabel);
            this.CLS_CurrencyPanel.Controls.Add(this.NameLabel2);
            this.CLS_CurrencyPanel.Controls.Add(this.CodeLabel);
            this.CLS_CurrencyPanel.Controls.Add(this.CLS_CurrencyDataGridView);
            this.CLS_CurrencyPanel.Controls.Add(this.NameTextBox2);
            this.CLS_CurrencyPanel.Controls.Add(this.CodeTextBox);
            this.CLS_CurrencyPanel.Controls.Add(this.SaveCLS_CurrentButton);
            this.CLS_CurrencyPanel.Location = new System.Drawing.Point(32, 25);
            this.CLS_CurrencyPanel.Name = "CLS_CurrencyPanel";
            this.CLS_CurrencyPanel.Size = new System.Drawing.Size(1852, 751);
            this.CLS_CurrencyPanel.TabIndex = 30;
            // 
            // AddNewCLS_CurrencyButton
            // 
            this.AddNewCLS_CurrencyButton.Location = new System.Drawing.Point(324, 395);
            this.AddNewCLS_CurrencyButton.Name = "AddNewCLS_CurrencyButton";
            this.AddNewCLS_CurrencyButton.Size = new System.Drawing.Size(207, 34);
            this.AddNewCLS_CurrencyButton.TabIndex = 31;
            this.AddNewCLS_CurrencyButton.Text = "Add";
            this.AddNewCLS_CurrencyButton.UseVisualStyleBackColor = true;
            this.AddNewCLS_CurrencyButton.Click += new System.EventHandler(this.AddNewCLS_CurrencyButton_Click);
            // 
            // ActivateUserCheckBox4
            // 
            this.ActivateUserCheckBox4.AutoSize = true;
            this.ActivateUserCheckBox4.Location = new System.Drawing.Point(296, 261);
            this.ActivateUserCheckBox4.Name = "ActivateUserCheckBox4";
            this.ActivateUserCheckBox4.Size = new System.Drawing.Size(92, 24);
            this.ActivateUserCheckBox4.TabIndex = 23;
            this.ActivateUserCheckBox4.Text = "Activate";
            this.ActivateUserCheckBox4.UseVisualStyleBackColor = true;
            // 
            // ActivateUserLabel4
            // 
            this.ActivateUserLabel4.AutoSize = true;
            this.ActivateUserLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateUserLabel4.Location = new System.Drawing.Point(62, 261);
            this.ActivateUserLabel4.Name = "ActivateUserLabel4";
            this.ActivateUserLabel4.Size = new System.Drawing.Size(198, 29);
            this.ActivateUserLabel4.TabIndex = 22;
            this.ActivateUserLabel4.Text = "Activate Currency";
            // 
            // CLS_CurrencyLabel
            // 
            this.CLS_CurrencyLabel.AutoSize = true;
            this.CLS_CurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLS_CurrencyLabel.Location = new System.Drawing.Point(1020, 61);
            this.CLS_CurrencyLabel.Name = "CLS_CurrencyLabel";
            this.CLS_CurrencyLabel.Size = new System.Drawing.Size(240, 29);
            this.CLS_CurrencyLabel.TabIndex = 21;
            this.CLS_CurrencyLabel.Text = "CLS_Currency Data";
            // 
            // NameLabel2
            // 
            this.NameLabel2.AutoSize = true;
            this.NameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel2.Location = new System.Drawing.Point(62, 198);
            this.NameLabel2.Name = "NameLabel2";
            this.NameLabel2.Size = new System.Drawing.Size(78, 29);
            this.NameLabel2.TabIndex = 18;
            this.NameLabel2.Text = "Name";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeLabel.Location = new System.Drawing.Point(62, 145);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(72, 29);
            this.CodeLabel.TabIndex = 17;
            this.CodeLabel.Text = "Code";
            // 
            // CLS_CurrencyDataGridView
            // 
            this.CLS_CurrencyDataGridView.AllowUserToOrderColumns = true;
            this.CLS_CurrencyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLS_CurrencyDataGridView.Location = new System.Drawing.Point(800, 130);
            this.CLS_CurrencyDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CLS_CurrencyDataGridView.MultiSelect = false;
            this.CLS_CurrencyDataGridView.Name = "CLS_CurrencyDataGridView";
            this.CLS_CurrencyDataGridView.RowHeadersWidth = 62;
            this.CLS_CurrencyDataGridView.RowTemplate.Height = 33;
            this.CLS_CurrencyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CLS_CurrencyDataGridView.Size = new System.Drawing.Size(710, 451);
            this.CLS_CurrencyDataGridView.TabIndex = 16;
            this.CLS_CurrencyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CLS_CurrencyDataGridView_CellClick);
            // 
            // NameTextBox2
            // 
            this.NameTextBox2.Location = new System.Drawing.Point(296, 198);
            this.NameTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox2.Name = "NameTextBox2";
            this.NameTextBox2.Size = new System.Drawing.Size(266, 26);
            this.NameTextBox2.TabIndex = 15;
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(296, 145);
            this.CodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(266, 26);
            this.CodeTextBox.TabIndex = 14;
            // 
            // SaveCLS_CurrentButton
            // 
            this.SaveCLS_CurrentButton.Location = new System.Drawing.Point(324, 345);
            this.SaveCLS_CurrentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveCLS_CurrentButton.Name = "SaveCLS_CurrentButton";
            this.SaveCLS_CurrentButton.Size = new System.Drawing.Size(207, 34);
            this.SaveCLS_CurrentButton.TabIndex = 13;
            this.SaveCLS_CurrentButton.Text = "Save";
            this.SaveCLS_CurrentButton.UseVisualStyleBackColor = true;
            this.SaveCLS_CurrentButton.Click += new System.EventHandler(this.SaveCLS_CurrentButton_Click);
            // 
            // clsCurrencyCodeErrorProvider
            // 
            this.clsCurrencyCodeErrorProvider.ContainerControl = this;
            // 
            // ClsCurrencyNameErrorProvider
            // 
            this.ClsCurrencyNameErrorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "CLS_Currency Information";
            // 
            // CLS_CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1911, 802);
            this.Controls.Add(this.CLS_CurrencyPanel);
            this.Name = "CLS_CurrencyForm";
            this.Text = "CLS_CurrencyForm";
            this.Load += new System.EventHandler(this.CLS_CurrencyForm_Load);
            this.CLS_CurrencyPanel.ResumeLayout(false);
            this.CLS_CurrencyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLS_CurrencyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCurrencyCodeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClsCurrencyNameErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CLS_CurrencyPanel;
        private System.Windows.Forms.Button AddNewCLS_CurrencyButton;
        private System.Windows.Forms.CheckBox ActivateUserCheckBox4;
        private System.Windows.Forms.Label ActivateUserLabel4;
        private System.Windows.Forms.Label CLS_CurrencyLabel;
        private System.Windows.Forms.Label NameLabel2;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.DataGridView CLS_CurrencyDataGridView;
        private System.Windows.Forms.TextBox NameTextBox2;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Button SaveCLS_CurrentButton;
        private System.Windows.Forms.ErrorProvider clsCurrencyCodeErrorProvider;
        private System.Windows.Forms.ErrorProvider ClsCurrencyNameErrorProvider;
        private System.Windows.Forms.Label label1;
    }
}