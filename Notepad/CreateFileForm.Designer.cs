
namespace Notepad
{
    partial class CreateFileForm
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
            this.labelFileInput = new System.Windows.Forms.Label();
            this.textBoxFileInput = new System.Windows.Forms.TextBox();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFileInput
            // 
            this.labelFileInput.AutoSize = true;
            this.labelFileInput.Location = new System.Drawing.Point(12, 9);
            this.labelFileInput.Name = "labelFileInput";
            this.labelFileInput.Size = new System.Drawing.Size(201, 25);
            this.labelFileInput.TabIndex = 2;
            this.labelFileInput.Text = "Введите путь до файла:";
            // 
            // textBoxFileInput
            // 
            this.textBoxFileInput.Location = new System.Drawing.Point(12, 37);
            this.textBoxFileInput.Name = "textBoxFileInput";
            this.textBoxFileInput.Size = new System.Drawing.Size(756, 31);
            this.textBoxFileInput.TabIndex = 3;
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Location = new System.Drawing.Point(12, 74);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(201, 50);
            this.buttonCreateFile.TabIndex = 4;
            this.buttonCreateFile.Text = "Создать";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            this.buttonCreateFile.Click += new System.EventHandler(this.buttonCreateFile_Click);
            // 
            // CreateFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 136);
            this.Controls.Add(this.buttonCreateFile);
            this.Controls.Add(this.textBoxFileInput);
            this.Controls.Add(this.labelFileInput);
            this.Name = "CreateFileForm";
            this.Text = "Путь до файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFileInput;
        private System.Windows.Forms.TextBox textBoxFileInput;
        private System.Windows.Forms.Button buttonCreateFile;
    }
}