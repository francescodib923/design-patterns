namespace PatternsApp.Structural_Patterns.Composite
{
    public class File : IFileSystem
    {
        public string Name { get; set; }
        public string Content { get; set; } = string.Empty;

        public File(string name)
        {
            Name = name;
        }
        public void Open()
        {
            System.Console.WriteLine(Content);
        }

        public void Write(string content, bool concat = true)
        {
            if (concat)
            {
                Content += $" {content}";
            }
            else
            {
                Content = content;
            }
        }

        public void Rename(string newName)
        {
            Name = newName;
        }

        public void Delete()
        {
            Content = string.Empty;
            System.Console.WriteLine($"File nominato:{Name} è stato eliminato");
        }
    }
}