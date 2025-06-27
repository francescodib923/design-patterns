namespace DesignPatterns.Behavioural_Patterns.Memento
{
    public abstract class AbstractMemento<T> : IMemento where T : IMemento, ICloneable, new()
    {
        protected T _State { get; set; }

        private AbstractMemento(T state)
        {
            _State = state;
        }
        
        public virtual IMemento GetState()
        {
            return _State;
        }

        public IMemento TakeSnapshot(string name)
        {
            return (T)_State.Clone();
        }
    }
}