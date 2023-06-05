namespace WindowsFormsApp1.UI
{
    partial class LogInForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox_LogIn = new System.Windows.Forms.TextBox();
            this.PasswordTextBox_LogIn = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.UsernameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsernameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(436, 50);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(75, 20);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(144, 246);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(78, 20);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(144, 172);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(83, 20);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username";
            // 
            // UserNameTextBox_LogIn
            // 
            this.UserNameTextBox_LogIn.Location = new System.Drawing.Point(324, 172);
            this.UserNameTextBox_LogIn.Name = "UserNameTextBox_LogIn";
            this.UserNameTextBox_LogIn.Size = new System.Drawing.Size(299, 39);
            this.UserNameTextBox_LogIn.TabIndex = 3;
            // 
            // PasswordTextBox_LogIn
            // 
            this.PasswordTextBox_LogIn.Location = new System.Drawing.Point(324, 250);
            this.PasswordTextBox_LogIn.Name = "PasswordTextBox_LogIn";
            this.PasswordTextBox_LogIn.PasswordChar = '*';
            this.PasswordTextBox_LogIn.Size = new System.Drawing.Size(299, 39);
            this.PasswordTextBox_LogIn.TabIndex = 4;
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(428, 320);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(83, 41);
            this.LogInButton.TabIndex = 5;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(428, 524);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(83, 41);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Location = new System.Drawing.Point(320, 452);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(301, 20);
            this.RegisterLabel.TabIndex = 7;
            this.RegisterLabel.Text = "If you don\'t have account please Register";
            // 
            // UsernameErrorProvider
            // 
            this.UsernameErrorProvider.ContainerControl = this;
            // 
            // PasswordErrorProvider
            // 
            this.PasswordErrorProvider.ContainerControl = this;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 713);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordTextBox_LogIn);
            this.Controls.Add(this.UserNameTextBox_LogIn);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)(this.UsernameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox_LogIn;
        private System.Windows.Forms.TextBox PasswordTextBox_LogIn;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.ErrorProvider UsernameErrorProvider;
        private System.Windows.Forms.ErrorProvider PasswordErrorProvider;
    }
}