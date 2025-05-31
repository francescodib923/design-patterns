using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Creational_Patterns.Abstract_Factory
{
    public class AbstractFactoryApp
    {
        private readonly IScrollBar _scrollBar;
        private readonly IWindow _window;
        public AbstractFactoryApp(IWidgetFactory factory)
        {
            Console.WriteLine("App has been created");
            _scrollBar = factory.Create_ScrollBar();
            _window = factory.Create_Window();
        }
        public void Run()
        {
            _window.Declare_Window_Creation();
            _window.Open();
            _scrollBar.Declare_ScrollBar_Creation();
            _scrollBar.Scroll();
        }
    }
}
