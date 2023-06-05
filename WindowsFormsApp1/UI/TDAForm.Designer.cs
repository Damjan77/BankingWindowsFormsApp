namespace WindowsFormsApp1.UI
{
    partial class TDAForm
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
            this.TDAAccountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.PeriodTextBox = new System.Windows.Forms.TextBox();
            this.InterestRateTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.TDADataGridView = new System.Windows.Forms.DataGridView();
            this.TDAInformationLabel = new System.Windows.Forms.Label();
            this.AmountErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PeriodErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.InterestRateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TDADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRateErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TDAAccountLabel
            // 
            this.TDAAccountLabel.AutoSize = true;
            this.TDAAccountLabel.Location = new System.Drawing.Point(401, 24);
            this.TDAAccountLabel.Name = "TDAAccountLabel";
            this.TDAAccountLabel.Size = new System.Drawing.Size(104, 20);
            this.TDAAccountLabel.TabIndex = 0;
            this.TDAAccountLabel.Text = "TDA Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Interest Rate";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(217, 133);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(175, 26);
            this.AmountTextBox.TabIndex = 4;
            // 
            // PeriodTextBox
            // 
            this.PeriodTextBox.Location = new System.Drawing.Point(217, 217);
            this.PeriodTextBox.Name = "PeriodTextBox";
            this.PeriodTextBox.Size = new System.Drawing.Size(175, 26);
            this.PeriodTextBox.TabIndex = 5;
            // 
            // InterestRateTextBox
            // 
            this.InterestRateTextBox.Location = new System.Drawing.Point(217, 305);
            this.InterestRateTextBox.Name = "InterestRateTextBox";
            this.InterestRateTextBox.Size = new System.Drawing.Size(175, 26);
            this.InterestRateTextBox.TabIndex = 6;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(217, 382);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(123, 36);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // TDADataGridView
            // 
            this.TDADataGridView.AllowUserToOrderColumns = true;
            this.TDADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDADataGridView.Location = new System.Drawing.Point(589, 136);
            this.TDADataGridView.Name = "TDADataGridView";
            this.TDADataGridView.ReadOnly = true;
            this.TDADataGridView.RowHeadersWidth = 62;
            this.TDADataGridView.RowTemplate.Height = 28;
            this.TDADataGridView.Size = new System.Drawing.Size(364, 282);
            this.TDADataGridView.TabIndex = 8;
            // 
            // TDAInformationLabel
            // 
            this.TDAInformationLabel.AutoSize = true;
            this.TDAInformationLabel.Location = new System.Drawing.Point(718, 105);
            this.TDAInformationLabel.Name = "TDAInformationLabel";
            this.TDAInformationLabel.Size = new System.Drawing.Size(90, 20);
            this.TDAInformationLabel.TabIndex = 9;
            this.TDAInformationLabel.Text = "Information";
            // 
            // AmountErrorProvider
            // 
            this.AmountErrorProvider.ContainerControl = this;
            // 
            // PeriodErrorProvider
            // 
            this.PeriodErrorProvider.ContainerControl = this;
            // 
            // InterestRateErrorProvider
            // 
            this.InterestRateErrorProvider.ContainerControl = this;
            // 
            // TDAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 649);
            this.Controls.Add(this.TDAInformationLabel);
            this.Controls.Add(this.TDADataGridView);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.InterestRateTextBox);
            this.Controls.Add(this.PeriodTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TDAAccountLabel);
            this.Name = "TDAForm";
            this.Text = "TDAForm";
            ((System.ComponentModel.ISupportInitialize)(this.TDADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRateErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TDAAccountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox PeriodTextBox;
        private System.Windows.Forms.TextBox InterestRateTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.DataGridView TDADataGridView;
        private System.Windows.Forms.Label TDAInformationLabel;
        private System.Windows.Forms.ErrorProvider AmountErrorProvider;
        private System.Windows.Forms.ErrorProvider PeriodErrorProvider;
        private System.Windows.Forms.ErrorProvider InterestRateErrorProvider;
    }
}