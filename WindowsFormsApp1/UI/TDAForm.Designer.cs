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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TDAForm));
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
            this.AnnuitydataGridView = new System.Windows.Forms.DataGridView();
            this.TdaPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TDADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRateErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnuitydataGridView)).BeginInit();
            this.TdaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TDAAccountLabel
            // 
            this.TDAAccountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TDAAccountLabel.AutoSize = true;
            this.TDAAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDAAccountLabel.Location = new System.Drawing.Point(1135, 50);
            this.TDAAccountLabel.Name = "TDAAccountLabel";
            this.TDAAccountLabel.Size = new System.Drawing.Size(163, 29);
            this.TDAAccountLabel.TabIndex = 0;
            this.TDAAccountLabel.Text = "TDA Account";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Period";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Interest Rate";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AmountTextBox.Location = new System.Drawing.Point(463, 266);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(173, 26);
            this.AmountTextBox.TabIndex = 4;
            // 
            // PeriodTextBox
            // 
            this.PeriodTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PeriodTextBox.Location = new System.Drawing.Point(463, 342);
            this.PeriodTextBox.Name = "PeriodTextBox";
            this.PeriodTextBox.Size = new System.Drawing.Size(173, 26);
            this.PeriodTextBox.TabIndex = 5;
            // 
            // InterestRateTextBox
            // 
            this.InterestRateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InterestRateTextBox.Location = new System.Drawing.Point(463, 425);
            this.InterestRateTextBox.Name = "InterestRateTextBox";
            this.InterestRateTextBox.Size = new System.Drawing.Size(173, 26);
            this.InterestRateTextBox.TabIndex = 6;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalculateButton.AutoSize = true;
            this.CalculateButton.Location = new System.Drawing.Point(476, 519);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(146, 51);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // TDADataGridView
            // 
            this.TDADataGridView.AllowUserToOrderColumns = true;
            this.TDADataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TDADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDADataGridView.Location = new System.Drawing.Point(765, 266);
            this.TDADataGridView.Name = "TDADataGridView";
            this.TDADataGridView.ReadOnly = true;
            this.TDADataGridView.RowHeadersWidth = 62;
            this.TDADataGridView.RowTemplate.Height = 28;
            this.TDADataGridView.Size = new System.Drawing.Size(426, 281);
            this.TDADataGridView.TabIndex = 8;
            // 
            // TDAInformationLabel
            // 
            this.TDAInformationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TDAInformationLabel.AutoSize = true;
            this.TDAInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDAInformationLabel.Location = new System.Drawing.Point(1065, 170);
            this.TDAInformationLabel.Name = "TDAInformationLabel";
            this.TDAInformationLabel.Size = new System.Drawing.Size(297, 29);
            this.TDAInformationLabel.TabIndex = 9;
            this.TDAInformationLabel.Text = "Term Deposit Calculator";
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
            // AnnuitydataGridView
            // 
            this.AnnuitydataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnnuitydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnnuitydataGridView.Location = new System.Drawing.Point(1247, 263);
            this.AnnuitydataGridView.Name = "AnnuitydataGridView";
            this.AnnuitydataGridView.RowHeadersWidth = 62;
            this.AnnuitydataGridView.RowTemplate.Height = 28;
            this.AnnuitydataGridView.Size = new System.Drawing.Size(426, 284);
            this.AnnuitydataGridView.TabIndex = 10;
            // 
            // TdaPanel
            // 
            this.TdaPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TdaPanel.Controls.Add(this.label2);
            this.TdaPanel.Controls.Add(this.AnnuitydataGridView);
            this.TdaPanel.Controls.Add(this.label3);
            this.TdaPanel.Controls.Add(this.TDAInformationLabel);
            this.TdaPanel.Controls.Add(this.TDADataGridView);
            this.TdaPanel.Controls.Add(this.label4);
            this.TdaPanel.Controls.Add(this.AmountTextBox);
            this.TdaPanel.Controls.Add(this.TDAAccountLabel);
            this.TdaPanel.Controls.Add(this.CalculateButton);
            this.TdaPanel.Controls.Add(this.PeriodTextBox);
            this.TdaPanel.Controls.Add(this.InterestRateTextBox);
            this.TdaPanel.Location = new System.Drawing.Point(0, 0);
            this.TdaPanel.Name = "TdaPanel";
            this.TdaPanel.Size = new System.Drawing.Size(1989, 899);
            this.TdaPanel.TabIndex = 11;
            // 
            // TDAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1989, 899);
            this.Controls.Add(this.TdaPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TDAForm";
            this.Text = "TDAForm";
            this.Load += new System.EventHandler(this.TDAForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TDADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRateErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnuitydataGridView)).EndInit();
            this.TdaPanel.ResumeLayout(false);
            this.TdaPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView AnnuitydataGridView;
        private System.Windows.Forms.Panel TdaPanel;
    }
}