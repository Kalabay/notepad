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
    /// Форма настроек приложения.
    /// </summary>
    partial class Settings : Form
    {
        // Форма, которой принадлежат настройки.
        private Form1 formNotepad;

        /// <summary>
        /// Конструктор формы настроек.
        /// </summary>
        /// <param name="form">форма, которой принадлежат настройки.</param>
        public Settings(Form1 form)
        {
            InitializeComponent();
            formNotepad = form;
        }

        /// <summary>
        /// Закрытие настроек.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            formNotepad.CheckSettingsOpen = true;
        }

        /// <summary>
        /// Копирование настроек формы для визуализации.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void Settings_Load(object sender, EventArgs e)
        {
            Color[] colors = { SystemColors.Control,
                Color.Blue, Color.White, Color.Green };
            int indexColor = 0;
            for (int i = 0; i < 4; ++i)
            {
                if (colors[i] == formNotepad.BackColor)
                {
                    indexColor = i;
                }
            }
            RadioButton[] whichColor = { radioButtonColor,
                radioButtonColorBlue, radioButtonColorWhite,
                radioButtonGreen };
            whichColor[indexColor].Checked = true;
            comboBoxTime.DropDownStyle = ComboBoxStyle.DropDownList;
            if (formNotepad.TimerSave.Interval == 30000)
            {
                comboBoxTime.SelectedIndex = 1;
            }
            else if (formNotepad.TimerSave.Interval == 60000)
            {
                comboBoxTime.SelectedIndex = 2;
            }
            else
            {
                comboBoxTime.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Кнопка сохранения изменений в форме и в файл.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            StringBuilder newSettings = new StringBuilder();
            int typeTimeNow = comboBoxTime.SelectedIndex;
            if (typeTimeNow == 1)
            {
                formNotepad.TimerSave.Interval = 30000;
                formNotepad.TimerSave.Start();
            }
            else if (typeTimeNow == 2)
            {
                formNotepad.TimerSave.Interval = 60000;
                formNotepad.TimerSave.Start();
            }
            else
            {
                formNotepad.TimerSave.Interval = 10000;
                formNotepad.TimerSave.Stop();
            }
            newSettings.Append(typeTimeNow.ToString() + '\n');
            bool[] whichColor = { radioButtonColor.Checked, 
                radioButtonColorBlue.Checked, radioButtonColorWhite.Checked, 
                radioButtonGreen.Checked };
            Color[] colors = { SystemColors.Control, 
                Color.Blue, Color.White, Color.Green };
            string[] colorsNames = { "Стандарт", "Синий", "Белый", "Зелёный" };
            for (int i = 0; i < 4; ++i)
            { 
                if (whichColor[i])
                {
                    formNotepad.BackColor = colors[i];
                    newSettings.Append(colorsNames[i] + '\n');
                    break;
                }
            }
            if (formNotepad.Text != "NotepadNew")
            {
                File.WriteAllText("Settings.txt", newSettings.ToString());
            }
        }
    }
}
