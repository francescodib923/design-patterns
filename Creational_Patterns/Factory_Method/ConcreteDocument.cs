using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Creational_Patterns.Factory_Method
{
    internal class ConcreteDocument : IDocument
    {
        public string Name { get; private set; }
        public ConcreteDocument(string name)
        {
            Name = name;
        }
        public void Close()
        {
            Console.WriteLine($"Closing: {Name}");
        }

        public void Open()
        {
            Console.WriteLine($"Opening: {Name}");
        }

        public void Revert()
        {
            Console.WriteLine($"Reverting: {Name}");
        }

        public void Save()
        {
            Console.WriteLine($"Saving: {Name}");
        }
    }
}
