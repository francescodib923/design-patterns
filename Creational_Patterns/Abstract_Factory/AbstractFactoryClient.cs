namespace PatternsApp.Creational_Patterns.Abstract_Factory
{
    /// <summary>
    /// -- ENGLISH
    /// Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
    /// -- ITALIANO
    /// Fornisce un interfaccia per creare famiglie di oggetti relazionati o dipendenti tra loro senza specificarne le loro classi concrete.
    /// </summary>
    public class AbstractFactoryClient
    {
        private readonly ScrollBar _scrollBar;
        private readonly Window _window;
        private readonly IWidgetFactory _WidgetFactory;
        public AbstractFactoryClient(IWidgetFactory widgetFactory)
        {
            Console.WriteLine("App has been created");
            _WidgetFactory = widgetFactory;
            _scrollBar = _WidgetFactory.CreateScrollBar();
            _window = _WidgetFactory.CreateWindow();
        }
        public void Run()
        {
            _window.AnnounceComponentCreation();
            _window.Open();
            _scrollBar.AnnounceComponentCreation();
            _scrollBar.Scroll();
        }
    }
}
