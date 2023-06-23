using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;
using System.Threading.Tasks;


namespace WindowsFormsApp1.UI
{
    public partial class LogInForm : Form
    {
        //SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        IUserService userService;
        private Rectangle OriginalLogInButtonRectangle;
        private Rectangle OriginalFormSize;

        public LogInForm()
        {
            userService = new UserServiceImpl();

            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            OriginalLogInButtonRectangle = new Rectangle(LogInButton.Location.X, LogInButton.Location.Y, LogInButton.Width, LogInButton.Height);
            OriginalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
        }


        private async void LogInButton_Click(object sender, EventArgs e)
        {
            if (!validateData()) return;

            string username = UserNameTextBox_LogIn.Text;
            string password = PasswordTextBox_LogIn.Text;
            bool isAuthenticated = userService.AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                LogInButton.Text = "Success!"; //Da se zameni so Environment Variable
                LogInButton.BackColor = Color.Green;
                
                
                UserSession.UserName = username;
                UserSession.UserId = userService.getUserId(username, password);
                WelcomeUserLabel.Text += " " + username;
                WelcomeUserLabel.Visible = true;
                await Task.Delay(1000);
                Main mainForm = new Main();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox_LogIn.Clear();
                PasswordTextBox_LogIn.Clear();
                UserNameTextBox_LogIn.Focus();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private bool validateData()
        {
            //Username Logic
            bool usernameFlag = true;

            if (string.IsNullOrEmpty(UserNameTextBox_LogIn.Text.Trim()))
            {
                UsernameErrorProvider.SetError(UserNameTextBox_LogIn, "Username is required!");
                usernameFlag = false;
            }
            else if (UserNameTextBox_LogIn.Text.Length > 50)
            {
                UsernameErrorProvider.SetError(UserNameTextBox_LogIn, "Username is too long!");
                usernameFlag = false;
            }
            if (usernameFlag)
            {
                UsernameErrorProvider.SetError(UserNameTextBox_LogIn, string.Empty);
                UsernameErrorProvider.Clear();
            }

            //Password Logic
            bool passwordFlag = true;

            if (string.IsNullOrEmpty(PasswordTextBox_LogIn.Text.Trim()))
            {
                PasswordErrorProvider.SetError(PasswordTextBox_LogIn, "Password is required!");
                passwordFlag = false;
            }
            else if (PasswordTextBox_LogIn.Text.Length > 50)
            {
                PasswordErrorProvider.SetError(PasswordTextBox_LogIn, "Password is too long!");
                passwordFlag = false;
            }
            if (passwordFlag)
            {
                PasswordErrorProvider.SetError(PasswordTextBox_LogIn, string.Empty);
                PasswordErrorProvider.Clear();
            }

            if (usernameFlag && passwordFlag) return true;
            else return false;
        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRation = (float)(this.Width) / (float)(OriginalFormSize.Width);
            float yRation = (float)(this.Height) / (float)(OriginalFormSize.Height);

            int newX = (int)(r.Width * xRation);
            int newY = (int)(r.Height * yRation);

            int newWidth = (int)(r.Width * xRation);
            int newHeight = (int)(r.Height * yRation);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void TDAForm_Resize(object sender, EventArgs e)
        {
            resizeControl(OriginalLogInButtonRectangle, LogInButton);
        }


    }
}
