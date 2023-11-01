using NotesExtensionVS.Logic.Loaders;
using NotesExtensionVS.Logic.Savers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotesExtensionVS.Logic
{
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия кнопки Save.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string text = NoteTextBox.Text;

            NoteSaver.Save(text);

            System.Windows.Forms.MessageBox.Show("Файл сохранен");
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            NoteTextBox.Text = NoteLoader.Load();

            System.Windows.Forms.MessageBox.Show("Файл открыт");
        }
    }
}
