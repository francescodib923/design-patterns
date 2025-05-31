using AppStudio.PatternsApp.Utility;

namespace PatternsApp.Behavioral_Patterns.State
{
    /// <summary>
    /// -- ENGLISH
    /// Allow an object to alter its behavior when its internal state changes.
    /// The object will appear to change its class.
    /// Use the state pattern:
    /// 1) When an object's behavior depends on its state, and it must change its behavior at run-time depending on that state.
    /// 2) Operations have large, multipart conditional statements that depend on the object's state. This state is usually represented
    /// by one or more enumerated constants <see cref="States"/>.
    /// N.B. State objects are often Singletons.
    /// -- ITALIANO
    /// Permette a un oggetto di modificare il proprio comportamento quando il suo stato interno cambia.
    /// L'oggetto sembrerà cambiare classe.
    /// </summary>
    public abstract class State : Istate
    {
        public abstract void Handle(Context context);
    }
}