using System.Collections;

namespace PatternsApp.Behavioral_Patterns.Iterator
{
    public interface IIterator<out T>
    {
        public T First();
        public T Next();
        public bool IsDone();
        public T CurrentItem();
    }
}
