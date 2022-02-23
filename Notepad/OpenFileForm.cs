using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    /// <summary>
    /// Форма для открытия файла.
    /// </summary>
    partial class OpenFileForm : Form
    {
        /// <summary>
        ///  Форма, которой принадлежит файл.
        /// </summary>
        private Form1 formNotepad;

        /// <summary>
        /// Конструктор формы для открытия файла.
        /// </summary>
        /// <param name="form">форма, которой принадлежит файл.</param>
        public OpenFileForm(Form1 form)
        {
            InitializeComponent();
            formNotepad = form;
        }

        /// <summary>
        /// Кнопка для открытия файла по пути из textBox.
        /// </summary>
        /// <param name="sender">ссылка на объект.</param>
        /// <param name="e">объект, относящийся к обрабатываемому событию.</param>
        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            string path = textBoxFileInput.Text;
            if (path == null)
            {
                MessageBox.Show("Путь некорректен.\nПоэтому файл невозможно открыть.");
                return;
            }
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл не существует.\nПоэтому его невозможно открыть.");
                }
                else
                {
                    formNotepad.OpenFile(path);
                }
            }
            catch
            {
                MessageBox.Show("Путь некорректен.\nПоэтому файл невозможно открыть.");
            }
            Close();
        }
    }
}
