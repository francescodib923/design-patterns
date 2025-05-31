using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Structural_Patterns.Bridge
{
    internal abstract class AbstractWindow : IWindow
    {
        private IWindowImp _WindowImp;
        public AbstractWindow(IWindowImp windowImp) 
        {
            _WindowImp = windowImp;
        }

        public void DrawRect()
        {
            Console.WriteLine("Drawing a Rectangle...");
            _WindowImp.DevDrawLine();
            _WindowImp.DevDrawLine();
            _WindowImp.DevDrawLine();
            _WindowImp.DevDrawLine();
        }

        public void DrawText()
        {
            Console.WriteLine("Drawing Text...");
        }
    }
}
