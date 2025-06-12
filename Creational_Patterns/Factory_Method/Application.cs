namespace PatternsApp.Creational_Patterns.Factory_Method
{
    /// <summary>
    /// -- ENGLISH
    /// Define an interface for creating an object, but let subclasses decide which class to instantiate.
    /// Factory Method lets a class defer instantiation to subclasses.
    /// -- ITALIANO
    /// Definisce un'interfaccia per creare un oggetto, ma lascia alla sottoclasse decidere quale classe instanziare.
    /// Il Factory Method permettono a una classe di delegare l'istanziazione alle sottoclassi.
    /// </summary>
    public abstract class Application : IApplication
    {
        private List<Document> _documents;
        public Application()
        {
            _documents = new List<Document>();
        }

        public abstract Document CreateDocument(string name);

        public Document NewDocument(string name)
        {
            Document doc = CreateDocument(name);
            _documents.Add(doc);
            doc.Open();
            return doc;
        }

        public Document OpenDocument(string docName)
        {
            Document? doc = _documents.Find(d => d.Name?.Equals(docName) ?? false);
            if (doc == null)
            {
                throw new FileNotFoundException("Document not found", docName);
            }
            doc.Open();
            return doc;
        }
    }
}
