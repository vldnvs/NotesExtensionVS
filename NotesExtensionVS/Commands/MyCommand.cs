using NotesExtensionVS.Logic;
using System.Windows.Forms;

namespace NotesExtensionVS
{
    [Command(PackageIds.MyCommand)]
    internal sealed class MyCommand : BaseCommand<MyCommand>
    {
        /// <summary>
        /// Это класс команды в Visual Studio
        /// То есть обработчик кнопочки ("Create note")
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            Form form = new NoteForm();

            form.ShowDialog();
        }
    }
}
