namespace Assignment_2 {
    partial class CreateAccountWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountWindow));
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBoxBorder = new Assignment_2.RoundButton();
            this.firstNameTextBoxBorder = new Assignment_2.RoundButton();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBoxBorder = new Assignment_2.RoundButton();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBoxBorder = new Assignment_2.RoundButton();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBoxBorder = new Assignment_2.RoundButton();
            this.cancelBtn = new Assignment_2.RoundButton();
            this.createAccountBtn = new Assignment_2.RoundButton();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.createAccountLabel.ForeColor = System.Drawing.Color.White;
            this.createAccountLabel.Location = new System.Drawing.Point(149, 60);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(407, 44);
            this.createAccountLabel.TabIndex = 0;
            this.createAccountLabel.Text = "Create Your Account";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.firstNameTextBox.Location = new System.Drawing.Point(132, 190);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(182, 28);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.Text = "First Name";
            this.firstNameTextBox.Enter += new System.EventHandler(this.FirstNameTextBox_Enter);
            this.firstNameTextBox.Leave += new System.EventHandler(this.FirstNameTextBox_Leave);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.lastNameTextBox.Location = new System.Drawing.Point(397, 190);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(182, 28);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.Text = "Last Name";
            this.lastNameTextBox.Enter += new System.EventHandler(this.LastNameTextBox_Enter);
            this.lastNameTextBox.Leave += new System.EventHandler(this.LastNameTextBox_Leave);
            // 
            // lastNameTextBoxBorder
            // 
            this.lastNameTextBoxBorder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastNameTextBoxBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.lastNameTextBoxBorder.Enabled = false;
            this.lastNameTextBoxBorder.FlatAppearance.BorderSize = 2;
            this.lastNameTextBoxBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastNameTextBoxBorder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBoxBorder.ForeColor = System.Drawing.Color.White;
            this.lastNameTextBoxBorder.Location = new System.Drawing.Point(370, 183);
            this.lastNameTextBoxBorder.Name = "lastNameTextBoxBorder";
            this.lastNameTextBoxBorder.Radius = 50F;
            this.lastNameTextBoxBorder.Size = new System.Drawing.Size(229, 47);
            this.lastNameTextBoxBorder.TabIndex = 0;
            this.lastNameTextBoxBorder.UseVisualStyleBackColor = false;
            // 
            // firstNameTextBoxBorder
            // 
            this.firstNameTextBoxBorder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNameTextBoxBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.firstNameTextBoxBorder.Enabled = false;
            this.firstNameTextBoxBorder.FlatAppearance.BorderSize = 2;
            this.firstNameTextBoxBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstNameTextBoxBorder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBoxBorder.ForeColor = System.Drawing.Color.White;
            this.firstNameTextBoxBorder.Location = new System.Drawing.Point(105, 183);
            this.firstNameTextBoxBorder.Name = "firstNameTextBoxBorder";
            this.firstNameTextBoxBorder.Radius = 50F;
            this.firstNameTextBoxBorder.Size = new System.Drawing.Size(229, 47);
            this.firstNameTextBoxBorder.TabIndex = 0;
            this.firstNameTextBoxBorder.UseVisualStyleBackColor = false;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(397, 334);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(182, 28);
            this.confirmPasswordTextBox.TabIndex = 4;
            this.confirmPasswordTextBox.Text = "Confirm Password";
            this.confirmPasswordTextBox.Enter += new System.EventHandler(this.ConfirmPasswordTextBox_Enter);
            this.confirmPasswordTextBox.Leave += new System.EventHandler(this.ConfirmPasswordTextBox_Leave);
            // 
            // confirmPasswordTextBoxBorder
            // 
            this.confirmPasswordTextBoxBorder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmPasswordTextBoxBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.confirmPasswordTextBoxBorder.Enabled = false;
            this.confirmPasswordTextBoxBorder.FlatAppearance.BorderSize = 2;
            this.confirmPasswordTextBoxBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmPasswordTextBoxBorder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBoxBorder.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordTextBoxBorder.Location = new System.Drawing.Point(370, 327);
            this.confirmPasswordTextBoxBorder.Name = "confirmPasswordTextBoxBorder";
            this.confirmPasswordTextBoxBorder.Radius = 50F;
            this.confirmPasswordTextBoxBorder.Size = new System.Drawing.Size(229, 47);
            this.confirmPasswordTextBoxBorder.TabIndex = 0;
            this.confirmPasswordTextBoxBorder.UseVisualStyleBackColor = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.passwordTextBox.Location = new System.Drawing.Point(132, 334);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(182, 28);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // passwordTextBoxBorder
            // 
            this.passwordTextBoxBorder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTextBoxBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.passwordTextBoxBorder.Enabled = false;
            this.passwordTextBoxBorder.FlatAppearance.BorderSize = 2;
            this.passwordTextBoxBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordTextBoxBorder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBoxBorder.ForeColor = System.Drawing.Color.White;
            this.passwordTextBoxBorder.Location = new System.Drawing.Point(105, 327);
            this.passwordTextBoxBorder.Name = "passwordTextBoxBorder";
            this.passwordTextBoxBorder.Radius = 50F;
            this.passwordTextBoxBorder.Size = new System.Drawing.Size(229, 47);
            this.passwordTextBoxBorder.TabIndex = 0;
            this.passwordTextBoxBorder.UseVisualStyleBackColor = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.usernameTextBox.Location = new System.Drawing.Point(132, 262);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(447, 28);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Text = "Username";
            this.usernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // usernameTextBoxBorder
            // 
            this.usernameTextBoxBorder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTextBoxBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.usernameTextBoxBorder.Enabled = false;
            this.usernameTextBoxBorder.FlatAppearance.BorderSize = 2;
            this.usernameTextBoxBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameTextBoxBorder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBoxBorder.ForeColor = System.Drawing.Color.White;
            this.usernameTextBoxBorder.Location = new System.Drawing.Point(105, 255);
            this.usernameTextBoxBorder.Name = "usernameTextBoxBorder";
            this.usernameTextBoxBorder.Radius = 50F;
            this.usernameTextBoxBorder.Size = new System.Drawing.Size(494, 47);
            this.usernameTextBoxBorder.TabIndex = 0;
            this.usernameTextBoxBorder.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatAppearance.BorderSize = 2;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(184, 652);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Radius = 50F;
            this.cancelBtn.Size = new System.Drawing.Size(337, 47);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            this.cancelBtn.MouseEnter += new System.EventHandler(this.CancelBtn_MouseEnter);
            this.cancelBtn.MouseLeave += new System.EventHandler(this.CancelBtn_MouseLeave);
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(143)))), ((int)(((byte)(247)))));
            this.createAccountBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createAccountBtn.FlatAppearance.BorderSize = 0;
            this.createAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountBtn.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountBtn.ForeColor = System.Drawing.Color.White;
            this.createAccountBtn.Location = new System.Drawing.Point(184, 575);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Radius = 50F;
            this.createAccountBtn.Size = new System.Drawing.Size(337, 47);
            this.createAccountBtn.TabIndex = 7;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = false;
            this.createAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.userTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userTypeComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.userTypeComboBox.Location = new System.Drawing.Point(382, 446);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(103, 38);
            this.userTypeComboBox.TabIndex = 6;
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLabel.ForeColor = System.Drawing.Color.White;
            this.userTypeLabel.Location = new System.Drawing.Point(377, 403);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(108, 30);
            this.userTypeLabel.TabIndex = 0;
            this.userTypeLabel.Text = "User Type";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateOfBirthPicker.CalendarForeColor = System.Drawing.Color.White;
            this.dateOfBirthPicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.dateOfBirthPicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.dateOfBirthPicker.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateOfBirthPicker.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dateOfBirthPicker.CustomFormat = "d  MMM  yyyy";
            this.dateOfBirthPicker.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthPicker.Location = new System.Drawing.Point(117, 449);
            this.dateOfBirthPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(190, 35);
            this.dateOfBirthPicker.TabIndex = 5;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.ForeColor = System.Drawing.Color.White;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(112, 403);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(137, 30);
            this.dateOfBirthLabel.TabIndex = 0;
            this.dateOfBirthLabel.Text = "Date of Birth";
            // 
            // CreateAccountWindow
            // 
            this.AcceptButton = this.createAccountBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(705, 766);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.userTypeLabel);
            this.Controls.Add(this.userTypeComboBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameTextBoxBorder);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.confirmPasswordTextBoxBorder);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordTextBoxBorder);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameTextBoxBorder);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameTextBoxBorder);
            this.Controls.Add(this.createAccountLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(721, 805);
            this.Name = "CreateAccountWindow";
            this.Text = "Create New Account";
            this.Load += new System.EventHandler(this.NewUserWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createAccountLabel;
        private RoundButton firstNameTextBoxBorder;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private RoundButton lastNameTextBoxBorder;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private RoundButton confirmPasswordTextBoxBorder;
        private System.Windows.Forms.TextBox passwordTextBox;
        private RoundButton passwordTextBoxBorder;
        private System.Windows.Forms.TextBox usernameTextBox;
        private RoundButton usernameTextBoxBorder;
        private RoundButton cancelBtn;
        private RoundButton createAccountBtn;
        private System.Windows.Forms.ComboBox userTypeComboBox;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label dateOfBirthLabel;
    }
}