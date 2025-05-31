using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Creational_Patterns.Abstract_Factory
{
    internal class MotifScrollBar : IScrollBar
    {
        public MotifScrollBar() { }
        public void Declare_ScrollBar_Creation()
        {
            Console.WriteLine("It's been created a Motif ScrollBar by the Factory");
        }
        public void Scroll()
        {
            Console.WriteLine("I have scrolled");
        }
    }
}
