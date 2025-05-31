using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Creational_Patterns.Abstract_Factory
{
    //Generare a runtime degli oggetti eterogenei
    //rifare la factory con una interfaccia generica IComponent, poi in base al componente che gli passi, la classe di quel componente 
    //gestirà il comportamento di quel componente.
    internal class MotifWidgetFactory : IWidgetFactory
    {
        public void Declare_Factory_Creation()
        {
            Console.WriteLine("It's been created a Concrete Factory");
        }
        public IWindow Create_Window()
        {
            return new MotifWindow();
        }
        public IScrollBar Create_ScrollBar()
        {
            return new MotifScrollBar();
        }
    }
}
