namespace LabsManager
{
    partial class CreateLabForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(36, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 36);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(409, 63);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 179);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.Location = new Point(36, 155);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(286, 87);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(36, 25);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(36, 117);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 4;
            label2.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(409, 25);
            label3.Name = "label3";
            label3.Size = new Size(125, 30);
            label3.TabIndex = 5;
            label3.Text = "материалы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(62, 332);
            label4.Name = "label4";
            label4.Size = new Size(241, 30);
            label4.TabIndex = 6;
            label4.Text = "Файл с упражнениями";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(62, 365);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 7;
            button1.Text = "Загрузить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F);
            button2.Location = new Point(103, 495);
            button2.Name = "button2";
            button2.Size = new Size(200, 50);
            button2.TabIndex = 8;
            button2.Text = "Создать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_ClickAsync;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16F);
            button3.Location = new Point(464, 495);
            button3.Name = "button3";
            button3.Size = new Size(200, 50);
            button3.TabIndex = 9;
            button3.Text = "Отмена";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(347, 375);
            label5.Name = "label5";
            label5.Size = new Size(54, 30);
            label5.TabIndex = 10;
            label5.Text = "Path";
            label5.Visible = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(103, 442);
            label6.Name = "label6";
            label6.Size = new Size(54, 30);
            label6.TabIndex = 11;
            label6.Text = "Path";
            label6.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 16F);
            dateTimePicker1.Location = new Point(409, 301);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(409, 268);
            label7.Name = "label7";
            label7.Size = new Size(102, 30);
            label7.TabIndex = 13;
            label7.Text = "сдать до:";
            // 
            // CreateLabForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 255);
            ClientSize = new Size(804, 557);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "CreateLabForm";
            Text = "CreateLabForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
    }
}