using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Creational_Patterns.Abstract_Factory
{
    public interface IWidgetFactory
    {
        public void Declare_Factory_Creation();
        public IWindow Create_Window();
        public IScrollBar Create_ScrollBar();
    }
}
