namespace DesignPatterns.Behavioural_Patterns.Memento
{
    internal class TextEditorSnapshot : IMemento
    {
        public string Name { get; private set; }
        public DateTime LastSnapshotDate { get; }

        private TextEditorSnapshot(string name)
        {
            Name = name;
            LastSnapshotDate = DateTime.Now;
        }
        public IMemento GetState()
        {
            return this;
        }

        public IMemento TakeSnapshot(string name)
        {
            return new TextEditorSnapshot(name);
        }
    }
}