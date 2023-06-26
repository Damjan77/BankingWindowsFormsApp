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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
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
            this.backToLoginButton = new System.Windows.Forms.Button();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterSurnameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterUsernameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterPasswordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterConfirmPasswordErrorProvider)).BeginInit();
            this.RegisterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RegisterLabel.Location = new System.Drawing.Point(183, 26);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(128, 32);
            this.RegisterLabel.TabIndex = 0;
            this.RegisterLabel.Text = "Register";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordLabel.Location = new System.Drawing.Point(25, 291);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(120, 29);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UsernameLabel.Location = new System.Drawing.Point(25, 234);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(124, 29);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SurnameLabel.Location = new System.Drawing.Point(25, 174);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(110, 29);
            this.SurnameLabel.TabIndex = 3;
            this.SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Location = new System.Drawing.Point(25, 125);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(78, 29);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // ActivateUserCheckBox
            // 
            this.ActivateUserCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActivateUserCheckBox.AutoSize = true;
            this.ActivateUserCheckBox.Location = new System.Drawing.Point(261, 404);
            this.ActivateUserCheckBox.Name = "ActivateUserCheckBox";
            this.ActivateUserCheckBox.Size = new System.Drawing.Size(92, 24);
            this.ActivateUserCheckBox.TabIndex = 5;
            this.ActivateUserCheckBox.Text = "Activate";
            this.ActivateUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTextBox.Location = new System.Drawing.Point(261, 125);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(246, 26);
            this.NameTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Location = new System.Drawing.Point(261, 294);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(246, 26);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextBox.Location = new System.Drawing.Point(261, 237);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(246, 26);
            this.UsernameTextBox.TabIndex = 8;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SurnameTextBox.Location = new System.Drawing.Point(261, 181);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(246, 26);
            this.SurnameTextBox.TabIndex = 9;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(25, 343);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(210, 29);
            this.ConfirmPasswordLabel.TabIndex = 10;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(261, 346);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(246, 26);
            this.ConfirmPasswordTextBox.TabIndex = 11;
            // 
            // ActivateUserLabel
            // 
            this.ActivateUserLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActivateUserLabel.AutoSize = true;
            this.ActivateUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateUserLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ActivateUserLabel.Location = new System.Drawing.Point(25, 405);
            this.ActivateUserLabel.Name = "ActivateUserLabel";
            this.ActivateUserLabel.Size = new System.Drawing.Size(153, 29);
            this.ActivateUserLabel.TabIndex = 12;
            this.ActivateUserLabel.Text = "Activate User";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterButton.Location = new System.Drawing.Point(261, 512);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(231, 45);
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
            // backToLoginButton
            // 
            this.backToLoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backToLoginButton.Location = new System.Drawing.Point(261, 586);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(231, 45);
            this.backToLoginButton.TabIndex = 14;
            this.backToLoginButton.Text = "Back to LogIn";
            this.backToLoginButton.UseVisualStyleBackColor = true;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterPanel.BackColor = System.Drawing.Color.Transparent;
            this.RegisterPanel.Controls.Add(this.NameLabel);
            this.RegisterPanel.Controls.Add(this.RegisterLabel);
            this.RegisterPanel.Controls.Add(this.backToLoginButton);
            this.RegisterPanel.Controls.Add(this.RegisterButton);
            this.RegisterPanel.Controls.Add(this.PasswordLabel);
            this.RegisterPanel.Controls.Add(this.ActivateUserLabel);
            this.RegisterPanel.Controls.Add(this.UsernameLabel);
            this.RegisterPanel.Controls.Add(this.ConfirmPasswordTextBox);
            this.RegisterPanel.Controls.Add(this.SurnameLabel);
            this.RegisterPanel.Controls.Add(this.ConfirmPasswordLabel);
            this.RegisterPanel.Controls.Add(this.ActivateUserCheckBox);
            this.RegisterPanel.Controls.Add(this.SurnameTextBox);
            this.RegisterPanel.Controls.Add(this.NameTextBox);
            this.RegisterPanel.Controls.Add(this.UsernameTextBox);
            this.RegisterPanel.Controls.Add(this.PasswordTextBox);
            this.RegisterPanel.Location = new System.Drawing.Point(315, 12);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(586, 717);
            this.RegisterPanel.TabIndex = 15;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 783);
            this.Controls.Add(this.RegisterPanel);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.RegisterNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterSurnameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterUsernameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterPasswordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterConfirmPasswordErrorProvider)).EndInit();
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button backToLoginButton;
        private System.Windows.Forms.Panel RegisterPanel;
    }
}