using System.Windows.Forms;

namespace NotesExtensionVS.Logic.Loaders
{
    public static class NoteLoader
    {
        public static string Load()
        {
            var openFileDialog = new OpenFileDialog();
            string filename = openFileDialog.FileName;
            string fileText = System.IO.File.ReadAllText(filename);

            return fileText;
        }
    }
}
