using AppStudio.PatternsApp.Utility;

namespace DesignPatterns.Behavioural_Patterns.Chain_of_responsibility
{
    /// <summary>
    /// -- ENGLISH
    /// Avoid decoupling request from its sender to its receiver by giving more than one
    /// object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object
    /// handles it.
    /// -- ITALIANO
    /// Previene il disaccoppiamento tra il mittente di una richiesta dal suo destinatario, dando a più 
    /// oggetti la possibilità di gestire la richiesta. Collega gli oggetti riceventi in una catena e passa la richiesta lungo la catena 
    /// finché un oggetto non la gestisce.
    /// </summary>
    public class ChainOfResponsibilityHandler : IHandler
    {
        private IHandler? _successor;
        private IssueType _typeOfIssueHandler;
        public ChainOfResponsibilityHandler(IssueType typeOfIssueHandler) 
        {
            _typeOfIssueHandler = typeOfIssueHandler;
        }

        public void HandleRequest(IssueType issue)
        {
            System.Console.WriteLine($"Handler processing request...");
            if (issue == _typeOfIssueHandler)
            {
                System.Console.WriteLine($"request handled to the last handler of the chain, that handles issues of type: {issue}");
                return;
            }
            if (_successor == null)
            {
                System.Console.WriteLine($"no handler in the chain can handle the request of type: {issue}");
                return;
            }
            _successor.HandleRequest(issue);
        }

        public IHandler SetNext(IHandler nextHandler)
        {
            System.Console.WriteLine($"Passing the responsibility to handle the request to: {nameof(nextHandler)}");
            _successor = nextHandler;
            return nextHandler;
        }
    }
}