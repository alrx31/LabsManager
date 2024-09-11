namespace LabsManager
{
    partial class LabCreateForm
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
            richTextBoxMaterials = new RichTextBox();
            label4 = new Label();
            openFileDialogGetFile = new OpenFileDialog();
            button1 = new Button();
            buttonCreate2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 22);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(19, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(178, 23);
            textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 90);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Описание";
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(19, 108);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(534, 55);
            richTextBoxDesc.TabIndex = 3;
            richTextBoxDesc.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 189);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "Материалы";
            // 
            // richTextBoxMaterials
            // 
            richTextBoxMaterials.Location = new Point(19, 221);
            richTextBoxMaterials.Name = "richTextBoxMaterials";
            richTextBoxMaterials.Size = new Size(534, 64);
            richTextBoxMaterials.TabIndex = 5;
            richTextBoxMaterials.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 303);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 6;
            label4.Text = "Упражнения";
            // 
            // openFileDialogGetFile
            // 
            openFileDialogGetFile.FileName = "Exersises";
            // 
            // button1
            // 
            button1.Location = new Point(41, 360);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonCreate2
            // 
            buttonCreate2.Location = new Point(538, 368);
            buttonCreate2.Name = "buttonCreate2";
            buttonCreate2.Size = new Size(157, 47);
            buttonCreate2.TabIndex = 8;
            buttonCreate2.Text = "Создать";
            buttonCreate2.UseVisualStyleBackColor = true;
            buttonCreate2.Click += buttonCreate2_Click;
            // 
            // LabCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreate2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(richTextBoxMaterials);
            Controls.Add(label3);
            Controls.Add(richTextBoxDesc);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "LabCreateForm";
            Text = "LabCreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private RichTextBox richTextBoxDesc;
        private Label label3;
        private RichTextBox richTextBoxMaterials;
        private Label label4;
        private OpenFileDialog openFileDialogGetFile;
        private Button button1;
        private Button buttonCreate2;
    }
}