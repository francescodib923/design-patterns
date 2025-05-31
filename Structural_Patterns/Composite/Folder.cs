using System.Buffers;

namespace PatternsApp.Structural_Patterns.Composite
{
    public class Folder : IFileSystem
    {
        private string Name { get; set; }
        public List<IFileSystem>? Content { get; set; } = new List<IFileSystem>();

        public Folder(string name)
        {
            Name = name;
        }
        public void Open()
        {
            Content?.ForEach((c) =>
            {
                if (c.GetType() == typeof(Folder))
                {
                    System.Console.WriteLine($"{(c as Folder)?.Name} - {nameof(Folder)}");
                }
                else if (c.GetType() == typeof(File))
                {
                    System.Console.WriteLine($"{(c as File)?.Name} - {nameof(File)}");
                }
            });
        }

        public void Rename(string newName)
        {
            this.Name = newName;
        }

        public void Delete()
        {
            Content = null;
            System.Console.WriteLine($"Cartella nominata:{Name} è stata eliminata");
        }
    }
}