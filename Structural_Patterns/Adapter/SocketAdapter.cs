    /// <summary>
    /// -- ENGLISH
    /// Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise 
    /// because of incompatible interfaces.
    /// -- ITALIANO
    /// Converte l'interfaccia di una classe in un'altra interfaccia che il client si aspetta. 
    /// L'adapter fa collaborare classi che altrimenti non potrebbero.
    /// </summary>
namespace PatternsApp.Structural_Patterns.Adapter
{
    internal class SocketAdapter : IVoltage
    {
        private readonly Socket _Socket;
        public SocketAdapter(Socket socket)
        {
            _Socket = socket;
        }

        public int GetVoltage()
        {
            return _Socket.ProvideElectricity();
        }
    }
}
