using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    /// <summary>
    /// Форма всего проекта, главная часть.
    /// </summary>
    partial class Form1 : Form
    {
        // Проверка, что текст вкладки сохранён в файл.
        private Dictionary<TabPage, bool> checkIsSave;

        /// <summary>
        /// Для проверки, что настройки уже открыты.
        /// </summary>
        public bool CheckSettingsOpen
        {
            get
            {
                return settingsToolStripMenuItem.Enabled;
            }
            set
            {
                settingsToolStripMenuItem.Enabled = value;
            }
        }

        /// <summary>
        /// Для возможности обращения к изменению таймера.
        /// </summary>
        public Timer TimerSave
        {
            get
            {
                return timer;
            }
            set
            {
                timer = value;
            }
        }

        /// <summary>
        /// Конструкт формы c созданием checkIsSave.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            checkIsSave = new Dictionary<TabPage, bool>();
        }

        /// <summary>
        /// Получение настроек таймера из файла.
        /// </summary>
        /// <param name="informationTime">строчка из файла с информацией о таймере.</param>
        private void SetTime(string informationTime)
        {
            if (informationTime == null)
            {
                return;
            }
            if (informationTime == "1")
            {
                timer.Interval = 30000;
                timer.Start();
            }
            else if (informationTime == "2")
            {
                timer.Interval = 60000;
                timer.Start();
            }
            else
            {
                timer.Interval = 10000;
                timer.Stop();
            }
        }

        /// <summary>
        /// Получение настроек фона из файла.
        /// </summary>
        /// <param name="informationColor">строчка из файла с информацией о цвете.</param>
        private void SetColor(string informationColor)
        {
            if (informationColor == null)
            {
                return;
            }
            string[] colorsNames = { "Стандарт", "Синий", "Белый", "Зелёный" };
            Color[] colors = { SystemColors.Control, Color.Blue,
                            Color.White, Color.Green };
            for (int i = 0; i < 4; ++i)
            {
                if (informationColor == colorsNames[i])
                {
                    BackColor = colors[i];
                }
            }
        }

        /// <summary>
        /// Получение прошлых файлов.
        /// </summary>
        /// <param name="paths">пути до файлов.</param>
        private void SetFiles(string[] paths)
        {
            for (int i = 2; i < paths.Length; ++i)
            {
                string pathNow = paths[i];
                if (pathNow != null)
                {
                    try
                    {
                        OpenFile(pathNow);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }

        /// <summary>
        /// Востановление прошлых файлов и настроек.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = false;
            try
            {
                if (Text != "NotepadNew")
                {
                    string settings = File.ReadAllText("Settings.txt");
                    if (settings != null)
                    {
                        string[] information = settings.Split('\n');
                        SetTime(information[0]);
                        SetColor(information[1]);
                        if (information[0] != null && information[1] != null)
                        {
                            File.WriteAllText("Settings.txt", information[0] 
                                + '\n' + information[1] + '\n');
                        }
                        SetFiles(information);
                    }
                }
            }
            catch
            {
                File.WriteAllText("Settings.txt", "0\nСтандарт\n");
                return;
            }
        }

        /// <summary>
        /// Открытие настроек.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settingsToolStripMenuItem.Enabled = false;
            settings.Show();
        }

        /// <summary>
        /// Создание файла, окно ввода.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFileForm input = new CreateFileForm(this);
            input.Show();
        }

        /// <summary>
        /// Создание файла по пути.
        /// </summary>
        /// <param name="path">путь файла.</param>
        public void CreateFile(string path)
        {
            TabPage tabPageOneFile = new TabPage();
            tabPageOneFile.Text = path;
            RichTextBox fileText = new RichTextBox();
            fileText.ContextMenuStrip = contextMenuStrip;
            fileText.TextChanged += new EventHandler(CheckOneFileChange);
            checkIsSave[tabPageOneFile] = true;
            fileText.Name = "fileText";
            fileText.Size = new Size(523, 376);
            tabPageOneFile.Controls.Add(fileText);
            tabControlFiles.TabPages.Add(tabPageOneFile);
        }

        /// <summary>
        /// Кнопка сохранения одного файла.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void buttonSaveOneFile_Click(object sender, EventArgs e)
        {
            try
            {
                TabPage tabPageNow = tabControlFiles.SelectedTab;
                if (tabPageNow.Name != "StartMenu")
                {
                    string path = tabPageNow.Text;
                    RichTextBox fileText = (RichTextBox)tabPageNow.Controls["fileText"];
                    if (path == null || !File.Exists(path))
                    {
                        MessageBox.Show("Вашего файла не существует.");
                        return;
                    }
                    if (fileText.Text == null)
                    {
                        MessageBox.Show("Ваш текст некорректен.");
                        return;
                    }
                    if (Path.GetExtension(path) == ".rtf")
                    {
                        fileText.SaveFile(path);
                    }
                    else
                    {
                        File.WriteAllText(path, fileText.Text);
                    }
                    checkIsSave[tabPageNow] = true;
                    MessageBox.Show("Файл сохранён.");
                }
                else
                {
                    MessageBox.Show("Невозможно сохранить стартовое окно.");
                }
            }
            catch
            {
                MessageBox.Show("Ваш файл или текст некорректен.\nСкорее всего Вы забыли закрыть файл.");
            }
        }

        /// <summary>
        /// Открытие файла и поля ввода.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileForm input = new OpenFileForm(this);
            input.Show();
        }

        /// <summary>
        /// Открытие файла по пути.
        /// </summary>
        /// <param name="path">путь до файла.</param>
        public void OpenFile(string path)
        {
            TabPage tabPageOneFile = new TabPage();
            tabPageOneFile.Name = checkIsSave.Count.ToString();
            tabPageOneFile.Text = path;
            RichTextBox fileText = new RichTextBox();
            fileText.ContextMenuStrip = contextMenuStrip;
            fileText.Name = "fileText";
            fileText.Size = new Size(523, 376);
            if (Path.GetExtension(path) == ".rtf")
            {
                fileText.LoadFile(path);
            }
            else
            {
                fileText.Text = File.ReadAllText(path);
            }
            fileText.TextChanged += new EventHandler(CheckOneFileChange);
            checkIsSave[tabPageOneFile] = true;
            tabPageOneFile.Controls.Add(fileText);
            tabControlFiles.TabPages.Add(tabPageOneFile);
        }

        /// <summary>
        /// Кнопка закрытия приложения.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Кнопка закрытия вкладки.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            TabPage tabPageNow = tabControlFiles.SelectedTab;
            if (tabPageNow.Name != "StartMenu")
            {
                if (checkIsSave[tabPageNow])
                {
                    tabControlFiles.TabPages.Remove(tabPageNow);
                }
                else
                {
                    DialogResult stop = MessageBox.Show("Файл не сохранён. Точно закрыть вкладку?" +
                    "\nДа - сохранить файл и закрыть" +
                    "\nНет - не сохранять и закрыть" +
                    "\nОтмена - отменить закрытие",
                    "Выход", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (stop == DialogResult.No)
                    {
                        tabControlFiles.TabPages.Remove(tabPageNow);
                    }
                    else if (stop == DialogResult.Yes)
                    {
                        SaveOneFile(tabPageNow);
                        tabControlFiles.TabPages.Remove(tabPageNow);
                    }
                }
            }
            else
            {
                MessageBox.Show("Невозможно закрыть стартовое окно.");
            }
        }

        /// <summary>
        /// Сохранение 1 файла без сообщений.
        /// </summary>
        /// <param name="tabPageFile">вкладка с файлом.</param>
        private void SaveOneFile(TabPage tabPageFile)
        {
            string path = tabPageFile.Text;
            RichTextBox fileText = (RichTextBox)tabPageFile.Controls["fileText"];
            if (Path.GetExtension(path) == ".rtf")
            {
                fileText.SaveFile(path);
            }
            else
            {
                File.WriteAllText(path, fileText.Text);
            }
            checkIsSave[tabPageFile] = true;
        }

        /// <summary>
        /// Сохранение всех файлов.
        /// </summary>
        public void SaveAll()
        {
            foreach (TabPage tabPageNow in tabControlFiles.TabPages)
            {
                if (tabPageNow.Name != null && tabPageNow.Name != "StartMenu")
                {
                    try
                    {
                        SaveOneFile(tabPageNow);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }

        /// <summary>
        /// Кнопка для сохранения всех файлов.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void buttonSaveAll_Click(object sender, EventArgs e)
        {
            SaveAll();
        }

        private void CheckOneFileChange(object sender, EventArgs e)
        {
            checkIsSave[tabControlFiles.SelectedTab] = false;
        }

        /// <summary>
        /// Сохранение всех путей в файл.
        /// </summary>
        private void SavePaths()
        {
            if (Text != "NotepadNew")
            {
                foreach (TabPage tabPageNow in tabControlFiles.TabPages)
                {
                    if (tabPageNow.Name != null && tabPageNow.Name != "StartMenu")
                    {
                        try
                        {
                            if (tabPageNow.Text != null)
                            {
                                File.AppendAllText("Settings.txt", tabPageNow.Text + '\n');
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Выход из приложения с вариантом сохранить всё.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool allSave = true;
            foreach (TabPage tabPageNow in tabControlFiles.TabPages)
            {
                if (tabPageNow.Name != null && tabPageNow.Name != "StartMenu")
                {
                    allSave &= checkIsSave[tabPageNow];
                }
            }
            if (allSave)
            {
                SavePaths();
                e.Cancel = false;
            }
            else
            {
                DialogResult stop = MessageBox.Show("Некоторые файлы не сохранены. Точно выйти?" +
                    "\nДа - сохранить всё и выйти" +
                    "\nНет - не сохранять и выйти" +
                    "\nОтмена - отменить закрытие", 
                    "Выход", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (stop == DialogResult.No)
                {
                    SavePaths();
                    e.Cancel = false;
                }
                else if (stop == DialogResult.Yes)
                {
                    SaveAll();
                    SavePaths();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Сохранение всех файлов при достижении времени таймера.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            SaveAll();
        }

        /// <summary>
        /// Выбор формата курсив.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void italicAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPageNow = tabControlFiles.SelectedTab;
            RichTextBox fileText = (RichTextBox)tabPageNow.Controls["fileText"];
            if (fileText == null)
            {
                return;
            }
            if (fileText.SelectionFont == null)
            {
                fileText.SelectionFont = new Font(fileText.Font, FontStyle.Italic);
                return;
            }
            fileText.SelectionFont = new Font(fileText.Font, FontStyle.Italic ^ fileText.SelectionFont.Style);
        }

        /// <summary>
        /// Выбор формата жирный.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void boldAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPageNow = tabControlFiles.SelectedTab;
            RichTextBox fileText = (RichTextBox)tabPageNow.Controls["fileText"];
            if (fileText == null)
            {
                return;
            }
            if (fileText.SelectionFont == null)
            {
                fileText.SelectionFont = new Font(fileText.Font, FontStyle.Bold);
                return;
            }
            fileText.SelectionFont = new Font(fileText.Font, FontStyle.Bold ^ fileText.SelectionFont.Style);
        }

        /// <summary>
        /// Выбор формата подчёркнутый.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void underlineAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPageNow = tabControlFiles.SelectedTab;
            RichTextBox fileText = (RichTextBox)tabPageNow.Controls["fileText"];
            if (fileText == null)
            {
                return;
            }
            if (fileText.SelectionFont == null)
            {
                fileText.SelectionFont = new Font(fileText.Font, FontStyle.Underline);
                return;
            }
            fileText.SelectionFont = new Font(fileText.Font, FontStyle.Underline ^ fileText.SelectionFont.Style);
        }

        /// <summary>
        /// Выбор формата зачёркнутый.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void strikeoutAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPageNow = tabControlFiles.SelectedTab;
            RichTextBox fileText = (RichTextBox)tabPageNow.Controls["fileText"];
            if (fileText == null)
            {
                return;
            }
            if (fileText.SelectionFont == null)
            {
                fileText.SelectionFont = new Font(fileText.Font, FontStyle.Strikeout);
                return;
            }
            fileText.SelectionFont = new Font(fileText.Font, FontStyle.Strikeout ^ fileText.SelectionFont.Style);
        }

        /// <summary>
        /// Выбрать весь текст файла.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPageNow = tabControlFiles.SelectedTab;
            RichTextBox fileText = (RichTextBox)tabPageNow.Controls["fileText"];
            if (fileText == null)
            {
                return;
            }
            fileText.SelectionStart = 0;
            fileText.SelectionLength = fileText.TextLength;
        }

        /// <summary>
        /// Выбрать часть файла и вырезать.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void selectCutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPageNow = tabControlFiles.SelectedTab;
            RichTextBox fileText = (RichTextBox)tabPageNow.Controls["fileText"];
            if (fileText == null)
            {
                return;
            }
            Clipboard.SetText(fileText.SelectedText);
            fileText.SelectedText = "";
        }

        /// <summary>
        /// Выбрать часть файла и скопировать.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void selectCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPageNow = tabControlFiles.SelectedTab;
            RichTextBox fileText = (RichTextBox)tabPageNow.Controls["fileText"];
            if (fileText == null)
            {
                return;
            }
            Clipboard.SetText(fileText.SelectedText);
        }

        /// <summary>
        /// Выбрать часть файла и вставить.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void selectPasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPageNow = tabControlFiles.SelectedTab;
            RichTextBox fileText = (RichTextBox)tabPageNow.Controls["fileText"];
            if (fileText == null)
            {
                return;
            }
            try
            {
                if (Clipboard.GetText() == null)
                {
                    MessageBox.Show("Вы вставили не строку.");
                    return;
                }
                fileText.SelectedText = Clipboard.GetText();
            }
            catch
            {
                MessageBox.Show("Вы вставили не строку.");
            }
        }

        /// <summary>
        /// Создать новое окно с новым файлом.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void createWindow_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Text = "NotepadNew";
            newForm.createToolStripMenuItem_Click(sender, e);
            newForm.Show();
        }

        /// <summary>
        /// Создать новое окно и открыть файл.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void openWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Text = "NotepadNew";
            newForm.openToolStripMenuItem_Click(sender, e);
            newForm.Show();
        }

        /// <summary>
        /// Определение горячих клавиш.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="keys"></param>
        /// <returns>всегда true.</returns>
        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case Keys.N | Keys.Control:
                    createWindow_Click(message, null);
                    return true;
                case Keys.N | Keys.Control | Keys.Shift:
                    createToolStripMenuItem_Click(message, null);
                    return true;
                case Keys.S | Keys.Control:
                    buttonSaveOneFile_Click(message, null);
                    return true;
                case Keys.S | Keys.Control | Keys.Shift:
                    SaveAll();
                    return true;
                case Keys.D | Keys.Control:
                    Close();
                    return true;
            }
            return base.ProcessCmdKey(ref message, keys);
        }

        /// <summary>
        /// Создание правка выделить всё.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void editAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectAllToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Создание правка вырезать часть.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void editCutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectCutToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Создание правка копировать часть.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void editCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectCopyToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Создание правка вставить часть.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void editPasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectPasteToolStripMenuItem_Click(sender, e);
        }
    }
}
