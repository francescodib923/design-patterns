using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Structural_Patterns.Bridge
{
    internal interface IWindow
    {
        public void DrawText();
        public void DrawRect();
    }
}
