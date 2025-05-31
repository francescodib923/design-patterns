namespace PatternsApp.Behavioral_Patterns.Iterator
{
    /// <summary>
    /// -- ENGLISH
    /// Also known as Cursor
    /// Provide a way to access the elements of an aggregate object sequentially without
    /// exposing its underlying representation.
    /// -- ITALIANO
    /// Anche conosciuto come Cursor
    /// Fornisce un modo per accedere agli elementi di un oggetto aggregato in modo sequenziale
    /// senza esporne la sua rappresentazione interna.
    /// </summary>
    public class Iterator<T> : IIterator<T>
    {
        private readonly IList<T> _collection;
        public int Index { get; private set; } = 0;

        public Iterator(IList<T> collection)
        {
            _collection = collection;
        }
        public T CurrentItem()
        {
            return _collection[Index];
        }

        public T First()
        {
            if (_collection.Count > 0) 
            {
                Index = 0;
                 return _collection[0]; 
            }
            else 
            {
                throw new InvalidOperationException($"{nameof(_collection)} is empty");
            }
                
        }

        public bool IsDone()
        {
            return Index >= _collection.Count;
        }

        public T Next()
        {
            if (Index >= _collection.Count) throw new InvalidOperationException("No more elements to iterate.");

            return _collection[Index++];
        }
    }
}