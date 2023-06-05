namespace WindowsFormsApp1.UI
{
    partial class RegisterForm
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
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ActivateUserCheckBox = new System.Windows.Forms.CheckBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ActivateUserLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RegisterSurnameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RegisterUsernameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RegisterPasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RegisterConfirmPasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RegisterNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterSurnameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterUsernameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterPasswordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterConfirmPasswordErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Location = new System.Drawing.Point(449, 61);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(69, 20);
            this.RegisterLabel.TabIndex = 0;
            this.RegisterLabel.Text = "Register";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(89, 306);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(78, 20);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(89, 249);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(83, 20);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(89, 189);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(74, 20);
            this.SurnameLabel.TabIndex = 3;
            this.SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(89, 140);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // ActivateUserCheckBox
            // 
            this.ActivateUserCheckBox.AutoSize = true;
            this.ActivateUserCheckBox.Location = new System.Drawing.Point(252, 416);
            this.ActivateUserCheckBox.Name = "ActivateUserCheckBox";
            this.ActivateUserCheckBox.Size = new System.Drawing.Size(92, 24);
            this.ActivateUserCheckBox.TabIndex = 5;
            this.ActivateUserCheckBox.Text = "Activate";
            this.ActivateUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(252, 140);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(219, 26);
            this.NameTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(252, 306);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(219, 26);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(252, 249);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(219, 26);
            this.UsernameTextBox.TabIndex = 8;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(252, 193);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(219, 26);
            this.SurnameTextBox.TabIndex = 9;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(89, 358);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(137, 20);
            this.ConfirmPasswordLabel.TabIndex = 10;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(252, 358);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(219, 26);
            this.ConfirmPasswordTextBox.TabIndex = 11;
            // 
            // ActivateUserLabel
            // 
            this.ActivateUserLabel.AutoSize = true;
            this.ActivateUserLabel.Location = new System.Drawing.Point(89, 420);
            this.ActivateUserLabel.Name = "ActivateUserLabel";
            this.ActivateUserLabel.Size = new System.Drawing.Size(104, 20);
            this.ActivateUserLabel.TabIndex = 12;
            this.ActivateUserLabel.Text = "Activate User";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(252, 495);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(219, 31);
            this.RegisterButton.TabIndex = 13;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterNameErrorProvider
            // 
            this.RegisterNameErrorProvider.ContainerControl = this;
            // 
            // RegisterSurnameErrorProvider
            // 
            this.RegisterSurnameErrorProvider.ContainerControl = this;
            // 
            // RegisterUsernameErrorProvider
            // 
            this.RegisterUsernameErrorProvider.ContainerControl = this;
            // 
            // RegisterPasswordErrorProvider
            // 
            this.RegisterPasswordErrorProvider.ContainerControl = this;
            // 
            // RegisterConfirmPasswordErrorProvider
            // 
            this.RegisterConfirmPasswordErrorProvider.ContainerControl = this;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 633);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.ActivateUserLabel);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ActivateUserCheckBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.RegisterLabel);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.RegisterNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterSurnameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterUsernameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterPasswordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterConfirmPasswordErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.CheckBox ActivateUserCheckBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ActivateUserLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.ErrorProvider RegisterNameErrorProvider;
        private System.Windows.Forms.ErrorProvider RegisterSurnameErrorProvider;
        private System.Windows.Forms.ErrorProvider RegisterUsernameErrorProvider;
        private System.Windows.Forms.ErrorProvider RegisterPasswordErrorProvider;
        private System.Windows.Forms.ErrorProvider RegisterConfirmPasswordErrorProvider;
    }
}