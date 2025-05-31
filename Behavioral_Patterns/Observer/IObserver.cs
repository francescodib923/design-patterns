using AppStudio.PatternsApp.Utility;

namespace PatternsApp.Behavioral_Patterns.Observer
{
    public interface IObserver
    {
        void Update(States state);
    }
}