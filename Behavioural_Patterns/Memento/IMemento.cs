namespace DesignPatterns.Behavioural_Patterns.Memento
{
    public interface IMemento<T>
    {
        T GetState();
    }
}