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
            ((System.ComponentModel.ISupportInitialize)numericUpDownNeedHours).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(48, 58);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(262, 23);
            textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 105);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Описание";
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxDesc.Location = new Point(48, 123);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(486, 96);
            richTextBoxDesc.TabIndex = 3;
            richTextBoxDesc.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 245);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 4;
            label3.Text = "Требуется Часов";
            // 
            // numericUpDownNeedHours
            // 
            numericUpDownNeedHours.Location = new Point(48, 276);
            numericUpDownNeedHours.Name = "numericUpDownNeedHours";
            numericUpDownNeedHours.Size = new Size(120, 23);
            numericUpDownNeedHours.TabIndex = 5;
            // 
            // CreateSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
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
    }
}