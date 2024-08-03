namespace LabsManager
{
    partial class RegisterForm
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
            registerlabel2 = new Label();
            registerlabel1 = new Label();
            registertextBox2 = new TextBox();
            registertextBox1 = new TextBox();
            registerlabel3 = new Label();
            registertextBox3 = new TextBox();
            registercomboBox1 = new ComboBox();
            registerlabel4 = new Label();
            registercheckBox2 = new CheckBox();
            registertextBox4 = new TextBox();
            registerlabel5 = new Label();
            registertextBox5 = new TextBox();
            registerlabel6 = new Label();
            registerbutton1 = new Button();
            Loadlabel1 = new Label();
            SuspendLayout();
            // 
            // registerlabel2
            // 
            registerlabel2.AutoSize = true;
            registerlabel2.Location = new Point(226, 96);
            registerlabel2.Margin = new Padding(4, 0, 4, 0);
            registerlabel2.Name = "registerlabel2";
            registerlabel2.Size = new Size(63, 21);
            registerlabel2.TabIndex = 10;
            registerlabel2.Text = "Пароль";
            // 
            // registerlabel1
            // 
            registerlabel1.AutoSize = true;
            registerlabel1.Location = new Point(226, 24);
            registerlabel1.Margin = new Padding(4, 0, 4, 0);
            registerlabel1.Name = "registerlabel1";
            registerlabel1.Size = new Size(54, 21);
            registerlabel1.TabIndex = 9;
            registerlabel1.Text = "Логин";
            // 
            // registertextBox2
            // 
            registertextBox2.Location = new Point(226, 122);
            registertextBox2.Margin = new Padding(4);
            registertextBox2.Name = "registertextBox2";
            registertextBox2.Size = new Size(384, 29);
            registertextBox2.TabIndex = 8;
            registertextBox2.UseSystemPasswordChar = true;
            // 
            // registertextBox1
            // 
            registertextBox1.Location = new Point(226, 50);
            registertextBox1.Margin = new Padding(4);
            registertextBox1.Name = "registertextBox1";
            registertextBox1.Size = new Size(384, 29);
            registertextBox1.TabIndex = 7;
            // 
            // registerlabel3
            // 
            registerlabel3.AutoSize = true;
            registerlabel3.Location = new Point(226, 171);
            registerlabel3.Margin = new Padding(4, 0, 4, 0);
            registerlabel3.Name = "registerlabel3";
            registerlabel3.Size = new Size(41, 21);
            registerlabel3.TabIndex = 14;
            registerlabel3.Text = "Имя";
            // 
            // registertextBox3
            // 
            registertextBox3.Location = new Point(226, 196);
            registertextBox3.Margin = new Padding(4);
            registertextBox3.Name = "registertextBox3";
            registertextBox3.Size = new Size(384, 29);
            registertextBox3.TabIndex = 13;
            registertextBox3.UseSystemPasswordChar = true;
            // 
            // registercomboBox1
            // 
            registercomboBox1.FormattingEnabled = true;
            registercomboBox1.ItemHeight = 21;
            registercomboBox1.Items.AddRange(new object[] { "ФКП", "ИЭФ", "ФИТУ", "ФКСИС", "ФРЭ", "ВФ", "ФИБ" });
            registercomboBox1.Location = new Point(226, 271);
            registercomboBox1.Margin = new Padding(4);
            registercomboBox1.Name = "registercomboBox1";
            registercomboBox1.Size = new Size(384, 29);
            registercomboBox1.TabIndex = 16;
            // 
            // registerlabel4
            // 
            registerlabel4.AutoSize = true;
            registerlabel4.Location = new Point(226, 246);
            registerlabel4.Margin = new Padding(4, 0, 4, 0);
            registerlabel4.Name = "registerlabel4";
            registerlabel4.Size = new Size(84, 21);
            registerlabel4.TabIndex = 17;
            registerlabel4.Text = "Факультет";
            // 
            // registercheckBox2
            // 
            registercheckBox2.AutoSize = true;
            registercheckBox2.Location = new Point(433, 341);
            registercheckBox2.Margin = new Padding(4);
            registercheckBox2.Name = "registercheckBox2";
            registercheckBox2.Size = new Size(138, 25);
            registercheckBox2.TabIndex = 19;
            registercheckBox2.Text = "преподователь";
            registercheckBox2.UseVisualStyleBackColor = true;
            registercheckBox2.CheckedChanged += registercheckBox2_CheckedChanged;
            // 
            // registertextBox4
            // 
            registertextBox4.Location = new Point(226, 390);
            registertextBox4.Margin = new Padding(4);
            registertextBox4.Name = "registertextBox4";
            registertextBox4.Size = new Size(368, 29);
            registertextBox4.TabIndex = 20;
            registertextBox4.UseSystemPasswordChar = true;
            // 
            // registerlabel5
            // 
            registerlabel5.AutoSize = true;
            registerlabel5.Location = new Point(226, 365);
            registerlabel5.Margin = new Padding(4, 0, 4, 0);
            registerlabel5.Name = "registerlabel5";
            registerlabel5.Size = new Size(117, 21);
            registerlabel5.TabIndex = 21;
            registerlabel5.Text = "специальность";
            // 
            // registertextBox5
            // 
            registertextBox5.Location = new Point(226, 390);
            registertextBox5.Margin = new Padding(4);
            registertextBox5.Name = "registertextBox5";
            registertextBox5.Size = new Size(368, 29);
            registertextBox5.TabIndex = 22;
            registertextBox5.Visible = false;
            // 
            // registerlabel6
            // 
            registerlabel6.AutoSize = true;
            registerlabel6.Location = new Point(226, 365);
            registerlabel6.Margin = new Padding(4, 0, 4, 0);
            registerlabel6.Name = "registerlabel6";
            registerlabel6.Size = new Size(71, 21);
            registerlabel6.TabIndex = 23;
            registerlabel6.Text = "кафедра";
            registerlabel6.Visible = false;
            // 
            // registerbutton1
            // 
            registerbutton1.Location = new Point(323, 457);
            registerbutton1.Margin = new Padding(4);
            registerbutton1.Name = "registerbutton1";
            registerbutton1.Size = new Size(184, 56);
            registerbutton1.TabIndex = 24;
            registerbutton1.Text = "Зарегистрироваться";
            registerbutton1.UseVisualStyleBackColor = true;
            registerbutton1.Click += registerbutton1_Click_1;
            // 
            // Loadlabel1
            // 
            Loadlabel1.AutoSize = true;
            Loadlabel1.Font = new Font("Segoe UI", 15F);
            Loadlabel1.Location = new Point(542, 475);
            Loadlabel1.Name = "Loadlabel1";
            Loadlabel1.Size = new Size(104, 28);
            Loadlabel1.TabIndex = 25;
            Loadlabel1.Text = "Загрузка...";
            Loadlabel1.Visible = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 190, 200);
            ClientSize = new Size(784, 561);
            Controls.Add(Loadlabel1);
            Controls.Add(registerbutton1);
            Controls.Add(registerlabel6);
            Controls.Add(registerlabel5);
            Controls.Add(registercheckBox2);
            Controls.Add(registerlabel4);
            Controls.Add(registercomboBox1);
            Controls.Add(registerlabel3);
            Controls.Add(registertextBox3);
            Controls.Add(registerlabel2);
            Controls.Add(registerlabel1);
            Controls.Add(registertextBox2);
            Controls.Add(registertextBox1);
            Controls.Add(registertextBox5);
            Controls.Add(registertextBox4);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel loginlinkLabel1;
        private Label registerlabel2;
        private Label registerlabel1;
        private TextBox registertextBox2;
        private TextBox registertextBox1;
        private Label registerlabel3;
        private TextBox registertextBox3;
        private ComboBox registercomboBox1;
        private Label registerlabel4;
        private CheckBox registercheckBox2;
        private TextBox registertextBox4;
        private Label registerlabel5;
        private TextBox registertextBox5;
        private Label registerlabel6;
        private Button registerbutton1;
        private Label Loadlabel1;
    }
}