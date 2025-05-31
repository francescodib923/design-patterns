using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Creational_Patterns.Factory_Method
{
    internal interface IApplication
    {
        public IDocument CreateDocument(string docName);
        public IDocument NewDocument(string docName);
        public IDocument OpenDocument(string docName);
    }
}
