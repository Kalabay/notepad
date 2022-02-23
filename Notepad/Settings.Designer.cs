
namespace Notepad
{
    partial class Settings
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
            this.radioButtonColor = new System.Windows.Forms.RadioButton();
            this.radioButtonColorBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonColorWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonColor
            // 
            this.radioButtonColor.AutoSize = true;
            this.radioButtonColor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonColor.Location = new System.Drawing.Point(12, 35);
            this.radioButtonColor.Name = "radioButtonColor";
            this.radioButtonColor.Size = new System.Drawing.Size(120, 32);
            this.radioButtonColor.TabIndex = 1;
            this.radioButtonColor.TabStop = true;
            this.radioButtonColor.Text = "Стандарт";
            this.radioButtonColor.UseVisualStyleBackColor = true;
            // 
            // radioButtonColorBlue
            // 
            this.radioButtonColorBlue.AutoSize = true;
            this.radioButtonColorBlue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonColorBlue.Location = new System.Drawing.Point(12, 73);
            this.radioButtonColorBlue.Name = "radioButtonColorBlue";
            this.radioButtonColorBlue.Size = new System.Drawing.Size(97, 32);
            this.radioButtonColorBlue.TabIndex = 2;
            this.radioButtonColorBlue.TabStop = true;
            this.radioButtonColorBlue.Text = "Синий";
            this.radioButtonColorBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonColorWhite
            // 
            this.radioButtonColorWhite.AutoSize = true;
            this.radioButtonColorWhite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonColorWhite.Location = new System.Drawing.Point(12, 111);
            this.radioButtonColorWhite.Name = "radioButtonColorWhite";
            this.radioButtonColorWhite.Size = new System.Drawing.Size(95, 32);
            this.radioButtonColorWhite.TabIndex = 3;
            this.radioButtonColorWhite.TabStop = true;
            this.radioButtonColorWhite.Text = "Белый";
            this.radioButtonColorWhite.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonGreen.Location = new System.Drawing.Point(12, 149);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(117, 32);
            this.radioButtonGreen.TabIndex = 4;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Зелёный";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelColor.Location = new System.Drawing.Point(0, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(136, 32);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "Цвет фона:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(153, 197);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(164, 62);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "Никогда",
            "30 секунд",
            "1 минута"});
            this.comboBoxTime.Location = new System.Drawing.Point(217, 91);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(182, 33);
            this.comboBoxTime.TabIndex = 6;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(217, 34);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(201, 32);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "Автосохранение:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 271);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.radioButtonGreen);
            this.Controls.Add(this.radioButtonColorWhite);
            this.Controls.Add(this.radioButtonColorBlue);
            this.Controls.Add(this.radioButtonColor);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonColor;
        private System.Windows.Forms.RadioButton radioButtonColorBlue;
        private System.Windows.Forms.RadioButton radioButtonColorWhite;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label labelTime;
    }
}