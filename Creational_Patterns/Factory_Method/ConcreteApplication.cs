namespace PatternsApp.Creational_Patterns.Factory_Method
{
    public class ConcreteApplication : IApplication
    {
        private List<ConcreteDocument> _documents; //cambiare in modo che sia una lista di documenti generici
        public ConcreteApplication()
        {
            _documents = new List<ConcreteDocument>();
        }
        public IDocument CreateDocument(string name)
        {
            return new ConcreteDocument(name);
        }

        public IDocument NewDocument(string name)
        {
            ConcreteDocument doc = (ConcreteDocument)this.CreateDocument(name);
            _documents.Add(doc);
            doc.Open();
            return doc;
        }

        public IDocument OpenDocument(string docName)
        {
            ConcreteDocument? doc = _documents.Find(d => d.Name.Equals(docName));
            if (doc == null)
            {
                throw new FileNotFoundException("Document not found", docName);
            }
            doc.Open();
            return doc;
        }
    }
}
