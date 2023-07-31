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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLS_CurrencyForm));
            this.clsCurrencyCodeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ClsCurrencyNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CLS_Currency_Panel = new System.Windows.Forms.Panel();
            this.CLS_CurrencyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CLS_CurrencyDataGridView = new System.Windows.Forms.DataGridView();
            this.AddNewCLS_CurrencyButton = new System.Windows.Forms.Button();
            this.SaveCLS_CurrentButton = new System.Windows.Forms.Button();
            this.ActivateUserCheckBox4 = new System.Windows.Forms.CheckBox();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.ActivateUserLabel4 = new System.Windows.Forms.Label();
            this.NameTextBox2 = new System.Windows.Forms.TextBox();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.NameLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clsCurrencyCodeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClsCurrencyNameErrorProvider)).BeginInit();
            this.CLS_Currency_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLS_CurrencyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clsCurrencyCodeErrorProvider
            // 
            this.clsCurrencyCodeErrorProvider.ContainerControl = this;
            // 
            // ClsCurrencyNameErrorProvider
            // 
            this.ClsCurrencyNameErrorProvider.ContainerControl = this;
            // 
            // CLS_Currency_Panel
            // 
            this.CLS_Currency_Panel.Controls.Add(this.CLS_CurrencyLabel);
            this.CLS_Currency_Panel.Controls.Add(this.label1);
            this.CLS_Currency_Panel.Controls.Add(this.CLS_CurrencyDataGridView);
            this.CLS_Currency_Panel.Controls.Add(this.AddNewCLS_CurrencyButton);
            this.CLS_Currency_Panel.Controls.Add(this.SaveCLS_CurrentButton);
            this.CLS_Currency_Panel.Controls.Add(this.ActivateUserCheckBox4);
            this.CLS_Currency_Panel.Controls.Add(this.CodeTextBox);
            this.CLS_Currency_Panel.Controls.Add(this.ActivateUserLabel4);
            this.CLS_Currency_Panel.Controls.Add(this.NameTextBox2);
            this.CLS_Currency_Panel.Controls.Add(this.CodeLabel);
            this.CLS_Currency_Panel.Controls.Add(this.NameLabel2);
            this.CLS_Currency_Panel.Location = new System.Drawing.Point(23, 27);
            this.CLS_Currency_Panel.Name = "CLS_Currency_Panel";
            this.CLS_Currency_Panel.Size = new System.Drawing.Size(1852, 835);
            this.CLS_Currency_Panel.TabIndex = 33;
            // 
            // CLS_CurrencyLabel
            // 
            this.CLS_CurrencyLabel.AutoSize = true;
            this.CLS_CurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLS_CurrencyLabel.Location = new System.Drawing.Point(1206, 159);
            this.CLS_CurrencyLabel.Name = "CLS_CurrencyLabel";
            this.CLS_CurrencyLabel.Size = new System.Drawing.Size(216, 33);
            this.CLS_CurrencyLabel.TabIndex = 39;
            this.CLS_CurrencyLabel.Text = "Currency Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "Currency Information";
            // 
            // CLS_CurrencyDataGridView
            // 
            this.CLS_CurrencyDataGridView.AllowUserToOrderColumns = true;
            this.CLS_CurrencyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLS_CurrencyDataGridView.Location = new System.Drawing.Point(1008, 251);
            this.CLS_CurrencyDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CLS_CurrencyDataGridView.MultiSelect = false;
            this.CLS_CurrencyDataGridView.Name = "CLS_CurrencyDataGridView";
            this.CLS_CurrencyDataGridView.RowHeadersWidth = 62;
            this.CLS_CurrencyDataGridView.RowTemplate.Height = 33;
            this.CLS_CurrencyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CLS_CurrencyDataGridView.Size = new System.Drawing.Size(635, 361);
            this.CLS_CurrencyDataGridView.TabIndex = 36;
            // 
            // AddNewCLS_CurrencyButton
            // 
            this.AddNewCLS_CurrencyButton.Location = new System.Drawing.Point(483, 490);
            this.AddNewCLS_CurrencyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddNewCLS_CurrencyButton.Name = "AddNewCLS_CurrencyButton";
            this.AddNewCLS_CurrencyButton.Size = new System.Drawing.Size(184, 27);
            this.AddNewCLS_CurrencyButton.TabIndex = 42;
            this.AddNewCLS_CurrencyButton.Text = "Add";
            this.AddNewCLS_CurrencyButton.UseVisualStyleBackColor = true;
            // 
            // SaveCLS_CurrentButton
            // 
            this.SaveCLS_CurrentButton.Location = new System.Drawing.Point(483, 450);
            this.SaveCLS_CurrentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveCLS_CurrentButton.Name = "SaveCLS_CurrentButton";
            this.SaveCLS_CurrentButton.Size = new System.Drawing.Size(184, 27);
            this.SaveCLS_CurrentButton.TabIndex = 33;
            this.SaveCLS_CurrentButton.Text = "Save";
            this.SaveCLS_CurrentButton.UseVisualStyleBackColor = true;
            // 
            // ActivateUserCheckBox4
            // 
            this.ActivateUserCheckBox4.AutoSize = true;
            this.ActivateUserCheckBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateUserCheckBox4.Location = new System.Drawing.Point(451, 369);
            this.ActivateUserCheckBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActivateUserCheckBox4.Name = "ActivateUserCheckBox4";
            this.ActivateUserCheckBox4.Size = new System.Drawing.Size(118, 33);
            this.ActivateUserCheckBox4.TabIndex = 41;
            this.ActivateUserCheckBox4.Text = "Activate";
            this.ActivateUserCheckBox4.UseVisualStyleBackColor = true;
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(451, 278);
            this.CodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(237, 22);
            this.CodeTextBox.TabIndex = 34;
            // 
            // ActivateUserLabel4
            // 
            this.ActivateUserLabel4.AutoSize = true;
            this.ActivateUserLabel4.BackColor = System.Drawing.Color.Transparent;
            this.ActivateUserLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateUserLabel4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ActivateUserLabel4.Location = new System.Drawing.Point(173, 371);
            this.ActivateUserLabel4.Name = "ActivateUserLabel4";
            this.ActivateUserLabel4.Size = new System.Drawing.Size(230, 31);
            this.ActivateUserLabel4.TabIndex = 40;
            this.ActivateUserLabel4.Text = "Activate Currency";
            // 
            // NameTextBox2
            // 
            this.NameTextBox2.Location = new System.Drawing.Point(451, 320);
            this.NameTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox2.Name = "NameTextBox2";
            this.NameTextBox2.Size = new System.Drawing.Size(237, 22);
            this.NameTextBox2.TabIndex = 35;
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CodeLabel.Location = new System.Drawing.Point(173, 278);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(79, 31);
            this.CodeLabel.TabIndex = 37;
            this.CodeLabel.Text = "Code";
            // 
            // NameLabel2
            // 
            this.NameLabel2.AutoSize = true;
            this.NameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NameLabel2.Location = new System.Drawing.Point(173, 320);
            this.NameLabel2.Name = "NameLabel2";
            this.NameLabel2.Size = new System.Drawing.Size(86, 31);
            this.NameLabel2.TabIndex = 38;
            this.NameLabel2.Text = "Name";
            // 
            // CLS_CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1887, 863);
            this.Controls.Add(this.CLS_Currency_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CLS_CurrencyForm";
            this.Text = "CLS_CurrencyForm";
            this.Load += new System.EventHandler(this.CLS_CurrencyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clsCurrencyCodeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClsCurrencyNameErrorProvider)).EndInit();
            this.CLS_Currency_Panel.ResumeLayout(false);
            this.CLS_Currency_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLS_CurrencyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider clsCurrencyCodeErrorProvider;
        private System.Windows.Forms.ErrorProvider ClsCurrencyNameErrorProvider;
        private System.Windows.Forms.Panel CLS_Currency_Panel;
        private System.Windows.Forms.Label CLS_CurrencyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CLS_CurrencyDataGridView;
        private System.Windows.Forms.Button AddNewCLS_CurrencyButton;
        private System.Windows.Forms.Button SaveCLS_CurrentButton;
        private System.Windows.Forms.CheckBox ActivateUserCheckBox4;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Label ActivateUserLabel4;
        private System.Windows.Forms.TextBox NameTextBox2;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label NameLabel2;
    }
}