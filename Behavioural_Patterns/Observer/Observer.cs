using AppStudio.PatternsApp.Utility;

namespace DesignPatterns.Behavioural_Patterns.Observer
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
    public class Observer : IObserver
    {
        public States ObserverState { get; private set; } = States.StateA;
        public Observer() { }
        public void Update(States state)
        {
            ObserverState = state;
        }
    }
}
