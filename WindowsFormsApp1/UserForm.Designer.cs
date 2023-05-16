namespace WindowsFormsApp1
{
    partial class UserForm
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
            this.UsersPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.UsersDataLabel = new System.Windows.Forms.Label();
            this.CheckBoxForUserActivation = new System.Windows.Forms.CheckBox();
            this.UserActivationLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.SaveUserButton = new System.Windows.Forms.Button();
            this.UsersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersPanel
            // 
            this.UsersPanel.Controls.Add(this.button1);
            this.UsersPanel.Controls.Add(this.UsersDataLabel);
            this.UsersPanel.Controls.Add(this.CheckBoxForUserActivation);
            this.UsersPanel.Controls.Add(this.UserActivationLabel);
            this.UsersPanel.Controls.Add(this.SurnameLabel);
            this.UsersPanel.Controls.Add(this.NameLabel);
            this.UsersPanel.Controls.Add(this.UsersDataGridView);
            this.UsersPanel.Controls.Add(this.SurnameTextBox);
            this.UsersPanel.Controls.Add(this.NameTextBox1);
            this.UsersPanel.Controls.Add(this.SaveUserButton);
            this.UsersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersPanel.Location = new System.Drawing.Point(0, 0);
            this.UsersPanel.Name = "UsersPanel";
            this.UsersPanel.Size = new System.Drawing.Size(1581, 1014);
            this.UsersPanel.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UsersDataLabel
            // 
            this.UsersDataLabel.AutoSize = true;
            this.UsersDataLabel.Location = new System.Drawing.Point(717, 40);
            this.UsersDataLabel.Name = "UsersDataLabel";
            this.UsersDataLabel.Size = new System.Drawing.Size(90, 20);
            this.UsersDataLabel.TabIndex = 21;
            this.UsersDataLabel.Text = "Users Data";
            // 
            // CheckBoxForUserActivation
            // 
            this.CheckBoxForUserActivation.AutoSize = true;
            this.CheckBoxForUserActivation.Location = new System.Drawing.Point(192, 150);
            this.CheckBoxForUserActivation.Name = "CheckBoxForUserActivation";
            this.CheckBoxForUserActivation.Size = new System.Drawing.Size(147, 24);
            this.CheckBoxForUserActivation.TabIndex = 20;
            this.CheckBoxForUserActivation.Text = "Click to Activate";
            this.CheckBoxForUserActivation.UseVisualStyleBackColor = true;
            // 
            // UserActivationLabel
            // 
            this.UserActivationLabel.AutoSize = true;
            this.UserActivationLabel.Location = new System.Drawing.Point(37, 154);
            this.UserActivationLabel.Name = "UserActivationLabel";
            this.UserActivationLabel.Size = new System.Drawing.Size(116, 20);
            this.UserActivationLabel.TabIndex = 19;
            this.UserActivationLabel.Text = "User Activation";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(37, 99);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(74, 20);
            this.SurnameLabel.TabIndex = 18;
            this.SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(37, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Name";
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToOrderColumns = true;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Location = new System.Drawing.Point(495, 99);
            this.UsersDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsersDataGridView.MultiSelect = false;
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.RowHeadersWidth = 62;
            this.UsersDataGridView.RowTemplate.Height = 33;
            this.UsersDataGridView.Size = new System.Drawing.Size(539, 451);
            this.UsersDataGridView.TabIndex = 16;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(192, 93);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(266, 26);
            this.SurnameTextBox.TabIndex = 15;
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Location = new System.Drawing.Point(192, 40);
            this.NameTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(266, 26);
            this.NameTextBox1.TabIndex = 14;
            // 
            // SaveUserButton
            // 
            this.SaveUserButton.Location = new System.Drawing.Point(192, 211);
            this.SaveUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveUserButton.Name = "SaveUserButton";
            this.SaveUserButton.Size = new System.Drawing.Size(135, 34);
            this.SaveUserButton.TabIndex = 13;
            this.SaveUserButton.Text = "Save";
            this.SaveUserButton.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 676);
            this.Controls.Add(this.UsersPanel);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.UsersPanel.ResumeLayout(false);
            this.UsersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UsersPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UsersDataLabel;
        private System.Windows.Forms.CheckBox CheckBoxForUserActivation;
        private System.Windows.Forms.Label UserActivationLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.Button SaveUserButton;
    }
}