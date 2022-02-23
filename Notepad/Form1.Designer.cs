
namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.openWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeoutAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlFiles = new System.Windows.Forms.TabControl();
            this.StartMenu = new System.Windows.Forms.TabPage();
            this.buttonSaveOneFile = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.tabControlFiles.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(860, 33);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.createWindow,
            this.openWindowToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.closeToolStripMenuItem.Text = "Закрыть программу";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // createWindow
            // 
            this.createWindow.Name = "createWindow";
            this.createWindow.Size = new System.Drawing.Size(303, 34);
            this.createWindow.Text = "Создать в новом окне";
            this.createWindow.Click += new System.EventHandler(this.createWindow_Click);
            // 
            // openWindowToolStripMenuItem
            // 
            this.openWindowToolStripMenuItem.Name = "openWindowToolStripMenuItem";
            this.openWindowToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.openWindowToolStripMenuItem.Text = "Открыть в новом окне";
            this.openWindowToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAllToolStripMenuItem,
            this.editCutToolStripMenuItem,
            this.editCopyToolStripMenuItem,
            this.editPasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // editAllToolStripMenuItem
            // 
            this.editAllToolStripMenuItem.Name = "editAllToolStripMenuItem";
            this.editAllToolStripMenuItem.Size = new System.Drawing.Size(528, 34);
            this.editAllToolStripMenuItem.Text = "Выбрать весь текст";
            this.editAllToolStripMenuItem.Click += new System.EventHandler(this.editAllToolStripMenuItem_Click);
            // 
            // editCutToolStripMenuItem
            // 
            this.editCutToolStripMenuItem.Name = "editCutToolStripMenuItem";
            this.editCutToolStripMenuItem.Size = new System.Drawing.Size(528, 34);
            this.editCutToolStripMenuItem.Text = "Вырезать выделенный фрагмент";
            this.editCutToolStripMenuItem.Click += new System.EventHandler(this.editCutToolStripMenuItem_Click);
            // 
            // editCopyToolStripMenuItem
            // 
            this.editCopyToolStripMenuItem.Name = "editCopyToolStripMenuItem";
            this.editCopyToolStripMenuItem.Size = new System.Drawing.Size(528, 34);
            this.editCopyToolStripMenuItem.Text = "Копировать выделенный фрагмент";
            this.editCopyToolStripMenuItem.Click += new System.EventHandler(this.editCopyToolStripMenuItem_Click);
            // 
            // editPasteToolStripMenuItem
            // 
            this.editPasteToolStripMenuItem.Name = "editPasteToolStripMenuItem";
            this.editPasteToolStripMenuItem.Size = new System.Drawing.Size(528, 34);
            this.editPasteToolStripMenuItem.Text = "Вставить сохранённый в буфере обмена фрагмент";
            this.editPasteToolStripMenuItem.Click += new System.EventHandler(this.editPasteToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDelToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.formatToolStripMenuItem.Text = "Формат";
            // 
            // addDelToolStripMenuItem
            // 
            this.addDelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.italicAddToolStripMenuItem,
            this.boldAddToolStripMenuItem,
            this.underlineAddToolStripMenuItem,
            this.strikeoutAddToolStripMenuItem});
            this.addDelToolStripMenuItem.Name = "addDelToolStripMenuItem";
            this.addDelToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.addDelToolStripMenuItem.Text = "Добавить\\Убрать";
            // 
            // italicAddToolStripMenuItem
            // 
            this.italicAddToolStripMenuItem.Name = "italicAddToolStripMenuItem";
            this.italicAddToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.italicAddToolStripMenuItem.Text = "Курсив";
            this.italicAddToolStripMenuItem.Click += new System.EventHandler(this.italicAddToolStripMenuItem_Click);
            // 
            // boldAddToolStripMenuItem
            // 
            this.boldAddToolStripMenuItem.Name = "boldAddToolStripMenuItem";
            this.boldAddToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.boldAddToolStripMenuItem.Text = "Жирный";
            this.boldAddToolStripMenuItem.Click += new System.EventHandler(this.boldAddToolStripMenuItem_Click);
            // 
            // underlineAddToolStripMenuItem
            // 
            this.underlineAddToolStripMenuItem.Name = "underlineAddToolStripMenuItem";
            this.underlineAddToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.underlineAddToolStripMenuItem.Text = "Подчёркнутый";
            this.underlineAddToolStripMenuItem.Click += new System.EventHandler(this.underlineAddToolStripMenuItem_Click);
            // 
            // strikeoutAddToolStripMenuItem
            // 
            this.strikeoutAddToolStripMenuItem.Name = "strikeoutAddToolStripMenuItem";
            this.strikeoutAddToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.strikeoutAddToolStripMenuItem.Text = "Зачёркнутый";
            this.strikeoutAddToolStripMenuItem.Click += new System.EventHandler(this.strikeoutAddToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // tabControlFiles
            // 
            this.tabControlFiles.Controls.Add(this.StartMenu);
            this.tabControlFiles.Location = new System.Drawing.Point(0, 36);
            this.tabControlFiles.Name = "tabControlFiles";
            this.tabControlFiles.SelectedIndex = 0;
            this.tabControlFiles.Size = new System.Drawing.Size(456, 336);
            this.tabControlFiles.TabIndex = 5;
            // 
            // StartMenu
            // 
            this.StartMenu.Location = new System.Drawing.Point(4, 34);
            this.StartMenu.Name = "StartMenu";
            this.StartMenu.Size = new System.Drawing.Size(448, 298);
            this.StartMenu.TabIndex = 0;
            this.StartMenu.Text = "Стартовое окно";
            this.StartMenu.UseVisualStyleBackColor = true;
            // 
            // buttonSaveOneFile
            // 
            this.buttonSaveOneFile.Location = new System.Drawing.Point(540, 70);
            this.buttonSaveOneFile.Name = "buttonSaveOneFile";
            this.buttonSaveOneFile.Size = new System.Drawing.Size(164, 62);
            this.buttonSaveOneFile.TabIndex = 6;
            this.buttonSaveOneFile.Text = "Сохранить файл";
            this.buttonSaveOneFile.UseVisualStyleBackColor = true;
            this.buttonSaveOneFile.Click += new System.EventHandler(this.buttonSaveOneFile_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(540, 188);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(164, 62);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Закрыть вкладку";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Location = new System.Drawing.Point(540, 310);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(164, 62);
            this.buttonSaveAll.TabIndex = 8;
            this.buttonSaveAll.Text = "Сохранить всё";
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            this.buttonSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.selectCutToolStripMenuItem,
            this.selectCopyToolStripMenuItem,
            this.selectPasteToolStripMenuItem,
            this.addFormatToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(554, 164);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(553, 32);
            this.selectAllToolStripMenuItem.Text = "Выбрать весь текст";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // selectCutToolStripMenuItem
            // 
            this.selectCutToolStripMenuItem.Name = "selectCutToolStripMenuItem";
            this.selectCutToolStripMenuItem.Size = new System.Drawing.Size(553, 32);
            this.selectCutToolStripMenuItem.Text = "Вырезать выделенный фрагмент";
            this.selectCutToolStripMenuItem.Click += new System.EventHandler(this.selectCutToolStripMenuItem_Click);
            // 
            // selectCopyToolStripMenuItem
            // 
            this.selectCopyToolStripMenuItem.Name = "selectCopyToolStripMenuItem";
            this.selectCopyToolStripMenuItem.Size = new System.Drawing.Size(553, 32);
            this.selectCopyToolStripMenuItem.Text = "Копировать выделенный фрагмент";
            this.selectCopyToolStripMenuItem.Click += new System.EventHandler(this.selectCopyToolStripMenuItem_Click);
            // 
            // selectPasteToolStripMenuItem
            // 
            this.selectPasteToolStripMenuItem.Name = "selectPasteToolStripMenuItem";
            this.selectPasteToolStripMenuItem.Size = new System.Drawing.Size(553, 32);
            this.selectPasteToolStripMenuItem.Text = "Вставить сохранённый в буфере обмена фрагмент";
            this.selectPasteToolStripMenuItem.Click += new System.EventHandler(this.selectPasteToolStripMenuItem_Click);
            // 
            // addFormatToolStripMenuItem
            // 
            this.addFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.italicToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.strikeoutToolStripMenuItem});
            this.addFormatToolStripMenuItem.Name = "addFormatToolStripMenuItem";
            this.addFormatToolStripMenuItem.Size = new System.Drawing.Size(553, 32);
            this.addFormatToolStripMenuItem.Text = "Добавить\\Убрать формат выделенного фрагмента текста";
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.italicToolStripMenuItem.Text = "Курсив";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicAddToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.boldToolStripMenuItem.Text = "Жирный";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldAddToolStripMenuItem_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.underlineToolStripMenuItem.Text = "Подчёркнутый";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineAddToolStripMenuItem_Click);
            // 
            // strikeoutToolStripMenuItem
            // 
            this.strikeoutToolStripMenuItem.Name = "strikeoutToolStripMenuItem";
            this.strikeoutToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.strikeoutToolStripMenuItem.Text = "Зачёркнутый";
            this.strikeoutToolStripMenuItem.Click += new System.EventHandler(this.strikeoutAddToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 455);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSaveOneFile);
            this.Controls.Add(this.tabControlFiles);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControlFiles.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlFiles;
        private System.Windows.Forms.TabPage StartMenu;
        private System.Windows.Forms.Button buttonSaveOneFile;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ToolStripMenuItem addDelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikeoutAddToolStripMenuItem;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectPasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createWindow;
        private System.Windows.Forms.ToolStripMenuItem openWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPasteToolStripMenuItem;
    }
}

