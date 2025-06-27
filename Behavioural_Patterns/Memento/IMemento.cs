namespace DesignPatterns.Behavioural_Patterns.Memento
{
    public interface IMemento
    {
        public IMemento TakeSnapshot(string name);
        public IMemento GetState();
    }
}