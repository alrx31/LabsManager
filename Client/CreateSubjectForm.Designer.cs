namespace LabsManager
{
    partial class CreateSubjectForm
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
            label1 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            richTextBoxDesc = new RichTextBox();
            label3 = new Label();
            numericUpDownNeedHours = new NumericUpDown();
            buttonCreateSubject = new Button();
            buttonAddLaboratory = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNeedHours).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(24, 33);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(262, 23);
            textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 75);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Описание";
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxDesc.Location = new Point(24, 93);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(486, 96);
            richTextBoxDesc.TabIndex = 3;
            richTextBoxDesc.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 209);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 4;
            label3.Text = "Требуется Часов";
            // 
            // numericUpDownNeedHours
            // 
            numericUpDownNeedHours.Location = new Point(24, 227);
            numericUpDownNeedHours.Name = "numericUpDownNeedHours";
            numericUpDownNeedHours.Size = new Size(120, 23);
            numericUpDownNeedHours.TabIndex = 5;
            // 
            // buttonCreateSubject
            // 
            buttonCreateSubject.Font = new Font("Segoe UI", 14F);
            buttonCreateSubject.Location = new Point(24, 495);
            buttonCreateSubject.Name = "buttonCreateSubject";
            buttonCreateSubject.Size = new Size(147, 43);
            buttonCreateSubject.TabIndex = 6;
            buttonCreateSubject.Text = " Создать";
            buttonCreateSubject.UseVisualStyleBackColor = true;
            buttonCreateSubject.Click += buttonCreateSubject_Click;
            // 
            // buttonAddLaboratory
            // 
            buttonAddLaboratory.Location = new Point(20, 295);
            buttonAddLaboratory.Name = "buttonAddLaboratory";
            buttonAddLaboratory.Size = new Size(124, 121);
            buttonAddLaboratory.TabIndex = 7;
            buttonAddLaboratory.Text = "Добавить Лабораторную";
            buttonAddLaboratory.UseVisualStyleBackColor = true;
            buttonAddLaboratory.Click += buttonAddLaboratory_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ButtonFace;
            flowLayoutPanel1.Location = new Point(203, 295);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(558, 121);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // CreateSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(buttonAddLaboratory);
            Controls.Add(buttonCreateSubject);
            Controls.Add(numericUpDownNeedHours);
            Controls.Add(label3);
            Controls.Add(richTextBoxDesc);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "CreateSubjectForm";
            Text = "CreateSubjectForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNeedHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private RichTextBox richTextBoxDesc;
        private Label label3;
        private NumericUpDown numericUpDownNeedHours;
        private Button buttonCreateSubject;
        private Button buttonAddLaboratory;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}