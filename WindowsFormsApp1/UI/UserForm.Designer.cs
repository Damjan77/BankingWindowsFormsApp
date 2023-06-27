using System.Drawing;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.UsersPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AllUsersButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.UserInformationLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
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
            this.UsernameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SearchErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersPanel
            // 
            this.UsersPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsersPanel.BackColor = System.Drawing.Color.Transparent;
            this.UsersPanel.Controls.Add(this.label1);
            this.UsersPanel.Controls.Add(this.AllUsersButton);
            this.UsersPanel.Controls.Add(this.SearchButton);
            this.UsersPanel.Controls.Add(this.SearchTextBox);
            this.UsersPanel.Controls.Add(this.UserInformationLabel);
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
            this.UsersPanel.Location = new System.Drawing.Point(0, 1);
            this.UsersPanel.Name = "UsersPanel";
            this.UsersPanel.Size = new System.Drawing.Size(1984, 905);
            this.UsersPanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(975, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Search User";
            // 
            // AllUsersButton
            // 
            this.AllUsersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllUsersButton.Location = new System.Drawing.Point(1414, 640);
            this.AllUsersButton.Name = "AllUsersButton";
            this.AllUsersButton.Size = new System.Drawing.Size(103, 32);
            this.AllUsersButton.TabIndex = 33;
            this.AllUsersButton.Text = "All Users";
            this.AllUsersButton.UseVisualStyleBackColor = true;
            this.AllUsersButton.Click += new System.EventHandler(this.AllUsersButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.Location = new System.Drawing.Point(1276, 640);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(103, 32);
            this.SearchButton.TabIndex = 32;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchTextBox.Location = new System.Drawing.Point(862, 640);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(373, 26);
            this.SearchTextBox.TabIndex = 31;
            // 
            // UserInformationLabel
            // 
            this.UserInformationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserInformationLabel.AutoSize = true;
            this.UserInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInformationLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UserInformationLabel.Location = new System.Drawing.Point(461, 35);
            this.UserInformationLabel.Name = "UserInformationLabel";
            this.UserInformationLabel.Size = new System.Drawing.Size(238, 32);
            this.UserInformationLabel.TabIndex = 30;
            this.UserInformationLabel.Text = "User Information";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Location = new System.Drawing.Point(417, 295);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(298, 26);
            this.PasswordTextBox.TabIndex = 28;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextBox.Location = new System.Drawing.Point(417, 237);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(298, 26);
            this.UsernameTextBox.TabIndex = 27;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PasswordLabel.Location = new System.Drawing.Point(241, 291);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(120, 29);
            this.PasswordLabel.TabIndex = 26;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UsernameLabel.Location = new System.Drawing.Point(241, 236);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(124, 29);
            this.UsernameLabel.TabIndex = 25;
            this.UsernameLabel.Text = "Username";
            // 
            // AddNewUserButton
            // 
            this.AddNewUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddNewUserButton.Location = new System.Drawing.Point(456, 506);
            this.AddNewUserButton.Name = "AddNewUserButton";
            this.AddNewUserButton.Size = new System.Drawing.Size(193, 34);
            this.AddNewUserButton.TabIndex = 24;
            this.AddNewUserButton.Text = "Add";
            this.AddNewUserButton.UseVisualStyleBackColor = true;
            this.AddNewUserButton.Click += new System.EventHandler(this.AddNewUserButton_Click);
            // 
            // UsersDataLabel
            // 
            this.UsersDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsersDataLabel.AutoSize = true;
            this.UsersDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersDataLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UsersDataLabel.Location = new System.Drawing.Point(1133, 35);
            this.UsersDataLabel.Name = "UsersDataLabel";
            this.UsersDataLabel.Size = new System.Drawing.Size(164, 32);
            this.UsersDataLabel.TabIndex = 21;
            this.UsersDataLabel.Text = "Users Data";
            // 
            // CheckBoxForUserActivation
            // 
            this.CheckBoxForUserActivation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckBoxForUserActivation.AutoSize = true;
            this.CheckBoxForUserActivation.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CheckBoxForUserActivation.Location = new System.Drawing.Point(493, 366);
            this.CheckBoxForUserActivation.Name = "CheckBoxForUserActivation";
            this.CheckBoxForUserActivation.Size = new System.Drawing.Size(147, 24);
            this.CheckBoxForUserActivation.TabIndex = 20;
            this.CheckBoxForUserActivation.Text = "Click to Activate";
            this.CheckBoxForUserActivation.UseVisualStyleBackColor = true;
            // 
            // UserActivationLabel
            // 
            this.UserActivationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserActivationLabel.AutoSize = true;
            this.UserActivationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserActivationLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UserActivationLabel.Location = new System.Drawing.Point(241, 360);
            this.UserActivationLabel.Name = "UserActivationLabel";
            this.UserActivationLabel.Size = new System.Drawing.Size(172, 29);
            this.UserActivationLabel.TabIndex = 19;
            this.UserActivationLabel.Text = "User Activation";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SurnameLabel.Location = new System.Drawing.Point(241, 173);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(110, 29);
            this.SurnameLabel.TabIndex = 18;
            this.SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NameLabel.Location = new System.Drawing.Point(241, 114);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(78, 29);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Name";
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToOrderColumns = true;
            this.UsersDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Location = new System.Drawing.Point(862, 116);
            this.UsersDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsersDataGridView.MultiSelect = false;
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.RowHeadersWidth = 62;
            this.UsersDataGridView.RowTemplate.Height = 33;
            this.UsersDataGridView.Size = new System.Drawing.Size(714, 451);
            this.UsersDataGridView.TabIndex = 16;
            this.UsersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridView_CellClick);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SurnameTextBox.Location = new System.Drawing.Point(417, 171);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(298, 26);
            this.SurnameTextBox.TabIndex = 15;
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTextBox1.Location = new System.Drawing.Point(417, 118);
            this.NameTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(298, 26);
            this.NameTextBox1.TabIndex = 14;
            // 
            // SaveUserButton
            // 
            this.SaveUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveUserButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveUserButton.Image")));
            this.SaveUserButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.SaveUserButton.Location = new System.Drawing.Point(456, 446);
            this.SaveUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveUserButton.Name = "SaveUserButton";
            this.SaveUserButton.Size = new System.Drawing.Size(193, 34);
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
            // UsernameErrorProvider
            // 
            this.UsernameErrorProvider.ContainerControl = this;
            // 
            // PasswordErrorProvider
            // 
            this.PasswordErrorProvider.ContainerControl = this;
            // 
            // SearchErrorProvider
            // 
            this.SearchErrorProvider.ContainerControl = this;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1984, 906);
            this.Controls.Add(this.UsersPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.SearchErrorProvider)).EndInit();
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
        private Label UserInformationLabel;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private ErrorProvider SearchErrorProvider;
        private Button AllUsersButton;
        private Label label1;
    }
}