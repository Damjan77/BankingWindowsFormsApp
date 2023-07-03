namespace WindowsFormsApp1.UI
{
    partial class CLS_OperatinoTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLS_OperatinoTypeForm));
            this.CLS_OperationTypePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNewOperationTypeButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CLS_OperationTypeLabel = new System.Windows.Forms.Label();
            this.NameLabel3 = new System.Windows.Forms.Label();
            this.CodeLabel2 = new System.Windows.Forms.Label();
            this.CLS_OperationTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.NameTextBox3 = new System.Windows.Forms.TextBox();
            this.CodeTextBox2 = new System.Windows.Forms.TextBox();
            this.SaveCLS_OperationTypeButton = new System.Windows.Forms.Button();
            this.clsOperationTypeCodeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.clsOperationTypeNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CLS_OperationTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLS_OperationTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOperationTypeCodeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOperationTypeNameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CLS_OperationTypePanel
            // 
            this.CLS_OperationTypePanel.Controls.Add(this.label2);
            this.CLS_OperationTypePanel.Controls.Add(this.AddNewOperationTypeButton);
            this.CLS_OperationTypePanel.Controls.Add(this.checkBox1);
            this.CLS_OperationTypePanel.Controls.Add(this.label1);
            this.CLS_OperationTypePanel.Controls.Add(this.CLS_OperationTypeLabel);
            this.CLS_OperationTypePanel.Controls.Add(this.NameLabel3);
            this.CLS_OperationTypePanel.Controls.Add(this.CodeLabel2);
            this.CLS_OperationTypePanel.Controls.Add(this.CLS_OperationTypeDataGridView);
            this.CLS_OperationTypePanel.Controls.Add(this.NameTextBox3);
            this.CLS_OperationTypePanel.Controls.Add(this.CodeTextBox2);
            this.CLS_OperationTypePanel.Controls.Add(this.SaveCLS_OperationTypeButton);
            this.CLS_OperationTypePanel.Location = new System.Drawing.Point(30, 33);
            this.CLS_OperationTypePanel.Name = "CLS_OperationTypePanel";
            this.CLS_OperationTypePanel.Size = new System.Drawing.Size(1901, 750);
            this.CLS_OperationTypePanel.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "OperationType Information";
            // 
            // AddNewOperationTypeButton
            // 
            this.AddNewOperationTypeButton.Location = new System.Drawing.Point(454, 403);
            this.AddNewOperationTypeButton.Name = "AddNewOperationTypeButton";
            this.AddNewOperationTypeButton.Size = new System.Drawing.Size(207, 34);
            this.AddNewOperationTypeButton.TabIndex = 32;
            this.AddNewOperationTypeButton.Text = "Add";
            this.AddNewOperationTypeButton.UseVisualStyleBackColor = true;
            this.AddNewOperationTypeButton.Click += new System.EventHandler(this.AddNewOperationTypeButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(422, 279);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 24);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Activate";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Activate Operation type";
            // 
            // CLS_OperationTypeLabel
            // 
            this.CLS_OperationTypeLabel.AutoSize = true;
            this.CLS_OperationTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLS_OperationTypeLabel.Location = new System.Drawing.Point(1168, 72);
            this.CLS_OperationTypeLabel.Name = "CLS_OperationTypeLabel";
            this.CLS_OperationTypeLabel.Size = new System.Drawing.Size(288, 32);
            this.CLS_OperationTypeLabel.TabIndex = 21;
            this.CLS_OperationTypeLabel.Text = "OperationType Data";
            // 
            // NameLabel3
            // 
            this.NameLabel3.AutoSize = true;
            this.NameLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel3.Location = new System.Drawing.Point(121, 216);
            this.NameLabel3.Name = "NameLabel3";
            this.NameLabel3.Size = new System.Drawing.Size(78, 29);
            this.NameLabel3.TabIndex = 18;
            this.NameLabel3.Text = "Name";
            // 
            // CodeLabel2
            // 
            this.CodeLabel2.AutoSize = true;
            this.CodeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeLabel2.Location = new System.Drawing.Point(121, 162);
            this.CodeLabel2.Name = "CodeLabel2";
            this.CodeLabel2.Size = new System.Drawing.Size(72, 29);
            this.CodeLabel2.TabIndex = 17;
            this.CodeLabel2.Text = "Code";
            // 
            // CLS_OperationTypeDataGridView
            // 
            this.CLS_OperationTypeDataGridView.AllowUserToOrderColumns = true;
            this.CLS_OperationTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLS_OperationTypeDataGridView.Location = new System.Drawing.Point(978, 122);
            this.CLS_OperationTypeDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CLS_OperationTypeDataGridView.MultiSelect = false;
            this.CLS_OperationTypeDataGridView.Name = "CLS_OperationTypeDataGridView";
            this.CLS_OperationTypeDataGridView.RowHeadersWidth = 62;
            this.CLS_OperationTypeDataGridView.RowTemplate.Height = 33;
            this.CLS_OperationTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CLS_OperationTypeDataGridView.Size = new System.Drawing.Size(670, 451);
            this.CLS_OperationTypeDataGridView.TabIndex = 16;
            this.CLS_OperationTypeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CLS_OperationTypeDataGridView_CellClick);
            // 
            // NameTextBox3
            // 
            this.NameTextBox3.Location = new System.Drawing.Point(422, 230);
            this.NameTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox3.Name = "NameTextBox3";
            this.NameTextBox3.Size = new System.Drawing.Size(266, 26);
            this.NameTextBox3.TabIndex = 15;
            // 
            // CodeTextBox2
            // 
            this.CodeTextBox2.Location = new System.Drawing.Point(422, 172);
            this.CodeTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodeTextBox2.Name = "CodeTextBox2";
            this.CodeTextBox2.Size = new System.Drawing.Size(266, 26);
            this.CodeTextBox2.TabIndex = 14;
            // 
            // SaveCLS_OperationTypeButton
            // 
            this.SaveCLS_OperationTypeButton.Location = new System.Drawing.Point(454, 353);
            this.SaveCLS_OperationTypeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveCLS_OperationTypeButton.Name = "SaveCLS_OperationTypeButton";
            this.SaveCLS_OperationTypeButton.Size = new System.Drawing.Size(207, 34);
            this.SaveCLS_OperationTypeButton.TabIndex = 13;
            this.SaveCLS_OperationTypeButton.Text = "Save";
            this.SaveCLS_OperationTypeButton.UseVisualStyleBackColor = true;
            this.SaveCLS_OperationTypeButton.Click += new System.EventHandler(this.SaveCLS_OperationTypeButton_Click);
            // 
            // clsOperationTypeCodeErrorProvider
            // 
            this.clsOperationTypeCodeErrorProvider.ContainerControl = this;
            // 
            // clsOperationTypeNameErrorProvider
            // 
            this.clsOperationTypeNameErrorProvider.ContainerControl = this;
            // 
            // CLS_OperatinoTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1954, 795);
            this.Controls.Add(this.CLS_OperationTypePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CLS_OperatinoTypeForm";
            this.Text = "CLS_OperatinoTypeForm";
            this.Load += new System.EventHandler(this.CLS_OperationTypeForm_Load);
            this.CLS_OperationTypePanel.ResumeLayout(false);
            this.CLS_OperationTypePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLS_OperationTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOperationTypeCodeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOperationTypeNameErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CLS_OperationTypePanel;
        private System.Windows.Forms.Button AddNewOperationTypeButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CLS_OperationTypeLabel;
        private System.Windows.Forms.Label NameLabel3;
        private System.Windows.Forms.Label CodeLabel2;
        private System.Windows.Forms.DataGridView CLS_OperationTypeDataGridView;
        private System.Windows.Forms.TextBox NameTextBox3;
        private System.Windows.Forms.TextBox CodeTextBox2;
        private System.Windows.Forms.Button SaveCLS_OperationTypeButton;
        private System.Windows.Forms.ErrorProvider clsOperationTypeCodeErrorProvider;
        private System.Windows.Forms.ErrorProvider clsOperationTypeNameErrorProvider;
        private System.Windows.Forms.Label label2;
    }
}