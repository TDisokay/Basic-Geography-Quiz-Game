namespace Game_WFDemo_1202
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.roleGroupBox = new System.Windows.Forms.GroupBox();
            this.playerRadio = new System.Windows.Forms.RadioButton();
            this.creatorRadio = new System.Windows.Forms.RadioButton();
            this.loginButton = new System.Windows.Forms.Button();
            this.roleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(52, 122);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(136, 29);
            this.passwordTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.NavajoWhite;
            this.passwordLabel.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.passwordLabel.Location = new System.Drawing.Point(52, 98);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 21);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.usernameTextBox.Location = new System.Drawing.Point(52, 65);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(136, 29);
            this.usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.NavajoWhite;
            this.usernameLabel.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.usernameLabel.Location = new System.Drawing.Point(52, 41);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(84, 21);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // roleGroupBox
            // 
            this.roleGroupBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.roleGroupBox.Controls.Add(this.playerRadio);
            this.roleGroupBox.Controls.Add(this.creatorRadio);
            this.roleGroupBox.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.roleGroupBox.Location = new System.Drawing.Point(52, 162);
            this.roleGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roleGroupBox.Name = "roleGroupBox";
            this.roleGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roleGroupBox.Size = new System.Drawing.Size(135, 81);
            this.roleGroupBox.TabIndex = 4;
            this.roleGroupBox.TabStop = false;
            this.roleGroupBox.Text = "Select Role";
            // 
            // playerRadio
            // 
            this.playerRadio.AutoSize = true;
            this.playerRadio.Checked = true;
            this.playerRadio.Location = new System.Drawing.Point(15, 24);
            this.playerRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerRadio.Name = "playerRadio";
            this.playerRadio.Size = new System.Drawing.Size(71, 25);
            this.playerRadio.TabIndex = 0;
            this.playerRadio.TabStop = true;
            this.playerRadio.Text = "Player";
            this.playerRadio.UseVisualStyleBackColor = true;
            // 
            // creatorRadio
            // 
            this.creatorRadio.AutoSize = true;
            this.creatorRadio.Location = new System.Drawing.Point(15, 49);
            this.creatorRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creatorRadio.Name = "creatorRadio";
            this.creatorRadio.Size = new System.Drawing.Size(80, 25);
            this.creatorRadio.TabIndex = 1;
            this.creatorRadio.Text = "Creator";
            this.creatorRadio.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Turquoise;
            this.loginButton.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.loginButton.Location = new System.Drawing.Point(75, 260);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(90, 32);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(234, 309);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.roleGroupBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.roleGroupBox.ResumeLayout(false);
            this.roleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.GroupBox roleGroupBox;
        private System.Windows.Forms.RadioButton playerRadio;
        private System.Windows.Forms.RadioButton creatorRadio;
    }
}