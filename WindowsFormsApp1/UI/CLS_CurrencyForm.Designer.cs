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
            this.CLS_CurrencyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLS_CurrencyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCurrencyCodeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClsCurrencyNameErrorProvider)).BeginInit();
            this.SuspendLayout();
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
            this.CLS_CurrencyPanel.Controls.Add(this.SaveCLS_CurrentButton);
            this.CLS_CurrencyPanel.Location = new System.Drawing.Point(46, 53);
            this.CLS_CurrencyPanel.Name = "CLS_CurrencyPanel";
            this.CLS_CurrencyPanel.Size = new System.Drawing.Size(1047, 576);
            this.CLS_CurrencyPanel.TabIndex = 30;
            // 
            // AddNewCLS_CurrencyButton
            // 
            this.AddNewCLS_CurrencyButton.Location = new System.Drawing.Point(77, 291);
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
            // SaveCLS_CurrentButton
            // 
            this.SaveCLS_CurrentButton.Location = new System.Drawing.Point(77, 241);
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
            // CLS_CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 675);
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
    }
}