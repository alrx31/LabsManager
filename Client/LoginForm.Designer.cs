namespace LabsManager
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            loginlabel1 = new Label();
            loginlabel2 = new Label();
            loginbutton1 = new Button();
            loginlinkLabel1 = new LinkLabel();
            Loadlabel = new Label();
            cbRole = new CheckBox();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Location = new Point(209, 164);
            txtLogin.Margin = new Padding(4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(385, 22);
            txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(209, 255);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(385, 29);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // loginlabel1
            // 
            loginlabel1.AutoSize = true;
            loginlabel1.Location = new Point(209, 139);
            loginlabel1.Margin = new Padding(4, 0, 4, 0);
            loginlabel1.Name = "loginlabel1";
            loginlabel1.Size = new Size(54, 21);
            loginlabel1.TabIndex = 2;
            loginlabel1.Text = "Логин";
            // 
            // loginlabel2
            // 
            loginlabel2.AutoSize = true;
            loginlabel2.Location = new Point(209, 230);
            loginlabel2.Margin = new Padding(4, 0, 4, 0);
            loginlabel2.Name = "loginlabel2";
            loginlabel2.Size = new Size(63, 21);
            loginlabel2.TabIndex = 3;
            loginlabel2.Text = "Пароль";
            // 
            // loginbutton1
            // 
            loginbutton1.BackColor = Color.SkyBlue;
            loginbutton1.FlatStyle = FlatStyle.Flat;
            loginbutton1.Location = new Point(231, 389);
            loginbutton1.Margin = new Padding(4);
            loginbutton1.Name = "loginbutton1";
            loginbutton1.Size = new Size(129, 56);
            loginbutton1.TabIndex = 5;
            loginbutton1.Text = "Войти";
            loginbutton1.UseVisualStyleBackColor = false;
            loginbutton1.Click += btnLogin_Click;
            // 
            // loginlinkLabel1
            // 
            loginlinkLabel1.AutoSize = true;
            loginlinkLabel1.Location = new Point(440, 407);
            loginlinkLabel1.Margin = new Padding(4, 0, 4, 0);
            loginlinkLabel1.Name = "loginlinkLabel1";
            loginlinkLabel1.Size = new Size(113, 21);
            loginlinkLabel1.TabIndex = 6;
            loginlinkLabel1.TabStop = true;
            loginlinkLabel1.Text = "Нет Аккаунта?";
            loginlinkLabel1.LinkClicked += loginlinkLabel1_LinkClicked;
            // 
            // Loadlabel
            // 
            Loadlabel.AutoSize = true;
            Loadlabel.Font = new Font("Segoe UI", 22F);
            Loadlabel.Location = new Point(309, 51);
            Loadlabel.Name = "Loadlabel";
            Loadlabel.Size = new Size(157, 41);
            Loadlabel.TabIndex = 7;
            Loadlabel.Text = "Загрузка...";
            Loadlabel.Visible = false;
            // 
            // cbRole
            // 
            cbRole.AutoSize = true;
            cbRole.Location = new Point(225, 320);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(171, 25);
            cbRole.TabIndex = 8;
            cbRole.Text = "Вы Преподователь?";
            cbRole.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 255);
            ClientSize = new Size(784, 561);
            Controls.Add(cbRole);
            Controls.Add(Loadlabel);
            Controls.Add(loginlinkLabel1);
            Controls.Add(loginbutton1);
            Controls.Add(loginlabel2);
            Controls.Add(loginlabel1);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "Labs Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtPassword;
        private Label loginlabel1;
        private Label loginlabel2;
        private Button loginbutton1;
        private LinkLabel loginlinkLabel1;
        private Label Loadlabel;
        private CheckBox cbRole;
    }
}
