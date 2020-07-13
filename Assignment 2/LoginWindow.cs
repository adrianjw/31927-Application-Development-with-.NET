using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment_2 {
    public partial class LoginWindow : Form {
        public LoginWindow() {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e) {
            usernameTextBox.AutoSize = false;
            usernameTextBox.Size = new Size(291, 35);
            passwordTextBox.AutoSize = false;
            passwordTextBox.Size = new Size(291, 35);
        }

        private void UsernameTextBox_Enter(object sender, EventArgs e) {
            Focus(usernameTextBox, "Username");
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e) {
            Defocus(usernameTextBox, "Username");
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e) {
            Focus(passwordTextBox, "Password");
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e) {
            Defocus(passwordTextBox, "Password");
        }

        private void LoginBtn_Click(object sender, EventArgs e) {
            bool loginSuccessful = false;
            string[] users = File.ReadAllLines("login.txt");
            foreach (string user in users) {
                string[] separator = { ",", " " };
                string[] userInfo = user.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (usernameTextBox.Text == userInfo[0] && passwordTextBox.Text == userInfo[1]) {
                    loginSuccessful = true;
                    Hide();
                    new TextEditorWindow(this, $"{userInfo[3]} {userInfo[4]}", userInfo[2]).Show();
                    break;
                }
            }
            if (!loginSuccessful)
                MessageBox.Show("Incorrect username or password.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

            passwordTextBox.Text = string.Empty;
        }

        private void SignupBtn_Click(object sender, EventArgs e) {
            Hide();
            new CreateAccountWindow(this).Show();
        }

        private void SignupBtn_MouseEnter(object sender, EventArgs e) {
            signupBtn.FlatAppearance.BorderSize = 3;
        }

        private void SignupBtn_MouseLeave(object sender, EventArgs e) {
            signupBtn.FlatAppearance.BorderSize = 2;
        }

        private void ExitBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e) {
            exitBtn.FlatAppearance.BorderSize = 3;
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e) {
            exitBtn.FlatAppearance.BorderSize = 2;
        }

        private void Focus(TextBox textBox, string text) {
            if (textBox.Text == text) {
                textBox.Text = string.Empty;
                textBox.Font = new Font("Segoe UI Semibold", 15.75F);
                textBox.ForeColor = Color.White;
                if (text == "Password")
                    textBox.PasswordChar = '\u25cf';
            }
        }

        private void Defocus(TextBox textBox, string text) {
            if (textBox.TextLength == 0) {
                textBox.Text = text;
                textBox.Font = new Font("Segoe UI Light", 15.75F);
                textBox.ForeColor = Color.LightGray;
                if (text == "Password")
                    textBox.PasswordChar = '\u0000';
            }
        }
    }
}
