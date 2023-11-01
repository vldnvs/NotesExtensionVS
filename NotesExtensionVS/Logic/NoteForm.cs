using NotesExtensionVS.Logic.Loaders;
using System.Windows.Forms;

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
            string text = NoteTextBox.Text;

            NoteTextBox.Text = NoteLoader.Load(text);

            System.Windows.Forms.MessageBox.Show("Файл открыт");
        }
    }
}
