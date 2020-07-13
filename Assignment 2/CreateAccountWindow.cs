using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment_2 {
    public partial class CreateAccountWindow : Form {

        LoginWindow loginWindow;

        public CreateAccountWindow(LoginWindow loginWindow) {
            InitializeComponent();
            this.loginWindow = loginWindow;
        }

        private void NewUserWindow_Load(object sender, EventArgs e) {
            firstNameTextBox.AutoSize = false;
            firstNameTextBox.Size = new Size(182, 35);
            lastNameTextBox.AutoSize = false;
            lastNameTextBox.Size = new Size(182, 35);
            dateOfBirthPicker.Format = DateTimePickerFormat.Custom;
            dateOfBirthPicker.MaxDate = DateTime.Today;
        }

        private void FirstNameTextBox_Enter(object sender, EventArgs e) {
            Focus(firstNameTextBox, firstNameTextBoxBorder, "First Name");
        }

        private void FirstNameTextBox_Leave(object sender, EventArgs e) {
            Defocus(firstNameTextBox, firstNameTextBoxBorder, "First Name");
        }

        private void LastNameTextBox_Enter(object sender, EventArgs e) {
            Focus(lastNameTextBox, lastNameTextBoxBorder, "Last Name");
        }

        private void LastNameTextBox_Leave(object sender, EventArgs e) {
            Defocus(lastNameTextBox, lastNameTextBoxBorder, "Last Name");
        }

        private void UsernameTextBox_Enter(object sender, EventArgs e) {
            Focus(usernameTextBox, usernameTextBoxBorder, "Username");
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e) {
            Defocus(usernameTextBox, usernameTextBoxBorder, "Username");
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e) {
            Focus(passwordTextBox, passwordTextBoxBorder, "Password");
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e) {
            Defocus(passwordTextBox, passwordTextBoxBorder, "Password");
        }

        private void ConfirmPasswordTextBox_Enter(object sender, EventArgs e) {
            Focus(confirmPasswordTextBox, confirmPasswordTextBoxBorder, "Confirm Password");
        }

        private void ConfirmPasswordTextBox_Leave(object sender, EventArgs e) {
            Defocus(confirmPasswordTextBox, confirmPasswordTextBoxBorder, "Confirm Password");
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e) {
            if (firstNameTextBox.Text == "First Name" || lastNameTextBox.Text == "Last Name") {
                MessageBox.Show("Name cannot be blank.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (usernameTextBox.Text == "Username") {
                MessageBox.Show("Username cannot be blank.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (UsernameExists(usernameTextBox.Text)) {
                MessageBox.Show("Username already exists.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (passwordTextBox.Text == "Password" || confirmPasswordTextBox.Text == "Confirm Password") {
                MessageBox.Show("Password cannot be blank.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (passwordTextBox.Text != confirmPasswordTextBox.Text) {
                MessageBox.Show("Passwords do not match.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (userTypeComboBox.SelectedItem == null) {
                MessageBox.Show("Please select user type.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else {
                dateOfBirthPicker.CustomFormat = "dd-MM-yyyy";
                File.AppendAllText("login.txt", $"\n{usernameTextBox.Text},{passwordTextBox.Text}," +
                    $"{userTypeComboBox.SelectedItem},{firstNameTextBox.Text},{lastNameTextBox.Text}," +
                    $"{dateOfBirthPicker.Text}");
                MessageBox.Show("Account created successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                loginWindow.Show();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e) {
            Close();
            loginWindow.Show();
        }

        private void CancelBtn_MouseEnter(object sender, EventArgs e) {
            cancelBtn.FlatAppearance.BorderSize = 3;
        }

        private void CancelBtn_MouseLeave(object sender, EventArgs e) {
            cancelBtn.FlatAppearance.BorderSize = 2;
        }

        private bool UsernameExists(string username) {
            string[] users = File.ReadAllLines("login.txt");
            foreach (string user in users) {
                string[] separator = { ",", " " };
                string[] userInfo = user.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (username == userInfo[0])
                    return true;
            }
            return false;
        }

        private void Focus(TextBox textBox, RoundButton border, string text) {
            if (textBox.Text == text) {
                textBox.Text = string.Empty;
                textBox.Font = new Font("Segoe UI Semibold", 15.75F);
                textBox.ForeColor = Color.White;
                border.FlatAppearance.BorderSize = 4;
                if (text == "Password" || text == "Confirm Password")
                    textBox.PasswordChar = '\u25cf';
            }
        }

        private void Defocus(TextBox textBox, RoundButton border, string text) {
            if (textBox.TextLength == 0) {
                textBox.Text = text;
                textBox.Font = new Font("Segoe UI Light", 15.75F);
                textBox.ForeColor = Color.LightGray;
                border.FlatAppearance.BorderSize = 2;
                if (text == "Password" || text == "Confirm Password")
                    textBox.PasswordChar = '\u0000';
            }
        }
    }
}
