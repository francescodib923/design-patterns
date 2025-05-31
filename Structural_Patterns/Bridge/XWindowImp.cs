using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Structural_Patterns.Bridge
{
    internal class XWindowImp : IWindowImp
    {
        public void DevDrawLine()
        {
            XDrawLine();
        }

        public void DevDrawText()
        {
            XDrawText();
        }

        public XWindowImp() { }

        public void XDrawLine() { }
        public void XDrawText() { }
    }
}
