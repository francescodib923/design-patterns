using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Structural_Patterns.Adapter
{
    internal class Socket : ISocket
    {
        public int ProvideElectricity()
        {
            return 220;
        }
    }
}
