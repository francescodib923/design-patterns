using DesignPatterns.Creational_Patterns.Abstract_Factory;
using DesignPatterns.Creational_Patterns.Factory_Method;
using DesignPatterns.Structural_Patterns.Composite;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryClient client = new AbstractFactoryClient(new MotifWidgetFactory());
            client.Run();

            MyApplication app = new MyApplication();
            app.NewDocument("bomba");
            // Folder folder1 = new Folder("Cartella 1");
            // folder1.Content?.AddRange(new List<IFileSystem>
            // {
            //     new Folder("Cartella 2"),
            //     new Structural_Patterns.Composite.File("File 1"),
            //     new Structural_Patterns.Composite.File("File 2"),
            //     new Folder("Cartella 3")
            // });

            // folder1.Open();

            // Structural_Patterns.Composite.File file1 = new Structural_Patterns.Composite.File("File 3");
            // file1.Write("ho creato un file con questo contenuto...", false);
            // file1.Write("ho concatenato il contenuto", true);
            // file1.Open();

            // file1.Write("ho sovrascritto il contenuto", false);
            // file1.Open();

            // file1.Delete();
            // folder1.Delete();

            // byte[] b = new byte[16] { 0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7, 0x8, 0x9, 0xA, 0xB, 0xC, 0xD, 0xE, 0xF };
            // new Random().Shuffle<byte>(b);
            // Guid guid = new Guid(new ReadOnlySpan<byte>(b));
            // System.Console.WriteLine(guid);
        }
    }
}
