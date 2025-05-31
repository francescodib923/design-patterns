using PatternsApp.Structural_Patterns.Composite;

namespace PatternsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Folder folder1 = new Folder("Cartella 1");
            folder1.Content?.AddRange(new List<IFileSystem>
            {
                new Folder("Cartella 2"),
                new Structural_Patterns.Composite.File("File 1"),
                new Structural_Patterns.Composite.File("File 2"),
                new Folder("Cartella 3")
            });

            folder1.Open();

            Structural_Patterns.Composite.File file1 = new Structural_Patterns.Composite.File("File 3");
            file1.Write("ho creato un file con questo contenuto...", false);
            file1.Write("ho concatenato il contenuto", true);
            file1.Open();

            file1.Write("ho sovrascritto il contenuto", false);
            file1.Open();

            file1.Delete();
            folder1.Delete();
        }
    }
}
