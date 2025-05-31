namespace PatternsApp.Creational_Patterns.Singleton
{
    /// <summary>
    /// -- ENGLISH
    /// The Singleton pattern ensures a class has only one instance, and provide a global point of access to it.
    /// -- ITALIANO
    /// Il pattern Singleton garantisce che una classe abbia una sola istanza e fornisce un punto di accesso globale ad essa.
    /// </summary>
    public class LazySingleton
    {
        private static LazySingleton? _Instance;

        // -- ENGLISH
        // Lock for thread-management.
        // -- ITALIANO 
        // Lock per la gestione dei thread
        private static readonly object _lock = new object();
        private LazySingleton() { }

        public static LazySingleton Instance
        {
            get
            {
                if (_Instance == null)
                {
                    // -- ENGLISH Synchronization to avoid race conditions – multiple threads access a shared resource without proper synchronization.
                    // -- ITALIANO Sincronizzazione per evitare race condition - più thread accedono a una risorsa condivisa senza un'adeguata sincronizzazione.
                    lock (_lock)
                    {
                        if (_Instance == null)
                        {
                            // -- ENGLISH A new instance (and only one instance) is created only if i require the static LazySingleton instance
                            // -- ITALIANO Una nuova istanza (e soltanto una istanza) viene creata solo se richiedo l'istanza statica LazySingleton
                            _Instance = new LazySingleton();
                        }
                    }
                }
                return _Instance;
            }
        }
    }

    public class EagerSingleton
    {
        // -- ENGLISH A new instance (and only one instance) is created when the application starts.
        // -- ITALIANO Una nuova istanza (e soltanto una istanza) viene creata quando l'applicazione si avvia.
        private static readonly EagerSingleton _Instance = new EagerSingleton();
        private EagerSingleton() { }

        public static EagerSingleton Instance
        {
            get
            {
                return _Instance;
            }
        }
    }

    public class ModernLazySingleton
    {
        private static readonly bool _IsThreadSafe = false;
        private static readonly Lazy<ModernLazySingleton> _Instance = new Lazy<ModernLazySingleton>(() => new ModernLazySingleton(), _IsThreadSafe);

        private ModernLazySingleton() { }

        public static ModernLazySingleton Instance = _Instance.Value;
    }
}
