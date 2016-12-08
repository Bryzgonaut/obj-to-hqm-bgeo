namespace FileConvertGUI
{
    partial class Form1
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
            this.textBox_InputFile = new System.Windows.Forms.TextBox();
            this.button_InputFile = new System.Windows.Forms.Button();
            this.button_Convert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_VertCount = new System.Windows.Forms.Label();
            this.label_FaceCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_InputFile
            // 
            this.textBox_InputFile.Location = new System.Drawing.Point(14, 53);
            this.textBox_InputFile.Name = "textBox_InputFile";
            this.textBox_InputFile.Size = new System.Drawing.Size(177, 20);
            this.textBox_InputFile.TabIndex = 0;
            this.textBox_InputFile.TextChanged += new System.EventHandler(this.textBox_InputFile_TextChanged);
            // 
            // button_InputFile
            // 
            this.button_InputFile.Location = new System.Drawing.Point(197, 50);
            this.button_InputFile.Name = "button_InputFile";
            this.button_InputFile.Size = new System.Drawing.Size(75, 23);
            this.button_InputFile.TabIndex = 1;
            this.button_InputFile.Text = "Browse";
            this.button_InputFile.UseVisualStyleBackColor = true;
            this.button_InputFile.Click += new System.EventHandler(this.button_InputFile_Click);
            // 
            // button_Convert
            // 
            this.button_Convert.Location = new System.Drawing.Point(98, 226);
            this.button_Convert.Name = "button_Convert";
            this.button_Convert.Size = new System.Drawing.Size(75, 23);
            this.button_Convert.TabIndex = 2;
            this.button_Convert.Text = "Convert";
            this.button_Convert.UseVisualStyleBackColor = true;
            this.button_Convert.Click += new System.EventHandler(this.button_Convert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label_VertCount
            // 
            this.label_VertCount.AutoSize = true;
            this.label_VertCount.Location = new System.Drawing.Point(73, 98);
            this.label_VertCount.Name = "label_VertCount";
            this.label_VertCount.Size = new System.Drawing.Size(118, 13);
            this.label_VertCount.TabIndex = 3;
            this.label_VertCount.Text = "no information available";
            // 
            // label_FaceCount
            // 
            this.label_FaceCount.AutoSize = true;
            this.label_FaceCount.Location = new System.Drawing.Point(76, 128);
            this.label_FaceCount.Name = "label_FaceCount";
            this.label_FaceCount.Size = new System.Drawing.Size(118, 13);
            this.label_FaceCount.TabIndex = 4;
            this.label_FaceCount.Text = "no information available";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_FaceCount);
            this.Controls.Add(this.label_VertCount);
            this.Controls.Add(this.button_Convert);
            this.Controls.Add(this.button_InputFile);
            this.Controls.Add(this.textBox_InputFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_InputFile;
        private System.Windows.Forms.Button button_InputFile;
        private System.Windows.Forms.Button button_Convert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_VertCount;
        private System.Windows.Forms.Label label_FaceCount;
    }
}

