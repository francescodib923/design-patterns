using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Creational_Patterns.Abstract_Factory
{
    internal class MotifWindow : IWindow
    {
        public MotifWindow() { }
        public void Declare_Window_Creation()
        {
            Console.WriteLine("It's been created a Motif Window by the Factory");
        }
        public void Open()
        {
            Console.WriteLine("Motif Window has been opened");
        }
    }
}
