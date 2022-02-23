
namespace Notepad
{
    partial class OpenFileForm
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
            this.textBoxFileInput = new System.Windows.Forms.TextBox();
            this.labelFileInput = new System.Windows.Forms.Label();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFileInput
            // 
            this.textBoxFileInput.Location = new System.Drawing.Point(12, 37);
            this.textBoxFileInput.Name = "textBoxFileInput";
            this.textBoxFileInput.Size = new System.Drawing.Size(756, 31);
            this.textBoxFileInput.TabIndex = 0;
            // 
            // labelFileInput
            // 
            this.labelFileInput.AutoSize = true;
            this.labelFileInput.Location = new System.Drawing.Point(12, 9);
            this.labelFileInput.Name = "labelFileInput";
            this.labelFileInput.Size = new System.Drawing.Size(201, 25);
            this.labelFileInput.TabIndex = 1;
            this.labelFileInput.Text = "Введите путь до файла:";
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(12, 74);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(201, 50);
            this.buttonAddFile.TabIndex = 3;
            this.buttonAddFile.Text = "Открыть";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // OpenFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 136);
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.labelFileInput);
            this.Controls.Add(this.textBoxFileInput);
            this.Name = "OpenFileForm";
            this.Text = "Путь до файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileInput;
        private System.Windows.Forms.Label labelFileInput;
        private System.Windows.Forms.Button buttonAddFile;
    }
}