using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
