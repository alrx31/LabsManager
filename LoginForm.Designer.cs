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
            logintextBox1 = new TextBox();
            logintextBox2 = new TextBox();
            loginlabel1 = new Label();
            loginlabel2 = new Label();
            loginbutton1 = new Button();
            loginlinkLabel1 = new LinkLabel();
            Loadlabel = new Label();
            SuspendLayout();
            // 
            // logintextBox1
            // 
            logintextBox1.BorderStyle = BorderStyle.None;
            logintextBox1.Location = new Point(209, 164);
            logintextBox1.Margin = new Padding(4);
            logintextBox1.Name = "logintextBox1";
            logintextBox1.Size = new Size(385, 22);
            logintextBox1.TabIndex = 0;
            // 
            // logintextBox2
            // 
            logintextBox2.Location = new Point(209, 255);
            logintextBox2.Margin = new Padding(4);
            logintextBox2.Name = "logintextBox2";
            logintextBox2.Size = new Size(385, 29);
            logintextBox2.TabIndex = 1;
            logintextBox2.UseSystemPasswordChar = true;
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
            loginbutton1.BackColor = SystemColors.ScrollBar;
            loginbutton1.FlatStyle = FlatStyle.Flat;
            loginbutton1.Location = new Point(235, 340);
            loginbutton1.Margin = new Padding(4);
            loginbutton1.Name = "loginbutton1";
            loginbutton1.Size = new Size(129, 56);
            loginbutton1.TabIndex = 5;
            loginbutton1.Text = "Войти";
            loginbutton1.UseVisualStyleBackColor = false;
            loginbutton1.Click += button1_Click;
            // 
            // loginlinkLabel1
            // 
            loginlinkLabel1.AutoSize = true;
            loginlinkLabel1.Location = new Point(445, 359);
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 190, 200);
            ClientSize = new Size(784, 561);
            Controls.Add(Loadlabel);
            Controls.Add(loginlinkLabel1);
            Controls.Add(loginbutton1);
            Controls.Add(loginlabel2);
            Controls.Add(loginlabel1);
            Controls.Add(logintextBox2);
            Controls.Add(logintextBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "Labs Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox logintextBox1;
        private TextBox logintextBox2;
        private Label loginlabel1;
        private Label loginlabel2;
        private Button loginbutton1;
        private LinkLabel loginlinkLabel1;
        private Label Loadlabel;
    }
}
