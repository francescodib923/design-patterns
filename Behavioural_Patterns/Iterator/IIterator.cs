using System.Collections;

namespace DesignPatterns.Behavioural_Patterns.Iterator
{
    public interface IIterator<out T>
    {
        public T First();
        public T Next();
        public bool IsDone();
        public T CurrentItem();
    }
}
