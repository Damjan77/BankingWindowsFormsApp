﻿using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.UsersPanel = new System.Windows.Forms.Panel();
            this.AddNewUserButton = new System.Windows.Forms.Button();
            this.UsersDataLabel = new System.Windows.Forms.Label();
            this.CheckBoxForUserActivation = new System.Windows.Forms.CheckBox();
            this.UserActivationLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.SaveUserButton = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.tableTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.TableTableAdapter();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUserSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersPanel
            // 
            this.UsersPanel.Controls.Add(this.PasswordTextBox);
            this.UsersPanel.Controls.Add(this.UsernameTextBox);
            this.UsersPanel.Controls.Add(this.PasswordLabel);
            this.UsersPanel.Controls.Add(this.UsernameLabel);
            this.UsersPanel.Controls.Add(this.AddNewUserButton);
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
            this.UsersPanel.Size = new System.Drawing.Size(1054, 594);
            this.UsersPanel.TabIndex = 9;
            // 
            // AddNewUserButton
            // 
            this.AddNewUserButton.Location = new System.Drawing.Point(192, 441);
            this.AddNewUserButton.Name = "AddNewUserButton";
            this.AddNewUserButton.Size = new System.Drawing.Size(135, 34);
            this.AddNewUserButton.TabIndex = 24;
            this.AddNewUserButton.Text = "Add";
            this.AddNewUserButton.UseVisualStyleBackColor = true;
            this.AddNewUserButton.Click += new System.EventHandler(this.AddNewUserButton_Click);
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
            this.CheckBoxForUserActivation.Location = new System.Drawing.Point(192, 309);
            this.CheckBoxForUserActivation.Name = "CheckBoxForUserActivation";
            this.CheckBoxForUserActivation.Size = new System.Drawing.Size(147, 24);
            this.CheckBoxForUserActivation.TabIndex = 20;
            this.CheckBoxForUserActivation.Text = "Click to Activate";
            this.CheckBoxForUserActivation.UseVisualStyleBackColor = true;
            // 
            // UserActivationLabel
            // 
            this.UserActivationLabel.AutoSize = true;
            this.UserActivationLabel.Location = new System.Drawing.Point(24, 313);
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
            //this.UsersDataGridView.Columns["Operations"].Visible = false;
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
            this.UsersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridView_CellClick);
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
            this.SaveUserButton.Location = new System.Drawing.Point(192, 384);
            this.SaveUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveUserButton.Name = "SaveUserButton";
            this.SaveUserButton.Size = new System.Drawing.Size(135, 34);
            this.SaveUserButton.TabIndex = 13;
            this.SaveUserButton.Text = "Save";
            this.SaveUserButton.UseVisualStyleBackColor = true;
            this.SaveUserButton.Click += new System.EventHandler(this.SaveUserButton_Click);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.dataSet1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProviderUserSurname
            // 
            this.errorProviderUserSurname.ContainerControl = this;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(37, 162);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(125, 30);
            this.UsernameLabel.TabIndex = 25;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(37, 217);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(78, 20);
            this.PasswordLabel.TabIndex = 26;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(192, 159);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(266, 26);
            this.UsernameTextBox.TabIndex = 27;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(192, 217);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(266, 26);
            this.PasswordTextBox.TabIndex = 28;
            // 
            // UsernameErrorProvider
            // 
            this.UsernameErrorProvider.ContainerControl = this;
            // 
            // PasswordErrorProvider
            // 
            this.PasswordErrorProvider.ContainerControl = this;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 594);
            this.Controls.Add(this.UsersPanel);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.UsersPanel.ResumeLayout(false);
            this.UsersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UsersPanel;
        private System.Windows.Forms.Button AddNewUserButton;
        private System.Windows.Forms.Label UsersDataLabel;
        private System.Windows.Forms.CheckBox CheckBoxForUserActivation;
        private System.Windows.Forms.Label UserActivationLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.Button SaveUserButton;
        private DataSet1 dataSet1;
        private BindingSource tableBindingSource;
        private DataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private DataGridViewTextBoxColumn usersIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn UsersId;
        private BindingSource tableBindingSource1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProviderUserSurname;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private Label UsernameLabel;
        private ErrorProvider UsernameErrorProvider;
        private ErrorProvider PasswordErrorProvider;
    }
}