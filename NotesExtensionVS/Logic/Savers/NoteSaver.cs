using System.IO;

namespace NotesExtensionVS.Logic
{
    public static class NoteSaver
    {
        /// <summary>
        /// Класс предназначен для сохранения заметок.
        /// </summary>
        /// <param name="_note"></param>
        public static void Save(string _note)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "note.txt");
            File.WriteAllText(path, _note);
        }
    }

}
