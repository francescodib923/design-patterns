using AppStudio.PatternsApp.Utility;

namespace DesignPatterns.Behavioural_Patterns.Chain_of_responsibility
{
    public interface IHandler
    {
        public void HandleRequest(IssueType issue);
        public IHandler SetNext(IHandler handler);
    }
}
