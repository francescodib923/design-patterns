namespace DesignPatterns.Behavioural_Patterns.Command
{
    /// <summary>
    /// -- ENGLISH
    /// Also known as Action, Transaction
    /// Encapsulate a request as an object, thereby letting you parametrize clients with different requests,
    /// queue or log requests, and support undoable operations
    /// -- ITALIANO
    /// Anche conosciuto come Action, Transaction
    /// Incapsula una richiesta come un oggetto, permettendo così di parametrizzare i client con richieste diverse,
    /// accodare o registrare le richieste e supportare operazioni annullabili.
    /// </summary>
    public class Command<T> : ICommand where T : IReceivable
    {
        private T _Receiver;

        public Command(T receiver)
        {
            _Receiver = receiver;
        }

        public void Execute()
        {
            _Receiver.Action();
        }
    }
}
