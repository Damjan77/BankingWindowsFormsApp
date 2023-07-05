using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.ServiceImpl;

namespace WindowsFormsApp1
{
    public partial class UserForm : Form
    {
        private IUserService userService;

        public UserForm(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        public UserForm() : this(new UserServiceImpl()) { }

        private void UserForm_Load(object sender, EventArgs e)
        {
            using (var myDb = new Model1())
            {
                var roles = myDb.UserRoles.ToList();
                RoleComboBox.DataSource = roles;
                RoleComboBox.ValueMember = "roleId";
                RoleComboBox.DisplayMember = "roleName";
                RoleComboBox.SelectedItem = null;
            }
               

            this.tableTableAdapter.Fill(this.dataSet1.Table);
            getAllData();
            this.WindowState = FormWindowState.Maximized;

            if (UserSession.roleid == 1) //Basic
            {
                AddNewUserButton.Visible = false;
                RoleComboBox.Enabled = false;
            }
            else if(UserSession.roleid == 2)//Admin
            {
                AddNewUserButton.Visible = true;
                RoleComboBox.Enabled = true;
            }
        }

        private void getAllData()
        {
            UsersDataGridView.DataSource = userService.GetAllData();
        }

        public void DRYUser(object sender, EventArgs e, bool IamExisting)
        {
            User usr = new User();
            UserRole userRoleObj = RoleComboBox.SelectedItem as UserRole;

            if (IamExisting)
            {
                var selectedRow = UsersDataGridView.SelectedRows[0];
                usr.userId = Convert.ToInt32(selectedRow.Cells["userId"].Value);
                usr.surname = SurnameTextBox.Text.ToString();
                usr.isActive = CheckBoxForUserActivation.Checked;
                usr.name = NameTextBox1.Text.ToString();
                usr.username = UsernameTextBox.Text.ToString();
                usr.password = userService.Encrypt(PasswordTextBox.Text.ToString());
                usr.roleId = userRoleObj.roleId;

                userService.UpdateDataInUserTable(usr);
            }
            else
            {
                usr.surname = SurnameTextBox.Text.ToString();
                usr.isActive = CheckBoxForUserActivation.Checked;
                usr.name = NameTextBox1.Text.ToString();
                usr.username = UsernameTextBox.Text.ToString();
                usr.password = userService.Encrypt(PasswordTextBox.Text.ToString());
                usr.roleId = userRoleObj.roleId;

                userService.InsertDataInUserTable(usr);
            }

            getAllData();
        }

        private bool isValidData()
        {
            //Name Logic
            bool nameFlag = true;

            if (string.IsNullOrEmpty(NameTextBox1.Text.Trim()))
            {
                errorProvider1.SetError(NameTextBox1, "Name is required!");
                nameFlag = false;
            }
            else if (NameTextBox1.Text.Length > 50)
            {
                errorProvider1.SetError(NameTextBox1, "Name is too long!");
                nameFlag = false;
            }
            else
            {
                errorProvider1.SetError(NameTextBox1, string.Empty);
                errorProvider1.Clear();
            }

            //Surname Logic
            bool surnameFlag = true;

            if (string.IsNullOrEmpty(SurnameTextBox.Text.Trim()))
            {
                errorProviderUserSurname.SetError(SurnameTextBox, "Surname is required!");
                surnameFlag = false;
            }
            else if (SurnameTextBox.Text.Length > 50)
            {
                errorProviderUserSurname.SetError(SurnameTextBox, "Surname is too long!");
                surnameFlag = false;
            }
            else
            {
                errorProviderUserSurname.SetError(SurnameTextBox, string.Empty);
                errorProviderUserSurname.Clear();
            }

            //Username Logic
            bool usernameFlag = true;
            if (string.IsNullOrEmpty(UsernameTextBox.Text.Trim()))
            {
                UsernameErrorProvider.SetError(UsernameTextBox, "Username is required!");
                usernameFlag = false;
            }
            else if (UsernameTextBox.Text.Length > 50)
            {
                UsernameErrorProvider.SetError(UsernameTextBox, "Username is too long!");
                usernameFlag = false;
            }
            else
            {
                UsernameErrorProvider.SetError(UsernameTextBox, string.Empty);
                UsernameErrorProvider.Clear();
            }

            //Password Logic
            bool passwordFlag = true;

            if (string.IsNullOrEmpty(PasswordTextBox.Text.Trim()))
            {
                PasswordErrorProvider.SetError(PasswordTextBox, "Password is required!");
                passwordFlag = false;
            }
            else if (UsernameTextBox.Text.Length > 50)
            {
                PasswordErrorProvider.SetError(PasswordTextBox, "Password is too long!");
                passwordFlag = false;
            }
            else
            {
                PasswordErrorProvider.SetError(PasswordTextBox, string.Empty);
                PasswordErrorProvider.Clear();
            }

            //Role Logic
            bool RoleFlag = true;

            if (RoleComboBox.SelectedItem == null)
            {
                RoleErrorProvider.SetError(RoleComboBox, "Select Role");
                RoleFlag = false;
            }
            if (RoleFlag)
            {
                RoleErrorProvider.SetError(RoleComboBox, string.Empty);
                RoleErrorProvider.Clear();
            }

            if (nameFlag && surnameFlag && usernameFlag && passwordFlag && RoleFlag) return true;
            else return false;
        }


        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                DRYUser(sender, e, false);
                clearData();
            }
        }

        private void SaveUserButton_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                DRYUser(sender, e, true);
                clearData();
            }

        }

        private void UsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                UsersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                UsersDataGridView.CurrentCell.Selected = true;
                NameTextBox1.Text = UsersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                SurnameTextBox.Text = UsersDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                CheckBoxForUserActivation.Checked = (bool)UsersDataGridView.Rows[e.RowIndex].Cells[3].Value;
                UsernameTextBox.Text = UsersDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                int roleId = (int)UsersDataGridView.Rows[e.RowIndex].Cells[6].Value;
                RoleComboBox.Text = userService.findUserRoleName(roleId);
            }
        }

        private void clearData()
        {
            NameTextBox1.Text = "";
            SurnameTextBox.Text = "";
            CheckBoxForUserActivation.Checked = false;
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            RoleComboBox.SelectedItem = null;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<User> users = userService.searchUsers(SearchTextBox.Text);
            if (users != null)
            {
                UsersDataGridView.DataSource = users;
            }
        }

        private void AllUsersButton_Click(object sender, EventArgs e)
        {
            UsersDataGridView.DataSource = userService.GetAllData();
        }
        
    }
}
