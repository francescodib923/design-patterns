using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Structural_Patterns.Bridge
{
    internal class PMWindowImp : IWindowImp
    {
        public void DevDrawLine()
        {
            PMDrawLine();
        }

        public void DevDrawText()
        {
            PMDrawText();
        }

        public void PMDrawLine() { }

        public void PMDrawText() { }
    }
}
