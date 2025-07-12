namespace DesignPatterns.Behavioural_Patterns.Memento
{
    /// <summary>
    /// -- ITALIANO
    /// Senza violare il principio dell'incapsulamento, cattura ed esternalizza lo stato interno
    /// di un oggetto, così che l'oggetto possa essere ripristinato in seguito.
    /// -- ENGLISH
    /// Without violating encapsulation, capture and externalize an object's internal state 
    /// so that the object can be restored to this state later.
    /// </summary>
    public class Memento<T> : AbstractMemento<T> where T : ICloneable
    {
        public DateTime _Timestamp { get; private set; }
        public Memento(T state) : base(state)
        {
            _Timestamp = DateTime.Now;
        }
        public Memento<T> PrintTimestamp()
        {
            System.Console.WriteLine($"Timestamp of this snapshot: {this._Timestamp.ToLongTimeString()}\n");
            return this;
        }
    }
}