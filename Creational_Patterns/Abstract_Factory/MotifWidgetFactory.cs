namespace PatternsApp.Creational_Patterns.Abstract_Factory
{
    //Generare a runtime degli oggetti eterogenei
    //rifare la factory con una interfaccia generica IComponent, poi in base al componente che gli passi, la classe di quel componente 
    //gestirà il comportamento di quel componente.
    internal class MotifWidgetFactory : IWidgetFactory
    {
        public MotifWidgetFactory()
        {
            DeclareFactoryCreation();
        }
        public void DeclareFactoryCreation()
        {
            Console.WriteLine("It's been created a concrete Motif Widget Factory");
        }
        public Window CreateWindow()
        {
            return new MotifWindow();
        }
        public ScrollBar CreateScrollBar()
        {
            return new MotifScrollBar();
        }
    }
}
