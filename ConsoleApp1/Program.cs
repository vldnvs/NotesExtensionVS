namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "../../../", "note.txt");
            Console.WriteLine(Path.GetFullPath(path));
        }
    }
}