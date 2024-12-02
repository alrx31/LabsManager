namespace LabsManager
{
    partial class LabForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(23, 13, 23, 67);
            flowLayoutPanel1.Size = new Size(914, 645);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(26, 26);
            label1.Margin = new Padding(3, 13, 3, 13);
            label1.Name = "label1";
            label1.Size = new Size(130, 54);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(26, 106);
            label6.Margin = new Padding(3, 13, 3, 13);
            label6.Name = "label6";
            label6.Size = new Size(141, 37);
            label6.TabIndex = 6;
            label6.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(26, 169);
            label4.Margin = new Padding(3, 13, 3, 13);
            label4.Name = "label4";
            label4.Size = new Size(141, 37);
            label4.TabIndex = 4;
            label4.Text = "Описание";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(26, 232);
            label2.Margin = new Padding(3, 13, 3, 13);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(26, 295);
            label5.Margin = new Padding(3, 13, 3, 13);
            label5.Name = "label5";
            label5.Size = new Size(159, 37);
            label5.TabIndex = 5;
            label5.Text = "Материалы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(26, 358);
            label3.Margin = new Padding(3, 13, 3, 13);
            label3.Name = "label3";
            label3.Size = new Size(90, 37);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(26, 412);
            button1.Margin = new Padding(3, 4, 34, 40);
            button1.Name = "button1";
            button1.Size = new Size(229, 67);
            button1.TabIndex = 3;
            button1.Text = "Скачать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Segoe UI", 16F);
            button2.Location = new Point(26, 523);
            button2.Margin = new Padding(3, 4, 34, 40);
            button2.Name = "button2";
            button2.Size = new Size(229, 67);
            button2.TabIndex = 7;
            button2.Text = "Добавить отчет";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.Font = new Font("Segoe UI", 16F);
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(26, 634);
            button3.Margin = new Padding(3, 4, 34, 40);
            button3.Name = "button3";
            button3.Size = new Size(229, 67);
            button3.TabIndex = 8;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // LabForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 255);
            ClientSize = new Size(914, 645);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LabForm";
            Text = "LabForm";
            Load += LabForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button3;
    }
}