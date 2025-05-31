namespace PatternsApp.Behavioral_Patterns.Command
{
    /// <summary>
    /// Partecipant for Command Pattern
    /// Knows how to perform the operations associated with carrying out a request.
    /// Any class may serve as a receiver (in this example, it has to inherit the <see cref="IReceivable"/> interface)
    /// </summary>
    public class Receiver : IReceivable
    {
        public void Action()
        {
            Console.WriteLine($"{nameof(Receiver)}: Executing the action");
        }
    }
}
