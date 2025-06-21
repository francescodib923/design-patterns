using AppStudio.PatternsApp.Utility;

namespace DesignPatterns.Behavioural_Patterns.Observer
{
    public interface IObserver
    {
        void Update(States state);
    }
}