using System.Windows.Forms;

namespace NotesExtensionVS.Logic.Loaders
{
    public static class NoteLoader
    {
        /// <summary>
        /// Класс предназначен для загрузки уже существующих заметок.
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public static string Load(string note)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return note;
            }

            string filename = openFileDialog.FileName;
            string fileText = System.IO.File.ReadAllText(filename);

            return fileText;
        }
    }
}
