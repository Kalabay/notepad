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
    /// Форма для создания файла.
    /// </summary>
    partial class CreateFileForm : Form
    {
        /// <summary>
        /// Форма, которой принадлежит файл.
        /// </summary>
        private Form1 formNotepad;

        /// <summary>
        /// Конструктор формы для создания файла.
        /// </summary>
        /// <param name="form">форма, которой принадлежит файл.</param>
        public CreateFileForm(Form1 form)
        {
            InitializeComponent();
            formNotepad = form;
        }

        /// <summary>
        /// Кнопка для создания файла по пути из textBox.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            string path = textBoxFileInput.Text;
            if (path == null)
            {
                MessageBox.Show("Путь некорректен.\nПоэтому файл невозможно создать.");
                return;
            }
            try
            {
                if (File.Exists(path))
                {
                    MessageBox.Show("Файл уже существует.\nПоэтому его невозможно создать.");
                }
                else
                {
                    File.WriteAllText(path, "");
                    formNotepad.CreateFile(path);
                }
            }
            catch
            {
                MessageBox.Show("Путь некорректен.\nПоэтому файл невозможно создать.");
            }
            Close();
        }
    }
}
