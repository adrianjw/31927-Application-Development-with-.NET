namespace Assignment_2 {
    partial class LoginWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLine = new System.Windows.Forms.Panel();
            this.passwordLine = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.signupBtn = new Assignment_2.RoundButton();
            this.loginBtn = new Assignment_2.RoundButton();
            this.textEditorIcon = new System.Windows.Forms.PictureBox();
            this.lockIcon = new System.Windows.Forms.PictureBox();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.exitBtn = new Assignment_2.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.usernameTextBox.Location = new System.Drawing.Point(180, 260);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(291, 28);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Text = "Username";
            this.usernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.passwordTextBox.Location = new System.Drawing.Point(180, 328);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(291, 28);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Enter);
            this.passwordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // usernameLine
            // 
            this.usernameLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLine.BackColor = System.Drawing.Color.White;
            this.usernameLine.Location = new System.Drawing.Point(134, 300);
            this.usernameLine.Name = "usernameLine";
            this.usernameLine.Size = new System.Drawing.Size(337, 2);
            this.usernameLine.TabIndex = 7;
            // 
            // passwordLine
            // 
            this.passwordLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLine.BackColor = System.Drawing.Color.White;
            this.passwordLine.Location = new System.Drawing.Point(134, 368);
            this.passwordLine.Name = "passwordLine";
            this.passwordLine.Size = new System.Drawing.Size(337, 2);
            this.passwordLine.TabIndex = 9;
            // 
            // signupBtn
            // 
            this.signupBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.signupBtn.FlatAppearance.BorderSize = 2;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(134, 494);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Radius = 50F;
            this.signupBtn.Size = new System.Drawing.Size(337, 47);
            this.signupBtn.TabIndex = 3;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            this.signupBtn.MouseEnter += new System.EventHandler(this.SignupBtn_MouseEnter);
            this.signupBtn.MouseLeave += new System.EventHandler(this.SignupBtn_MouseLeave);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(143)))), ((int)(((byte)(247)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(134, 417);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Radius = 50F;
            this.loginBtn.Size = new System.Drawing.Size(337, 47);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // textEditorIcon
            // 
            this.textEditorIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEditorIcon.Image = global::Assignment_2.Properties.Resources.text_editor_icon;
            this.textEditorIcon.Location = new System.Drawing.Point(265, 90);
            this.textEditorIcon.Name = "textEditorIcon";
            this.textEditorIcon.Size = new System.Drawing.Size(75, 75);
            this.textEditorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.textEditorIcon.TabIndex = 11;
            this.textEditorIcon.TabStop = false;
            // 
            // lockIcon
            // 
            this.lockIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lockIcon.Image = global::Assignment_2.Properties.Resources.lock_icon;
            this.lockIcon.Location = new System.Drawing.Point(129, 319);
            this.lockIcon.Name = "lockIcon";
            this.lockIcon.Size = new System.Drawing.Size(45, 45);
            this.lockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lockIcon.TabIndex = 10;
            this.lockIcon.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userIcon.Image = global::Assignment_2.Properties.Resources.user_icon;
            this.userIcon.Location = new System.Drawing.Point(129, 250);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(45, 45);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userIcon.TabIndex = 8;
            this.userIcon.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.FlatAppearance.BorderSize = 2;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(504, 641);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Radius = 50F;
            this.exitBtn.Size = new System.Drawing.Size(83, 47);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // LoginWindow
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(604, 705);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.textEditorIcon);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.lockIcon);
            this.Controls.Add(this.passwordLine);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLine);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.userIcon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(620, 744);
            this.Name = "LoginWindow";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox textEditorIcon;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.PictureBox lockIcon;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel usernameLine;
        private System.Windows.Forms.Panel passwordLine;
        private RoundButton loginBtn;
        private RoundButton signupBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RoundButton exitBtn;
    }
}
