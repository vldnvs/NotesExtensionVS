using NotesExtensionVS.Logic.Savers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NotesExtensionVS.Logic
{
    public static class NoteSaver
    {
        public static void Save(string _note)
        {
            string path = $"{Directory.GetCurrentDirectory()}/note.txt";
            File.WriteAllText(path, _note);
        }
    }

}
