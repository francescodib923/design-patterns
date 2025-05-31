using AppStudio.PatternsApp.Utility;

namespace PatternsApp.Behavioral_Patterns.Observer
{
    /// <summary>
    /// -- ENGLISH
    /// Define a one-to-many dependency between objects so that when one object changes state (Subject),
    /// all it's dependents (Observers) are notified and updated automatically.
    /// Implementation of Observer pattern from "Design patterns"
    /// -- ITALIANO
    /// Definisce una dipendenza uno a molti tra oggetti. 
    /// Quando un oggetto cambia stato (Il soggetto), tutti gli oggetti ad esso dipendenti (Gli "Osservatori")
    /// vengono notificati ed aggiornati automaticamente.
    /// Implementazione del pattern architetturale Observer presa da "Design Patterns"
    /// </summary>
    public class Subject : ISubject
    {
        private List<IObserver> _Observers = new List<IObserver>();

        public States SubjectState { get; private set; }

        public Subject() { }

        public void Attach(IObserver observer)
        {
            _Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _Observers)
            {
                observer.Update(SubjectState);
            }
        }

        public States GetState()
        {
            return SubjectState;
        }

        public void SetState(States state)
        {
            SubjectState = state;
            Notify();
        }
    } 
}