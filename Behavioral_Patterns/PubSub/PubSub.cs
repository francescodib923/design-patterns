namespace PatternsApp.Behavioral_Patterns.PubSub
{
    public interface ISubscriber<in T>
    {
        void OnMessageReceived(T message);
    }

    public interface IPublisher<in T>
    {
        void Publish(T message);
    }

    /// <summary>
    /// -- ENGLISH
    ///A delegate is a reference type to a method. It works similarly to a function pointer in C/C++.
    ///It allows passing methods as parameters, assigning them to variables, and invoking them dynamically.
    /// -- ITALIANO
    /// A delegate is a reference type to a method. It works similarly to a function pointer in C/C++.
    ///It allows passing methods as parameters, assigning them to variables, and invoking them dynamically.
    /// </summary>
    /// <typeparam name="T">
    /// -- ENGLISH
    /// The TYPE of the parameter of the method that this delegate encapsulates.
    /// -- ITALIANO
    /// Il TIPO del parametro del metodo che questo delegato incapsula.
    /// </typeparam>
    /// <param name="obj">
    /// -- ENGLISH
    /// The parameter of the method that this delegate encapsulates.</param>
    /// -- ITALIANO
    /// Il parametro del metodo che questo delegato incapsula.
    public delegate void PublisherDelegate<in T>(T obj);

    /// <summary>
    /// -- ENGLISH
    /// The Subscriber class is the equivalent of the "Observer" in the Observer pattern.
    /// -- ITALIANO
    /// La classe Subscriber è l'equivalente della classe "Observer" nel design pattern Observer.
    /// </summary>
    public class Subscriber<T> : ISubscriber<T>
    {
        public T? Message { get; private set; }

        public void OnMessageReceived(T data)
        {
            Message = data;
            Console.WriteLine($"{typeof(T)} - {Message}");
        }
    }

    /// <summary>
    /// The Publisher class is the equivalent of the "Subject" in the Observer pattern.
    /// </summary>
    public class Publisher<T>
    {
        public event PublisherDelegate<T> EventHandler;

        public Publisher()
        {
            EventHandler = delegate { };
        }

        public virtual void Publish(T obj)
        {
            EventHandler.Invoke(obj);
        }
    }
}
