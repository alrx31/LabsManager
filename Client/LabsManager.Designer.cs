﻿namespace LabsManager
{
    partial class LabsManager
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
            panel1 = new Panel();
            panelIndicator = new Panel();
            panelButton2 = new Panel();
            label1 = new Label();
            panelButton1 = new Panel();
            buttontext1 = new Label();
            panelButton3 = new Panel();
            label2 = new Label();
            panelButton4 = new Panel();
            label3 = new Label();
            FormName = new Label();
            maxformbutton = new Label();
            minformbutton = new Label();
            closeformbutton = new Label();
            panel2 = new Panel();
            profilePanel = new Panel();
            ProfilelabelLabsManager = new Label();
            ProfilelabelAdmin = new Label();
            ProfilelabelGroup = new Label();
            Profilelabel4 = new Label();
            ProfilelabelFaculty = new Label();
            Profilelabel3 = new Label();
            ProfilelabelLogin = new Label();
            Profilelabel2 = new Label();
            ProfileLabelName = new Label();
            Profilelabel1 = new Label();
            SubjectsList = new Panel();
            ControlPanel = new Panel();
            Statisticbutton1 = new Button();
            Createbutton1 = new Button();
            flowLayoutPanelListSubjects = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panelButton2.SuspendLayout();
            panelButton1.SuspendLayout();
            panelButton3.SuspendLayout();
            panelButton4.SuspendLayout();
            panel2.SuspendLayout();
            profilePanel.SuspendLayout();
            SubjectsList.SuspendLayout();
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 120, 205);
            panel1.Controls.Add(panelIndicator);
            panel1.Controls.Add(panelButton2);
            panel1.Controls.Add(panelButton1);
            panel1.Controls.Add(panelButton3);
            panel1.Controls.Add(panelButton4);
            panel1.ForeColor = Color.FromArgb(240, 240, 255);
            panel1.Location = new Point(0, 27);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 1111);
            panel1.TabIndex = 0;
            // 
            // panelIndicator
            // 
            panelIndicator.BackColor = Color.FromArgb(10, 10, 250);
            panelIndicator.Location = new Point(47, 395);
            panelIndicator.Margin = new Padding(3, 4, 3, 4);
            panelIndicator.Name = "panelIndicator";
            panelIndicator.Size = new Size(6, 67);
            panelIndicator.TabIndex = 1;
            // 
            // panelButton2
            // 
            panelButton2.BackColor = Color.FromArgb(0, 122, 204);
            panelButton2.Controls.Add(label1);
            panelButton2.Cursor = Cursors.Hand;
            panelButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panelButton2.Location = new Point(0, 93);
            panelButton2.Margin = new Padding(3, 4, 3, 4);
            panelButton2.Name = "panelButton2";
            panelButton2.Size = new Size(229, 67);
            panelButton2.TabIndex = 3;
            panelButton2.Click += panelButton2_Click;
            panelButton2.MouseEnter += panel4_MouseEnter;
            panelButton2.MouseLeave += panelButton2_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 21);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 0;
            label1.Text = "Все лабы";
            label1.Click += panelButton2_Click;
            label1.MouseEnter += panel4_MouseEnter;
            // 
            // panelButton1
            // 
            panelButton1.BackColor = Color.FromArgb(0, 122, 204);
            panelButton1.Controls.Add(buttontext1);
            panelButton1.Cursor = Cursors.Hand;
            panelButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panelButton1.Location = new Point(0, 27);
            panelButton1.Margin = new Padding(3, 4, 3, 4);
            panelButton1.Name = "panelButton1";
            panelButton1.Size = new Size(229, 67);
            panelButton1.TabIndex = 2;
            panelButton1.Click += panelButton1_Click;
            panelButton1.MouseEnter += panelButton1_MouseHover;
            panelButton1.MouseLeave += panelButton1_MouseLeave;
            // 
            // buttontext1
            // 
            buttontext1.AutoSize = true;
            buttontext1.Location = new Point(57, 21);
            buttontext1.Name = "buttontext1";
            buttontext1.Size = new Size(103, 28);
            buttontext1.TabIndex = 0;
            buttontext1.Text = "Профиль";
            buttontext1.Click += panelButton1_Click;
            buttontext1.MouseEnter += panelButton1_MouseHover;
            // 
            // panelButton3
            // 
            panelButton3.BackColor = Color.FromArgb(0, 122, 204);
            panelButton3.Controls.Add(label2);
            panelButton3.Cursor = Cursors.Hand;
            panelButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panelButton3.Location = new Point(0, 160);
            panelButton3.Margin = new Padding(3, 4, 3, 4);
            panelButton3.Name = "panelButton3";
            panelButton3.Size = new Size(229, 67);
            panelButton3.TabIndex = 4;
            panelButton3.Click += panelButton3_Click;
            panelButton3.MouseEnter += panelButton3_MouseEnter;
            panelButton3.MouseLeave += panelButton3_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 20);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 0;
            label2.Text = "На проверке";
            label2.Click += panelButton3_Click;
            label2.MouseEnter += panelButton3_MouseEnter;
            // 
            // panelButton4
            // 
            panelButton4.BackColor = Color.FromArgb(0, 122, 204);
            panelButton4.Controls.Add(label3);
            panelButton4.Cursor = Cursors.Hand;
            panelButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panelButton4.Location = new Point(0, 227);
            panelButton4.Margin = new Padding(3, 4, 3, 4);
            panelButton4.Name = "panelButton4";
            panelButton4.Size = new Size(229, 67);
            panelButton4.TabIndex = 5;
            panelButton4.Click += panelButton4_Click;
            panelButton4.MouseEnter += panelButton4_MouseEnter;
            panelButton4.MouseLeave += panelButton4_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 24);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 0;
            label3.Text = "Проверены";
            label3.Click += panelButton4_Click;
            label3.MouseEnter += panelButton4_MouseEnter;
            // 
            // FormName
            // 
            FormName.AutoSize = true;
            FormName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FormName.ForeColor = SystemColors.WindowFrame;
            FormName.Location = new Point(3, 0);
            FormName.Name = "FormName";
            FormName.Size = new Size(158, 28);
            FormName.TabIndex = 3;
            FormName.Text = "Менеджер лаб";
            // 
            // maxformbutton
            // 
            maxformbutton.AutoSize = true;
            maxformbutton.Cursor = Cursors.Hand;
            maxformbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            maxformbutton.ForeColor = SystemColors.WindowFrame;
            maxformbutton.Location = new Point(1648, 0);
            maxformbutton.Name = "maxformbutton";
            maxformbutton.Size = new Size(33, 28);
            maxformbutton.TabIndex = 2;
            maxformbutton.Text = "▭";
            maxformbutton.Click += label3_Click;
            // 
            // minformbutton
            // 
            minformbutton.AutoSize = true;
            minformbutton.Cursor = Cursors.Hand;
            minformbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            minformbutton.ForeColor = SystemColors.WindowFrame;
            minformbutton.ImageAlign = ContentAlignment.MiddleLeft;
            minformbutton.Location = new Point(1613, -1);
            minformbutton.Name = "minformbutton";
            minformbutton.Size = new Size(30, 28);
            minformbutton.TabIndex = 1;
            minformbutton.Text = "◛";
            minformbutton.Click += label2_Click;
            // 
            // closeformbutton
            // 
            closeformbutton.AutoSize = true;
            closeformbutton.Cursor = Cursors.Hand;
            closeformbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            closeformbutton.ForeColor = SystemColors.WindowFrame;
            closeformbutton.Location = new Point(1686, 0);
            closeformbutton.Name = "closeformbutton";
            closeformbutton.Size = new Size(27, 28);
            closeformbutton.TabIndex = 0;
            closeformbutton.Text = "Ⅹ";
            closeformbutton.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 240, 250);
            panel2.Controls.Add(minformbutton);
            panel2.Controls.Add(maxformbutton);
            panel2.Controls.Add(FormName);
            panel2.Controls.Add(closeformbutton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1714, 27);
            panel2.TabIndex = 2;
            panel2.MouseDown += Form1_MouseDown;
            panel2.MouseMove += Form1_MouseMove;
            panel2.MouseUp += Form1_MouseUp;
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.FromArgb(240, 240, 255);
            profilePanel.Controls.Add(ProfilelabelLabsManager);
            profilePanel.Controls.Add(ProfilelabelAdmin);
            profilePanel.Controls.Add(ProfilelabelGroup);
            profilePanel.Controls.Add(Profilelabel4);
            profilePanel.Controls.Add(ProfilelabelFaculty);
            profilePanel.Controls.Add(Profilelabel3);
            profilePanel.Controls.Add(ProfilelabelLogin);
            profilePanel.Controls.Add(Profilelabel2);
            profilePanel.Controls.Add(ProfileLabelName);
            profilePanel.Controls.Add(Profilelabel1);
            profilePanel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            profilePanel.Location = new Point(229, 27);
            profilePanel.Margin = new Padding(3, 4, 3, 4);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(1486, 1173);
            profilePanel.TabIndex = 3;
            profilePanel.VisibleChanged += profilePanel_VisibleChanged;
            // 
            // ProfilelabelLabsManager
            // 
            ProfilelabelLabsManager.AutoSize = true;
            ProfilelabelLabsManager.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            ProfilelabelLabsManager.ForeColor = SystemColors.WindowFrame;
            ProfilelabelLabsManager.Location = new Point(17, 1105);
            ProfilelabelLabsManager.Name = "ProfilelabelLabsManager";
            ProfilelabelLabsManager.Size = new Size(273, 46);
            ProfilelabelLabsManager.TabIndex = 9;
            ProfilelabelLabsManager.Text = "LabsManager";
            // 
            // ProfilelabelAdmin
            // 
            ProfilelabelAdmin.AutoSize = true;
            ProfilelabelAdmin.Location = new Point(486, 692);
            ProfilelabelAdmin.Name = "ProfilelabelAdmin";
            ProfilelabelAdmin.Size = new Size(153, 29);
            ProfilelabelAdmin.TabIndex = 8;
            ProfilelabelAdmin.Text = "Вы - Админ";
            ProfilelabelAdmin.Visible = false;
            // 
            // ProfilelabelGroup
            // 
            ProfilelabelGroup.AutoSize = true;
            ProfilelabelGroup.Location = new Point(46, 367);
            ProfilelabelGroup.Name = "ProfilelabelGroup";
            ProfilelabelGroup.Size = new Size(85, 29);
            ProfilelabelGroup.TabIndex = 7;
            ProfilelabelGroup.Text = "label2";
            // 
            // Profilelabel4
            // 
            Profilelabel4.AutoSize = true;
            Profilelabel4.Location = new Point(46, 328);
            Profilelabel4.Name = "Profilelabel4";
            Profilelabel4.Size = new Size(101, 29);
            Profilelabel4.TabIndex = 6;
            Profilelabel4.Text = "Группа";
            // 
            // ProfilelabelFaculty
            // 
            ProfilelabelFaculty.AutoSize = true;
            ProfilelabelFaculty.Location = new Point(46, 251);
            ProfilelabelFaculty.Name = "ProfilelabelFaculty";
            ProfilelabelFaculty.Size = new Size(85, 29);
            ProfilelabelFaculty.TabIndex = 5;
            ProfilelabelFaculty.Text = "label2";
            // 
            // Profilelabel3
            // 
            Profilelabel3.AutoSize = true;
            Profilelabel3.Location = new Point(46, 212);
            Profilelabel3.Name = "Profilelabel3";
            Profilelabel3.Size = new Size(144, 29);
            Profilelabel3.TabIndex = 4;
            Profilelabel3.Text = "Факультет";
            // 
            // ProfilelabelLogin
            // 
            ProfilelabelLogin.AutoSize = true;
            ProfilelabelLogin.Location = new Point(46, 148);
            ProfilelabelLogin.Name = "ProfilelabelLogin";
            ProfilelabelLogin.Size = new Size(85, 29);
            ProfilelabelLogin.TabIndex = 3;
            ProfilelabelLogin.Text = "label2";
            // 
            // Profilelabel2
            // 
            Profilelabel2.AutoSize = true;
            Profilelabel2.Location = new Point(45, 109);
            Profilelabel2.Name = "Profilelabel2";
            Profilelabel2.Size = new Size(88, 29);
            Profilelabel2.TabIndex = 2;
            Profilelabel2.Text = "Логин";
            // 
            // ProfileLabelName
            // 
            ProfileLabelName.AutoSize = true;
            ProfileLabelName.Location = new Point(45, 53);
            ProfileLabelName.Name = "ProfileLabelName";
            ProfileLabelName.Size = new Size(54, 29);
            ProfileLabelName.TabIndex = 1;
            ProfileLabelName.Text = "text";
            // 
            // Profilelabel1
            // 
            Profilelabel1.AutoSize = true;
            Profilelabel1.Location = new Point(46, 21);
            Profilelabel1.Name = "Profilelabel1";
            Profilelabel1.Size = new Size(66, 29);
            Profilelabel1.TabIndex = 0;
            Profilelabel1.Text = "Имя";
            // 
            // SubjectsList
            // 
            SubjectsList.BackColor = Color.FromArgb(240, 240, 255);
            SubjectsList.Controls.Add(ControlPanel);
            SubjectsList.Controls.Add(flowLayoutPanelListSubjects);
            SubjectsList.Location = new Point(229, 27);
            SubjectsList.Margin = new Padding(3, 4, 3, 4);
            SubjectsList.Name = "SubjectsList";
            SubjectsList.Size = new Size(1486, 1173);
            SubjectsList.TabIndex = 10;
            SubjectsList.Visible = false;
            SubjectsList.VisibleChanged += SubjectsList_VisibleChanged;
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.FromArgb(0, 100, 255);
            ControlPanel.Controls.Add(Statisticbutton1);
            ControlPanel.Controls.Add(Createbutton1);
            ControlPanel.Location = new Point(0, 1107);
            ControlPanel.Margin = new Padding(3, 4, 3, 4);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(1486, 67);
            ControlPanel.TabIndex = 0;
            // 
            // Statisticbutton1
            // 
            Statisticbutton1.Cursor = Cursors.Hand;
            Statisticbutton1.FlatStyle = FlatStyle.Flat;
            Statisticbutton1.ForeColor = Color.White;
            Statisticbutton1.Location = new Point(1117, 12);
            Statisticbutton1.Margin = new Padding(3, 4, 3, 4);
            Statisticbutton1.Name = "Statisticbutton1";
            Statisticbutton1.Size = new Size(198, 40);
            Statisticbutton1.TabIndex = 4;
            Statisticbutton1.Text = "Получить статистику";
            Statisticbutton1.UseVisualStyleBackColor = true;
            Statisticbutton1.Click += Statisticbutton1_Click;
            // 
            // Createbutton1
            // 
            Createbutton1.Cursor = Cursors.Hand;
            Createbutton1.FlatStyle = FlatStyle.Flat;
            Createbutton1.ForeColor = Color.White;
            Createbutton1.Location = new Point(1336, 12);
            Createbutton1.Margin = new Padding(3, 4, 3, 4);
            Createbutton1.Name = "Createbutton1";
            Createbutton1.Size = new Size(114, 40);
            Createbutton1.TabIndex = 3;
            Createbutton1.Text = "Создать лабу";
            Createbutton1.UseVisualStyleBackColor = true;
            Createbutton1.Click += Createbutton1_Click;
            // 
            // flowLayoutPanelListSubjects
            // 
            flowLayoutPanelListSubjects.AutoScroll = true;
            flowLayoutPanelListSubjects.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelListSubjects.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            flowLayoutPanelListSubjects.Location = new Point(0, 0);
            flowLayoutPanelListSubjects.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelListSubjects.Name = "flowLayoutPanelListSubjects";
            flowLayoutPanelListSubjects.Padding = new Padding(23, 27, 23, 27);
            flowLayoutPanelListSubjects.Size = new Size(1486, 1111);
            flowLayoutPanelListSubjects.TabIndex = 1;
            flowLayoutPanelListSubjects.WrapContents = false;
            // 
            // LabsManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 190, 200);
            ClientSize = new Size(1714, 1200);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(SubjectsList);
            Controls.Add(profilePanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LabsManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Менеджер лаб";
            Load += LabsManager_Load;
            panel1.ResumeLayout(false);
            panelButton2.ResumeLayout(false);
            panelButton2.PerformLayout();
            panelButton1.ResumeLayout(false);
            panelButton1.PerformLayout();
            panelButton3.ResumeLayout(false);
            panelButton3.PerformLayout();
            panelButton4.ResumeLayout(false);
            panelButton4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            SubjectsList.ResumeLayout(false);
            ControlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label closeformbutton;
        private Label minformbutton;
        private Label maxformbutton;
        private Label FormName;
        private Panel panel2;
        private Panel panelIndicator;
        private Panel panelButton1;
        private Label buttontext1;
        private Panel panelButton2;
        private Label label1;
        private Panel profilePanel;
        private Label ProfileLabelName;
        private Label Profilelabel1;
        private Label Profilelabel2;
        private Label ProfilelabelLogin;
        private Label ProfilelabelFaculty;
        private Label Profilelabel3;
        private Label ProfilelabelGroup;
        private Label Profilelabel4;
        private Label ProfilelabelAdmin;
        private Label ProfilelabelLabsManager;
        private Panel SubjectsList;
        private Panel ControlPanel;
        private FlowLayoutPanel flowLayoutPanelListSubjects;
        private Panel panelButton3;
        private Label label2;
        private Panel panelButton4;
        private Label label3;
        private Button Createbutton1;
        private Button Statisticbutton1;
    }
}